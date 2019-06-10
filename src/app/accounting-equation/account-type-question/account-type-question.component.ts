import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AccountingService } from '../../shared/accounting.service';
import { MatButton } from '@angular/material';
import { thumbsDownStateTrigger, thumbsUpStateTrigger } from '../../shared/my-animations';
import { ClassificationData } from '../../shared/accounting.model';

@Component({
  selector: 'app-account-type-question',
  templateUrl: './account-type-question.component.html',
  styleUrls: ['./account-type-question.component.css'],
  animations: [
    thumbsDownStateTrigger,
    thumbsUpStateTrigger
  ]
})
export class AccountTypeQuestionComponent implements OnInit {
  @ViewChild('button', { static: false }) button: MatButton;
  form: FormGroup;
  selectedClass = new FormControl('', [Validators.required]);
  submittedForm = false;
  accountName: string;
  accountType: string;
  status: 'correct' | 'incorrect';

  constructor(private accountingService: AccountingService, private formBuilder: FormBuilder) {
  }

  ngOnInit() {
    this.form = this.formBuilder.group({
      type: this.selectedClass
    });

    this.accountingService.randomClassification.subscribe((classification: ClassificationData) => {
      this.accountType = classification.accountType;
      this.accountName = classification.accountName;
    });
  }

  onFormSubmit() {
    this.submittedForm = true;
    if (this.accountType === this.selectedClass.value) {
      this.accountingService.randomClassification.subscribe((classification: ClassificationData) => {
        this.status = 'correct';
        this.button.disabled = true;
        setTimeout(() => {
          this.accountType = classification.accountType;
          this.accountName = classification.accountName;
          this.status = null;
          this.form.reset();
        }, 2000);
      });
    } else {
      this.status = 'incorrect';
      setTimeout(() => {
        this.status = null;
      }, 2000);
    }
  }
}
