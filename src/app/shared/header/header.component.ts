import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
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
  @Output() toggledNav = new EventEmitter<boolean>();

  onToggle() {
    this.toggledNav.emit(true);
  }
}
