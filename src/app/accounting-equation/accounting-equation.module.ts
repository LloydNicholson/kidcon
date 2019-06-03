import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { AccountingEquationRoutingModule } from './accounting-equation-routing.module';

import { AccountingEquationComponent } from './accounting-equation.component';
import { EquationComponent } from './equation/equation.component';

@NgModule({
  declarations: [AccountingEquationComponent, EquationComponent],
  imports: [
    SharedModule,
    AccountingEquationRoutingModule
  ]
})
export class AccountingEquationModule {
}
