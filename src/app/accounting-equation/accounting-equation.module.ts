import { NgModule } from '@angular/core';

import { AccountingEquationRoutingModule } from './accounting-equation-routing.module';
import { AccountingEquationComponent } from './accounting-equation.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [AccountingEquationComponent],
  imports: [
    SharedModule,
    AccountingEquationRoutingModule
  ]
})
export class AccountingEquationModule {
}
