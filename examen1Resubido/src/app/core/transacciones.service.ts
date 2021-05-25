import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Transaction } from '../shared/models/Transaction';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class TransaccionesService {

  baseUrl: string = "https://localhost:44343";
  constructor(private httpClient : HttpClient) { }

  getTransactions(): Observable <Transaction[]>{
    return this.httpClient.get<Transaction[]>(`${this.baseUrl}/Api/Transactions`);
  }
}
