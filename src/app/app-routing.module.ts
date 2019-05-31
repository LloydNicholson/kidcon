import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const appRoutes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', loadChildren: () => import('./home/home.module').then(mod => mod.HomeModule) },
  { path: 'questions', loadChildren: () => import('./questions/questions.module').then(mod => mod.QuestionsModule) },
  {
    path: 'accounting-equation',
    loadChildren: () => import('./accounting-equation/accounting-equation.module').then(mod => mod.AccountingEquationModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
