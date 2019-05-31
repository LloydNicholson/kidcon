import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-answer',
  templateUrl: './answer.component.html',
  styleUrls: ['./answer.component.css']
})
export class AnswerComponent implements OnInit {
  form: FormGroup;

  constructor(private fb: FormBuilder) {
  }

  ngOnInit() {
    this.form = this.fb.group({
      answer: new FormControl(0, [Validators.required]),
    });
  }

  onSubmit() {
    console.log(this.form);
  }
}
