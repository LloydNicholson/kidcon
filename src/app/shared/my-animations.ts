import { animate, animation, group, keyframes, query, style, transition, trigger, useAnimation } from '@angular/animations';

export const routeFadeStateTrigger = trigger('routeFadeState', [
  transition('* => *', [
    group([
      query(':enter', [
        style({
          opacity: 0,
          transform: 'translateY(-100%)'
        }),
        animate(500)
      ], { optional: true }),
      query(':leave', animate(500, style({
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

export const bumpInAnimation = animation([
  style({
    transform: 'translateX({{ xStart }}) translateY({{ yStart }})',
    opacity: '{{ opacityStart }}'
  }),
  animate('{{ time }}', keyframes([
    style({
      transform: 'translateX({{ xMid }}) translateY({{ yMid }})',
      opacity: '{{ opacityMid }}',
      offset: 0.4
    }),
    style({
      transform: 'translateX({{ xEnd }}) translateY({{ yEnd }})',
      opacity: '{{ opacityEnd }}',
      offset: 1
    })
  ]))
], {
  params: {
    opacityStart: 0,
    xStart: '0',
    yStart: '100%',
    time: '500ms',
    opacityMid: 0.6,
    xMid: '0',
    yMid: '-15%',
    opacityEnd: 1,
    xEnd: '0',
    yEnd: '0'
  }
});

export const thumbsUpStateTrigger = trigger('thumbsUpState', [
  transition(':enter', useAnimation(bumpInAnimation, {
    params: {
      xStart: '0',
      yStart: '100%',
      yMid: '-30%',
      time: '500ms ease-out'
    }
  }))
]);

export const thumbsDownStateTrigger = trigger('thumbsDownState', [
  transition(':enter', useAnimation(bumpInAnimation, {
    params: {
      xStart: '0',
      yStart: '-100%',
      yMid: '30%',
      time: '500ms ease-out'
    }
  }))
]);
