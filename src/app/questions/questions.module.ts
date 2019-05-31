import { NgModule } from '@angular/core';

import { QuestionsRoutingModule } from './questions-routing.module';
import { QuestionsComponent } from './questions.component';
import { QuestionComponent } from './question/question.component';
import { AnswerComponent } from './answer/answer.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [
    QuestionsComponent,
    QuestionComponent,
    AnswerComponent
  ],
  imports: [
    SharedModule,
    QuestionsRoutingModule
  ]
})
export class QuestionsModule {
}
