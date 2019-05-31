import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  template: `
      <mat-toolbar color="primary">
          <mat-toolbar-row>
              <span><a routerLink="/"><h1>Kid Connect Accounting</h1></a></span>
              <span><button mat-button routerLink="/home">Home</button></span>
              <span><button mat-button routerLink="/questions">Questions</button></span>
              <span><button mat-button routerLink="/accounting-equation">Accounting Equation</button></span>
          </mat-toolbar-row>
      </mat-toolbar>
  `,
  styles:
      [`
           a, h1 {
               text-decoration: none;
               margin-right: 10px;
               color: white;
           }

           button {
               margin: 5px;
           }
       `]
})
export class HeaderComponent {

}
