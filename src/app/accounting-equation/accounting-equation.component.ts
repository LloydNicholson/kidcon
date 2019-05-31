import { Component, HostBinding, OnInit } from '@angular/core';
import { routeFadeStateTrigger } from '../shared/my-animations';

@Component({
  selector: 'app-accounting-equation',
  templateUrl: './accounting-equation.component.html',
  styleUrls: ['./accounting-equation.component.css'],
  animations: [
    routeFadeStateTrigger,
    // routeSlideStateTrigger
  ]
})
export class AccountingEquationComponent implements OnInit {
  @HostBinding('@routeFadeState') routeFadeAnimation = true;

  // @HostBinding('@routeSlideState') routeSlideAnimation = true;

  constructor() {
  }

  ngOnInit() {
  }

}
