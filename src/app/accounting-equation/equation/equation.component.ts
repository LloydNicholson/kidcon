import { Component, ElementRef, OnInit } from '@angular/core';
import { getRandomItem } from '../../shared/functions';
import { Classification } from '../../shared/accounting.model';
import { AccountingService } from '../../shared/accounting.service';
import { MatButton } from '@angular/material';

@Component({
  selector: 'app-equation',
  templateUrl: './equation.component.html',
  styles: [
      `
          span {
              margin-left: 5px;
          }
      `
  ]
})
export class EquationComponent implements OnInit {
  sideChosen: string;
  randomAccount: Classification;
  randomAlt: string;
  correct: boolean;
  score: number;

  constructor(private accountingService: AccountingService) {
  }

  ngOnInit() {
    this.randomAccount = this.getRandomAccount();
    this.randomAlt = getRandomItem(this.randomAccount);
  }

  onDebitClicked(debitRef: MatButton, creditRef: MatButton) {
    this.sideChosen = 'debit';
    this.correct = this.randomAccount.increasingSide === 'debit';
    this.onClickedSide(debitRef, creditRef);
  }

  onCreditClicked(creditRef: MatButton, debitRef: MatButton) {
    this.sideChosen = 'credit';
    this.correct = this.randomAccount.increasingSide === 'credit';
    this.onClickedSide(debitRef, creditRef);
  }

  onClickedSide(creditRef: MatButton, debitRef: MatButton) {
    creditRef.disabled = true;
    debitRef.disabled = true;
    setTimeout(() => {
      this.sideChosen = null;
      this.randomAccount = this.getRandomAccount();
      debitRef.disabled = false;
      creditRef.disabled = false;
    }, 2000);
  }

  getRandomAccount(): Classification {
    const classificationTypes = Object.entries(this.accountingService.getClassifications());
    const classificationAccounts = getRandomItem(classificationTypes);
    return classificationAccounts[1][Math.floor(Math.random() * classificationAccounts[1].length)];
  }
}
