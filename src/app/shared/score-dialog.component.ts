import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-dialog',
  template: `
      <div
          style="text-align: center"
          fxLayout="column"
          fxLayoutAlign="center center">
          <h1 mat-dialog-title *ngIf="data.scoreAchieved >= 10">Full marks! Wow you're a natural!</h1>
          <h1 mat-dialog-title *ngIf="data.scoreAchieved >= 8 && data.scoreAchieved < 10">Excellent!</h1>
          <h1 mat-dialog-title *ngIf="data.scoreAchieved >= 5 && data.scoreAchieved < 8">A good result!</h1>
          <h1 mat-dialog-title *ngIf="data.scoreAchieved >= 0 && data.scoreAchieved < 5">Improvement is needed! Keep working at it!</h1>
          <div mat-dialog-content>
              <h2>You scored {{ data.scoreAchieved }}/{{ data.questionsAnswered }}</h2>
          </div>
          <div mat-dialog-actions>
              <button mat-button color="primary" mat-dialog-close>Done</button>
          </div>
      </div>
  `,
  styles: []
})
export class ScoreDialogComponent {
  constructor(@Inject(MAT_DIALOG_DATA) public data: { questionsAnswered: number, scoreAchieved: number }) {
  }
}

