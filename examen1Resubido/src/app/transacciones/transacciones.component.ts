import { Component, OnInit } from '@angular/core';
import { TransaccionesService } from '../core/transacciones.service';
import { Transaction } from '../shared/models/Transaction';

@Component({
  selector: 'app-transacciones',
  templateUrl: './transacciones.component.html',
  styleUrls: ['./transacciones.component.css']
})
export class TransaccionesComponent implements OnInit {

  transactions: Transaction[] = [];
  constructor(private transactionService : TransaccionesService) { }

  ngOnInit(): void {
    this.transactionService.getTransactions().subscribe( (data : Transaction[]) => {
      this.transactions = data;
    }, error => {
      alert(`${error.status} - ${error.message}`)
    })
  }

}
