import { Component, OnInit } from '@angular/core';
import { AccountingService } from '../../shared/accounting.service';
import { ClassificationData, TransactionData } from '../../shared/accounting.model';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-equation',
  templateUrl: './equation.component.html',
  styleUrls: ['./equation.component.css']
})
export class EquationComponent implements OnInit {
  classification: ClassificationData;
  transaction: string;
  assetValue: FormControl = new FormControl('');
  ownersEquityValue: FormControl = new FormControl('');
  liabilitiesValue: FormControl = new FormControl('');
  form: FormGroup;
  transactionDetails: TransactionData;

  constructor(private accountingService: AccountingService, private fb: FormBuilder) {
  }

  ngOnInit() {
    this.form = this.fb.group({
      assetVal: this.assetValue,
      ownersEquityVal: this.ownersEquityValue,
      liabilitiesVal: this.liabilitiesValue
    });
    this.accountingService.randomClassification.subscribe((classification: ClassificationData) => {
      this.classification = classification;
      console.log(classification);
    });

    this.accountingService.randomTransactionDetails.subscribe((transactionDetails: TransactionData) => {
      this.transactionDetails = transactionDetails;
      this.transaction = this.getRandomTransaction();
    });
  }

  getRandomTransaction() {
    return `
    ${ this.transactionDetails.methods[2] } ${ this.classification.chosenAccount.name } with cash
    `;
  }

  // getAccountDetails() {
  //   return this.accountingService.randomTransactionDetails.subscribe((transaction: TransactionData) => {
  //     console.log(transaction);
  //     return {
  //       currentDate: transaction.date,
  //       currentAmount: transaction.transactionAmount,
  //       currentMethod: transaction.methods[1]
  //     };
  //   });
  // }

  onSubmit() {
    console.log(this.form);
  }
}
