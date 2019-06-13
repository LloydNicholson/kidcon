import { Injectable } from '@angular/core';
import { Classifications } from './accounting.model';
import { getRandomDate, getRandomisedNum, getRandomItem } from './functions';
import { of } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountingService {
  private smallAmount = getRandomisedNum(500, 25000);
  private mediumAmount = getRandomisedNum(25000, 100000);
  private largeAmount = getRandomisedNum(100000, 1000000);
  private date: number = getRandomDate().currentDate;
  private ownerName: string;
  private businessName: string;
  private methods: string[] = [
    'Bought',
    'Paid for',
    'Purchased',
    'Received',
    'Acquired',
    'Borrowed',
    'Paid back',
    'Settled',
  ];
  private documentType: string;
  private types = ['cash', 'credit'];
  private classifications: Classifications = {
    assets: [
      {
        name: 'Trading stock',
        alts: ['stock', 'goods', 'products', 'trading stock'],
        increasingSide: 'debit',
        type: 'asset'
      },
      {
        name: 'Vehicles',
        alts: ['motor vehicle', 'motorbike', 'bicycle', 'vehicle'],
        increasingSide: 'debit',
        type: 'asset'
      },
      {
        name: 'Equipment',
        alts: ['computers', 'computer', 'printers', 'fax machines'],
        increasingSide: 'debit',
        type: 'asset'
      },
      { name: 'Machinery', alts: ['mechanical drill', 'large jackhammer'], increasingSide: 'debit', type: 'asset' },
      {
        name: 'Land and buildings',
        alts: ['property', 'new property', 'storage facility'],
        increasingSide: 'debit',
        type: 'asset'
      },
      { name: 'Petty Cash', alts: ['cash on hand', 'cash box in office'], increasingSide: 'debit', type: 'asset' },
      { name: 'Cash float', alts: ['change in the till'], increasingSide: 'debit', type: 'asset' },
      { name: 'Furniture', alts: ['bought a couch', 'purchased a table'], increasingSide: 'debit', type: 'asset' },
      { name: 'Bank', alts: ['cash in the bank account', 'cash used'], increasingSide: 'debit', type: 'asset' },
    ],
    drawings: [
      { name: 'Drawings', alts: ['drawings', 'money'], increasingSide: 'debit', type: 'drawings' }
    ],
    expenses: [
      {
        name: 'Salaries',
        alts: ['salaries', 'monthly payments to employees'],
        increasingSide: 'debit',
        type: 'expense'
      },
      { name: 'Wages', alts: ['wages', 'employee weekly wages'], increasingSide: 'debit', type: 'expense' },
      { name: 'Repairs', alts: ['repairs to the delivery vehicle'], increasingSide: 'debit', type: 'expense' },
      { name: 'Advertising', alts: ['advertising', 'advertisement'], increasingSide: 'debit', type: 'expense' },
      { name: 'Telephone', alts: ['telephone account', 'cellphone bill'], increasingSide: 'debit', type: 'expense' },
      {
        name: 'Stationery',
        alts: ['stationery', 'pencils and pens', 'paper'],
        increasingSide: 'debit',
        type: 'expense'
      },
      {
        name: 'Water and electricity',
        alts: ['rates bill', 'water and electricity'],
        increasingSide: 'debit',
        type: 'expense'
      },
      { name: 'Insurance', alts: ['insurance'], increasingSide: 'debit', type: 'expense' },
      {
        name: 'Packing material',
        alts: ['packing material', 'cardboard for packing'],
        increasingSide: 'debit',
        type: 'expense'
      },
      { name: 'Fuel', alts: ['petrol', 'diesel', 'fuel'], increasingSide: 'debit', type: 'expense' },
      { name: 'Bank charges', alts: ['bank fees', 'bank charges'], increasingSide: 'debit', type: 'expense' },
      { name: 'Consumable goods', alts: ['food', 'groceries', 'flowers'], increasingSide: 'debit', type: 'expense' },
      { name: 'Interest on loan', alts: ['interest on long term liability'], increasingSide: 'debit', type: 'expense' },
      {
        name: 'Interest expense',
        alts: ['paid interest on bank account', 'interest paid'],
        increasingSide: 'debit',
        type: 'expense'
      },
      { name: 'Postage', alts: ['postage', 'envelopes'], increasingSide: 'debit', type: 'expense' },
      {
        name: 'Donations expense',
        alts: ['donations paid', 'money paid to the underprivileged'],
        increasingSide: 'debit', type: 'expense'
      },
      { name: 'Rent expense', alts: ['rent', 'rental paid'], increasingSide: 'debit', type: 'expense' },
      {
        name: 'Cost of Sales',
        alts: ['cost price', 'goods originally bought for an certain amount'],
        increasingSide: 'debit', type: 'expense'
      },
    ],
    liabilities: [
      { name: 'Loan', alts: ['a loan', 'a substantial loan'], increasingSide: 'credit', type: 'liability' },
      {
        name: 'Mortgage bond',
        alts: ['a property loan', 'a bond', 'a mortgage bond'],
        increasingSide: 'credit',
        type: 'liability'
      },
      {
        name: 'Bank overdraft',
        alts: ['a negative bank balance', 'money owing on our bank account'],
        increasingSide: 'credit', type: 'liability'
      },
      {
        name: 'Creditors Control',
        alts: ['money owed to', 'creditor', 'paid on credit'],
        increasingSide: 'credit',
        type: 'liability'
      },
    ],
    incomes: [
      {
        name: 'Current income',
        alts: ['money for services rendered', 'received money for a service'],
        increasingSide: 'credit', type: 'income'
      },
      { name: 'Rent income', alts: ['rent', 'rental'], increasingSide: 'credit', type: 'income' },
      { name: 'Donations income', alts: ['donations received'], increasingSide: 'credit', type: 'income' },
      { name: 'Commission', alts: ['commission', 'a percentage of sale'], increasingSide: 'credit', type: 'income' },
      { name: 'Sales', alts: ['sales'], increasingSide: 'credit', type: 'income' },
      { name: 'Interest income', alts: ['interest received'], increasingSide: 'credit', type: 'income' },
      {
        name: 'Interest on fixed deposit',
        alts: ['interest on deposit account'],
        increasingSide: 'credit',
        type: 'income'
      },
    ],
    capital: [
      { name: 'Capital', alts: ['owner\'s contribution', 'capital'], increasingSide: 'credit', type: 'capital' }
    ]
  };

  get allClassifications() {
    return of(this.classifications);
  }

  get amount() {
    return {
      small: this.smallAmount,
      medium: this.mediumAmount,
      large: this.largeAmount
    };
  }

  get randomTransactionDetails() {
    return of({
      date: this.date,
      transactionAmount: this.amount,
      ownerName: this.ownerName,
      businessName: this.businessName,
      methods: [...this.methods],
      documentType: this.documentType,
      paymentTypes: [...this.types]
    });
  }

  get paymentMethods() {
    return this.methods.slice(0, 3);
  }

  get receivingMethods() {
    return this.methods.slice(3);
  }

  get randomClassification() {
    return this.allClassifications.pipe(
        map((classifications: Classifications) => {
          const classificationsArray = Object.entries(classifications).map((entry) => {
            return {
              type: entry[0],
              details: entry[1]
            };
          });
          const valuesArray = [];
          classificationsArray.forEach(entry => {
            entry.details.forEach((val) => {
              valuesArray.push(val);
            });
          });
          const chosenAccount = getRandomItem(valuesArray);
          const accountType = chosenAccount.type;
          const accountName = chosenAccount.name;
          const increasingSide = chosenAccount.increasingSide;
          return {
            classificationsArray,
            valuesArray,
            chosenAccount,
            accountType,
            accountName,
            increasingSide
          };
        })
    );
  }
}

