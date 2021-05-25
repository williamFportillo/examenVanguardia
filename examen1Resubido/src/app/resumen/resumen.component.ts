import { Component, Input, OnInit } from '@angular/core';
import { ResumenService } from '../core/resumen.service';
import { Resumen } from '../shared/models/Resumen';

@Component({
  selector: 'app-resumen',
  templateUrl: './resumen.component.html',
  styleUrls: ['./resumen.component.css']
})
export class ResumenComponent implements OnInit {

  @Input() accountId?: number; 
  resumen? : Resumen ;
  constructor(private resumenService : ResumenService) { }

  ngOnInit(): void {
//    this.resumenService.getResumen(accountId).subscribe( (data : Resumen) => {
 //     this.resumen = data;
  //  }, error => {
  ///    alert(`${error.status} - ${error.message}`)
 //   })
  }

}
