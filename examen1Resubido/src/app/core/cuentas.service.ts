import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Transaction } from '../shared/models/Transaction';
@Injectable({
  providedIn: 'root'
})
export class CuentasService {

  baseUrl: string = "https://localhost:44343";
  constructor(private httpClient : HttpClient) { }

  getAccounts(): Observable<Account[]>{
    return this.httpClient.get<Account[]>(`${this.baseUrl}/Api/Accounts`);
  }
}
