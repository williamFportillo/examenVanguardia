import { Component, OnInit } from '@angular/core';
import { CuentasService } from '../core/cuentas.service';

@Component({
  selector: 'app-cuentas',
  templateUrl: './cuentas.component.html',
  styleUrls: ['./cuentas.component.css']
})
export class CuentasComponent implements OnInit {

  accounts : Account[] = [];
  constructor(private accountService : CuentasService) { }

  ngOnInit(): void {
    this.accountService.getAccounts().subscribe((data : Account[]) => {
      this.accounts = data;
    }, error => {
      alert(`${error.status} - ${error.message}`)
    }
    )
  }

}
