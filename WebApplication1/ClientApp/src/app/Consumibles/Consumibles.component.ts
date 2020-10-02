import { Component, Inject, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'Consumibles-app',
  templateUrl: "./Consumibles.component.html",

})
//export class ConsumiblesComponent { }
//class ConsumiblesComponentTest {
//  @Input() OnIndex: Consumibles; 
//}
export class ConsumiblesComponent {
 
  public LstConsumibles: Consumibles[];//string[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Consumibles[]>(baseUrl + 'api/Consumibles/Consumibles').subscribe(result => {
      this.LstConsumibles = result;
    }, error => console.error(error));
  }
  //@Input() OnIndex: Consumibles; 
}
//export class ConsumiblesComponent {
//  public  nombre ="Alexander Alegre"
  interface Consumibles {
  id: number;
    Producto: string;
  //temperatureF: number;
  //summary: string;
}

