import { Component } from '@angular/core';
import { routeFadeStateTrigger } from './shared/my-animations';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations: [routeFadeStateTrigger]
})
export class AppComponent {
  title = 'ng-kidcon-restart';

  getAnimationData(outlet: RouterOutlet) {
    const routeData = outlet.activatedRouteData.animation;
    if (!routeData) {
      return 'homePage';
    } else {
      return routeData.page;
    }
  }
}
