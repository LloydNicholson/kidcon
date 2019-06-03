import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  animations: [
    // routeSlideStateTrigger
  ]
})
export class HomeComponent implements OnInit {
  // @HostBinding('@routeSlideState') routeSlideAnimation = true;

  constructor() {
  }

  ngOnInit() {
  }

}
