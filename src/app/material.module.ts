import { NgModule } from '@angular/core';
import { MatButtonModule, MatIconModule, MatInputModule, MatSelectModule, MatTableModule, MatToolbarModule } from '@angular/material';

@NgModule({
  imports: [
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule,
    MatTableModule
  ],
  exports: [
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule,
    MatTableModule
  ]
})
export class MaterialModule {

}
