import { Component, OnDestroy, OnInit } from '@angular/core';
import { AccountingService } from '../../shared/accounting.service';
import {
  AccountTypes,
  Classification,
  ClassificationData,
  Classifications,
  TransactionData
} from '../../shared/accounting.model';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Subscription } from 'rxjs';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-equation',
  templateUrl: './equation.component.html',
  styleUrls: ['./equation.component.css']
})
export class EquationComponent implements OnInit, OnDestroy {
  currentAccount: Classification;
  classificationsSub: Subscription;
  form: FormGroup;
  transactionDetails: TransactionData;
  transactionDetailsSub: Subscription;
  method: string;
  typeOfPayment: string;
  assetIncrease: FormControl = new FormControl(false);
  assetDecrease: FormControl = new FormControl(false);
  ownersEquity: FormControl = new FormControl(false);
  liabilitiesIncrease: FormControl = new FormControl(false);
  liabilitiesDecrease: FormControl = new FormControl(false);

  correct = false;

  constructor(private accountingService: AccountingService, private fb: FormBuilder) {
  }

  ngOnInit() {
    this.form = this.fb.group({
      assetIncrease: this.assetIncrease,
      assetDecrease: this.assetDecrease,
      ownersEquity: this.ownersEquity,
      liabilitiesIncrease: this.liabilitiesIncrease,
      liabilitiesDecrease: this.liabilitiesDecrease,
    });
    this.getTransactionDetails();
  }

  getTransactionDetails() {
    this.transactionDetailsSub = this.accountingService.randomTransactionDetails
    .subscribe((transactionDetails: TransactionData) => {
      this.transactionDetails = transactionDetails;
      this.typeOfPayment = transactionDetails.paymentTypes[0];
    });

    this.classificationsSub = this.accountingService.randomClassification.subscribe((classification: ClassificationData) => {
      this.currentAccount = classification.chosenAccount;
    });
  }

  getSpecificAccountType() {
    return this.accountingService.allClassifications
    .pipe(
        map((data: Classifications) => {
          const decreasingOEAccounts = [
            ...data.expenses,
            ...data.drawings
          ];
          const increasingOEAccounts = [
            ...data.incomes,
            ...data.capital
          ];
          const assetAccounts = [
            ...data.assets.slice(0, -1) // excluding bank from the list of accounts
          ];
          const liabilityAccounts = [
            ...data.liabilities
          ];
          return {
            decreasingOEAccounts,
            increasingOEAccounts,
            assetAccounts,
            liabilityAccounts
          };
        })
    );
  }

  onSubmit() {
    // Checking OE accounts
    // Checking decreasing OE and Asset accounts
    this.getSpecificAccountType().subscribe((data: AccountTypes) => {
      if (
          (data.decreasingOEAccounts.indexOf(this.currentAccount) !== -1) &&
          (this.typeOfPayment === 'cash') &&
          (this.form.value.assetDecrease) &&
          (this.form.value.ownersEquity === 'decrease')
      ) {
        this.correct = true;
      } else if (
          (data.increasingOEAccounts.indexOf(this.currentAccount) !== -1) &&  // Checking increasing OE accounts
          (this.typeOfPayment === 'cash') &&
          (this.form.value.assetIncrease) &&
          (this.form.value.ownersEquity === 'increase')) {
        this.correct = true;
      }

      // Checking increasing and decreasing Asset accounts
      if (
          (data.assetAccounts.indexOf(this.currentAccount) !== -1) &&
          (this.typeOfPayment === 'cash') &&
          (this.form.value.assetIncrease) &&
          (this.form.value.assetDecrease)
      ) {
        this.correct = true;
      }

      // Checking increasing Liability and Assets
      if (
          (data.liabilityAccounts.indexOf(this.currentAccount) !== -1) &&
          (this.typeOfPayment === 'cash') &&
          (this.method === 'received') &&
          (this.form.value.liabilitiesIncrease) &&
          (this.form.value.assetIncrease)
      ) {
        this.correct = true;
      }


      console.log(data.assetAccounts);
      // console.log(data.decreasingOEAccounts, this.currentAccount);
      console.log(this.correct);
      setTimeout(() => {
        this.correct = false;
        this.getTransactionDetails();
        this.form.reset();
      }, 1000);
    });
  }

  ngOnDestroy() {
    this.transactionDetailsSub.unsubscribe();
  }
}
