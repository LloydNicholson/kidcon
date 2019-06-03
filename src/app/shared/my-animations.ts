import { animate, group, query, style, transition, trigger } from '@angular/animations';

export const routeFadeStateTrigger = trigger('routeFadeState', [
  transition('* => *', [
      group([
        query(':enter', [
          style({
            opacity: 0
          }),
          animate('500ms ease-out')
        ], { optional: true }),
        query(':leave', animate('500ms ease-in', style({
          opacity: 0,
          transform: 'translateY(200%)'
        })), { optional: true })
      ])
  ]),
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
