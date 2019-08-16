import { AccountItemModel } from "./insert-account.model";

export interface GetAllAccountModel {
  initialBalance: number;
  accounts: AccountItemModel[];
}
