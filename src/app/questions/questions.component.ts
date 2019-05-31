import { Component, HostBinding, OnInit } from '@angular/core';
import { routeFadeStateTrigger } from '../shared/my-animations';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css'],
  animations: [
    routeFadeStateTrigger,
    // routeSlideStateTrigger
  ]
})
export class QuestionsComponent implements OnInit {
  @HostBinding('@routeFadeState') routeFadeAnimation = true;

  // @HostBinding('@routeSlideState') routeSlideAnimation = true;

  constructor() {
  }

  ngOnInit() {
  }

}
