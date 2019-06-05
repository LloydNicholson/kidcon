import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { AccountingEquationRoutingModule } from './accounting-equation-routing.module';

import { AccountingEquationComponent } from './accounting-equation.component';
import { EquationComponent } from './equation/equation.component';
import { AccountTypeQuestionComponent } from './account-type-question/account-type-question.component';
import { DebitCreditQuestionComponent } from './debit-credit-question/debit-credit-question.component';

@NgModule({
  declarations: [AccountingEquationComponent, EquationComponent, AccountTypeQuestionComponent, DebitCreditQuestionComponent],
  imports: [
    SharedModule,
    AccountingEquationRoutingModule
  ]
})
export class AccountingEquationModule {
}
