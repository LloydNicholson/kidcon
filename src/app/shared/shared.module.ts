import { NgModule } from '@angular/core';
import { MaterialModule } from '../material.module';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MaterialModule,
    FlexLayoutModule
  ],
  exports: [
    CommonModule,
    ReactiveFormsModule,
    MaterialModule,
    FlexLayoutModule
  ]
})
export class SharedModule {

}
