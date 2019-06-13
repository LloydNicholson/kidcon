import { Component, OnInit } from '@angular/core';
import { AccountingService } from '../shared/accounting.service';
import { Classifications } from '../shared/accounting.model';

@Component({
  selector: 'app-accounting-equation',
  templateUrl: './accounting-equation.component.html',
  styleUrls: ['./accounting-equation.component.css'],
  animations: []
})
export class AccountingEquationComponent implements OnInit {
  classifications: Classifications;

  constructor(private accountingService: AccountingService) {
  }

  ngOnInit() {
    this.accountingService.allClassifications.subscribe((classifications: Classifications) => {
      this.classifications = classifications;
    });
  }

}
