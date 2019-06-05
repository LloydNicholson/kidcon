import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { AccountingService } from '../../shared/accounting.service';

@Component({
  selector: 'app-account-type-question',
  templateUrl: './account-type-question.component.html',
  styleUrls: ['./account-type-question.component.css']
})
export class AccountTypeQuestionComponent implements OnInit {
  form: FormGroup;
  accountList: any[] = [];
  randomType: string;

  constructor(private accountingService: AccountingService, private formBuilder: FormBuilder) {
  }

  ngOnInit() {
    this.form = this.formBuilder.group({
      type: new FormControl('', [Validators.required])
    });
  }

  onAddNewItem() {

  }

  onFormSubmit() {
    this.form.reset();
  }
}
