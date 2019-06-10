import { NgModule } from '@angular/core';
import {
  MatButtonModule,
  MatCheckboxModule,
  MatDialogModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatTableModule,
  MatToolbarModule
} from '@angular/material';

@NgModule({
  imports: [
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule,
    MatTableModule,
    MatSidenavModule,
    MatListModule,
    MatCheckboxModule,
    MatDialogModule,
    MatRippleModule
  ],
  exports: [
    MatToolbarModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    MatSelectModule,
    MatTableModule,
    MatSidenavModule,
    MatListModule,
    MatCheckboxModule,
    MatDialogModule,
    MatRippleModule
  ]
})
export class MaterialModule {

}
