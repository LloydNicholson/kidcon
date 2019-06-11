import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { SharedModule } from './shared/shared.module';
import { HomeModule } from './home/home.module';
import { QuestionsModule } from './questions/questions.module';
import { AccountingEquationModule } from './accounting-equation/accounting-equation.module';
import { HeaderComponent } from './navigation/header/header.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SidenavListComponent } from './navigation/sidenav-list/sidenav-list.component';
import { ScoreDialogComponent } from './shared/score-dialog.component';
import { FooterComponent } from './footer/footer.component';

@NgModule({
  entryComponents: [ScoreDialogComponent],
  declarations: [
    AppComponent,
    HeaderComponent,
    SidenavListComponent,
    ScoreDialogComponent,
    FooterComponent
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
