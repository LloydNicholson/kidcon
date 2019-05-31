import { animate, style, transition, trigger } from '@angular/animations';

export const routeFadeStateTrigger = trigger('routeFadeState', [
  transition(':enter', [
    style({
      opacity: 0
    }),
    animate(500)
  ]),
  transition(':leave', animate(500, style({
    opacity: 0
  })))
]);

export const routeSlideStateTrigger = trigger('routeSlideState', [
  transition(':enter', [
    style({
      opacity: 1,
      transform: 'translateY(-100%)'
    }),
    animate(800)
  ]),
  transition(':leave', animate(800, style({
    opacity: 0,
    transform: 'translateY(100%)'
  })))
]);
