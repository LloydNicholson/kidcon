import { NgModule } from '@angular/core';
import { MatButtonModule, MatIconModule, MatInputModule, MatSelectModule, MatToolbarModule } from '@angular/material';

@NgModule({
  imports: [
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule
  ],
  exports: [
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule
  ]
})
export class MaterialModule {

}
