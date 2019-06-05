import { Component, OnInit } from '@angular/core';
import { MatButton, MatDialog } from '@angular/material';
import { AccountingService } from '../../shared/accounting.service';
import { thumbsDownStateTrigger, thumbsUpStateTrigger } from '../../shared/my-animations';
import { Classification } from '../../shared/accounting.model';
import { getRandomItem } from '../../shared/functions';
import { DialogComponent } from '../../shared/dialog.component';

@Component({
  selector: 'app-debit-credit-question',
  templateUrl: './debit-credit-question.component.html',
  styleUrls: ['./debit-credit-question.component.css'],
  animations: [
    thumbsUpStateTrigger,
    thumbsDownStateTrigger
  ]
})
export class DebitCreditQuestionComponent implements OnInit {
  classification: { type: string, details: Classification[] };
  accountType: string;
  accountIncreasingOn: string;
  accountName: string;
  sideChosen: string;
  correct: boolean;
  questionCount = 0;
  score = 0;

  constructor(
      private accountingService: AccountingService,
      private dialog: MatDialog) {
  }

  ngOnInit() {
    this.accountingService.randomClassification.subscribe((classification) => {
      this.classification = classification;
      this.accountType = classification.type;
      const chosenAccount = getRandomItem(classification.details);
      this.accountName = chosenAccount.name;
      this.accountIncreasingOn = chosenAccount.increasingSide;
      console.log('old Class', classification);
    });
  }

  onDebitClicked(debitRef: MatButton, creditRef: MatButton) {
    this.sideChosen = 'debit';
    if (this.accountIncreasingOn === 'debit') {
      this.correct = true;
      this.score += 1;
    }
    this.onClickedSide(debitRef, creditRef);
  }

  onCreditClicked(creditRef: MatButton, debitRef: MatButton) {
    this.sideChosen = 'credit';
    if (this.accountIncreasingOn === 'credit') {
      this.correct = true;
      this.score += 1;
    }
    this.onClickedSide(debitRef, creditRef);
  }

  onClickedSide(creditRef: MatButton, debitRef: MatButton) {
    this.questionCount += 1;
    this.accountingService.randomClassification.subscribe(newClassification => {
      creditRef.disabled = true;
      debitRef.disabled = true;
      setTimeout(() => {
        if (this.accountType === newClassification.type) {
          console.log(newClassification);
          this.accountType = 'assets';
          this.accountName = 'Bank';
          this.accountIncreasingOn = 'debit';
          console.log('new Class', newClassification);
        } else {
          this.accountType = newClassification.type;
          const chosenAccount = getRandomItem(newClassification.details);
          this.accountName = chosenAccount.name;
          this.accountIncreasingOn = chosenAccount.increasingSide;
        }
        this.sideChosen = null;
        debitRef.disabled = false;
        creditRef.disabled = false;
      }, 5000);
    });
    if (this.questionCount >= 10) {
      this.openDialog();
    }
  }

  openDialog() {
    const dialogRef = this.dialog.open(DialogComponent, {
      width: '50%',
      data: {
        questionsAnswered: this.questionCount,
        scoreAchieved: this.score
      }
    });

    dialogRef.afterClosed().subscribe(() => {
      this.questionCount = 0;
      this.score = 0;
    });

  }
}
