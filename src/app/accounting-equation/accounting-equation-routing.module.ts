import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountingEquationComponent } from './accounting-equation.component';

const routes: Routes = [
  { path: '', component: AccountingEquationComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccountingEquationRoutingModule {
}
