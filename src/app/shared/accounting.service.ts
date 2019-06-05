import { Injectable } from '@angular/core';
import { Classifications } from './accounting.model';
import { getRandomItem } from './functions';
import { of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AccountingService {
  private classifications: Classifications = {
    assets: [
      { name: 'Trading stock', alts: ['stock', 'goods', 'products', 'trading stock'], increasingSide: 'debit' },
      { name: 'Vehicles', alts: ['motor vehicle', 'motorbike', 'bicycle', 'vehicle'], increasingSide: 'debit' },
      { name: 'Equipment', alts: ['computers', 'computer', 'printers', 'fax machines'], increasingSide: 'debit' },
      { name: 'Machinery', alts: ['mechanical drill', 'large jackhammer'], increasingSide: 'debit' },
      { name: 'Land and buildings', alts: ['property', 'new property', 'storage facility'], increasingSide: 'debit' }
    ],
    drawings: [
      { name: 'Drawings', alts: ['drawings', 'money'], increasingSide: 'debit' }
    ],
    expenses: [
      { name: 'Salaries', alts: ['salaries', 'monthly payments to employees'], increasingSide: 'debit' },
      { name: 'Wages', alts: ['wages', 'employee weekly wages'], increasingSide: 'debit' },
      { name: 'Repairs', alts: ['repairs to the motor vehicle'], increasingSide: 'debit' },
      { name: 'Advertising', alts: ['advertising', 'advertisement'], increasingSide: 'debit' },
      { name: 'Telephone', alts: ['telephone account', 'cellphone bill'], increasingSide: 'debit' },
      { name: 'Stationery', alts: ['stationery', 'pencils and pens', 'paper'], increasingSide: 'debit' },
      { name: 'Water and electricity', alts: ['rates bill', 'water and electricity'], increasingSide: 'debit' },
      { name: 'Insurance', alts: ['insurance'], increasingSide: 'debit' },
      { name: 'Packing material', alts: ['packing material', 'cardboard for packing'], increasingSide: 'debit' },
      { name: 'Fuel', alts: ['petrol', 'diesel', 'fuel'], increasingSide: 'debit' },
      { name: 'Bank charges', alts: ['bank fees', 'bank charges'], increasingSide: 'debit' },
      { name: 'Consumable goods', alts: ['food', 'groceries', 'flowers'], increasingSide: 'debit' },
      { name: 'Interest on loan', alts: ['interest on long term liability'], increasingSide: 'debit' },
      { name: 'Interest expense', alts: ['paid interest on bank account', 'interest paid'], increasingSide: 'debit' },
      { name: 'Postage', alts: ['postage', 'envelopes'], increasingSide: 'debit' },
      { name: 'Donations expense', alts: ['donations paid', 'goods for the underprivileged'], increasingSide: 'debit' },
      { name: 'Rent expense', alts: ['rent', 'rental'], increasingSide: 'debit' }
    ],
    liabilities: [
      { name: 'Loan', alts: ['a loan', 'a substantial loan'], increasingSide: 'credit' },
      { name: 'Mortgage bond', alts: ['a property loan', 'a bond', 'a mortgage bond'], increasingSide: 'credit' },
      { name: 'Bank overdraft', alts: ['a negative bank balance', 'money owing on our bank account'], increasingSide: 'credit' },
      { name: 'Creditors Control', alts: ['money owed to', 'creditor', 'paid on credit'], increasingSide: 'credit' },
    ],
    incomes: [
      {
        name: 'Current income',
        alts: ['money for services rendered', 'money for a service'],
        increasingSide: 'credit'
      },
      { name: 'Rent income', alts: ['rent', 'rental'], increasingSide: 'credit' },
      { name: 'Donations income', alts: ['donations received'], increasingSide: 'credit' },
      { name: 'Commission', alts: ['commission', 'a percentage of sale'], increasingSide: 'credit' },
      { name: 'Sales', alts: ['sales'], increasingSide: 'credit' },
      { name: 'Interest income', alts: ['interest received'], increasingSide: 'credit' },
    ],
    capital: [
      { name: 'Capital', alts: ['owner\'s contribution', 'capital'], increasingSide: 'credit' }
    ]
  };

  get randomClassification() {
    const classificationsArray = [];
    Object.entries(this.classifications).forEach((entry) => {
      classificationsArray.push({
        type: entry[0],
        details: entry[1]
      });
    });
    return of(getRandomItem(classificationsArray));
  }
}

