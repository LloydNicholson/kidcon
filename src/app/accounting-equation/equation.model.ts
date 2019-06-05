export interface Equation {
  name: string;
  accountType: string;
  next: false;
  skip?: false;
}

export interface RandomAccountData {
  name: string;
  type: string;
  increasingSide: 'debit' | 'credit';
}
