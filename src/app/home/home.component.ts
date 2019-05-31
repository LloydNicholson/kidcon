import { Component, HostBinding, OnInit } from '@angular/core';
import { routeFadeStateTrigger } from '../shared/my-animations';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  animations: [
    routeFadeStateTrigger,
    // routeSlideStateTrigger
  ]
})
export class HomeComponent implements OnInit {
  @HostBinding('@routeFadeState') routeFadeAnimation = true;

  // @HostBinding('@routeSlideState') routeSlideAnimation = true;

  constructor() {
  }

  ngOnInit() {
  }

}
