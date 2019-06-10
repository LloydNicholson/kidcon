export interface Classification {
  name: string;
  alts: string[];
  increasingSide: 'debit' | 'credit';
  type: 'asset' | 'expense' | 'drawings' | 'capital' | 'liability' | 'income';
}

export interface Classifications {
  assets: Classification[];
  liabilities: Classification[];
  drawings: Classification[];
  capital: Classification[];
  expenses: Classification[];
  incomes: Classification[];
}

export interface ClassificationData {
  classificationsArray: { type: string; details: any[] }[];
  valuesArray: Classification[];
  chosenAccount: Classification;
  accountType: string;
  accountName: string;
  increasingSide: string;

}
