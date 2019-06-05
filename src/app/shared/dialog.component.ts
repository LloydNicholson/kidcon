import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material';

@Component({
  selector: 'app-dialog',
  template: `
      <div
          fxLayout="column"
          fxLayoutAlign="center center">
          <h1 mat-dialog-title>Well done</h1>
          <div mat-dialog-content>
              <h2>You scored {{ data.scoreAchieved }} / {{ data.questionsAnswered }}</h2>
          </div>
          <div mat-dialog-actions>
              <button mat-button mat-dialog-close>Done</button>
          </div>
      </div>
  `,
  styles: []
})
export class DialogComponent {
  constructor(@Inject(MAT_DIALOG_DATA) public data: { questionsAnswered: number, scoreAchieved: number }) {
  }
}

