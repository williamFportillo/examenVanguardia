import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ResumenComponent } from './resumen/resumen.component';
import { CuentasComponent } from './cuentas/cuentas.component';
import { TransaccionesComponent } from './transacciones/transacciones.component';

@NgModule({
  declarations: [
    AppComponent,
    ResumenComponent,
    CuentasComponent,
    TransaccionesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
