import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class ResumenService {

  baseUrl: string = "https://localhost:44343";
  constructor(private httpClient : HttpClient) { }

  getResumen(accountId : number){
    return this.httpClient.get<Account[]>(`${this.baseUrl}/Api/Transactions/${accountId}`);
  }
}
