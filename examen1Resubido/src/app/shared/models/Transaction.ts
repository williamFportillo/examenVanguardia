export interface Transaction{
    accountId : number,
    account: Account,
    amount: number,
    description: string,
    transactionDate: Date;
}