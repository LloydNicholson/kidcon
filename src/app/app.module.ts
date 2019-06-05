import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { SharedModule } from './shared/shared.module';
import { HomeModule } from './home/home.module';
import { QuestionsModule } from './questions/questions.module';
import { AccountingEquationModule } from './accounting-equation/accounting-equation.module';
import { HeaderComponent } from './shared/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SidenavListComponent } from './shared/sidenav-list/sidenav-list.component';
import { DialogComponent } from './shared/dialog.component';

@NgModule({
  entryComponents: [DialogComponent],
  declarations: [
    AppComponent,
    HeaderComponent,
    SidenavListComponent,
    DialogComponent
  ],
  imports: [
    BrowserModule,
    HomeModule,
    QuestionsModule,
    AccountingEquationModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
