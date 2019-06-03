export interface Classification {
  name: string;
  alts: string[];
  increasingSide: 'debit' | 'credit';
}

export interface Classifications {
  assets: Classification[];
  liabilities: Classification[];
  drawings: Classification[];
  capital: Classification[];
  expenses: Classification[];
  incomes: Classification[];
}
