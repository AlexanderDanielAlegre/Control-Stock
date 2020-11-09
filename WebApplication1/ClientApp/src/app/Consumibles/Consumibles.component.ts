import { Component, Inject, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { HttpClientModule  }from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Component({
  selector: 'Consumibles-app',
  templateUrl: "./Consumibles.component.html",

})
//export class ConsumiblesComponent { }
//class ConsumiblesComponentTest {
//  @Input() OnIndex: Consumibles; 
//}
export class ConsumiblesComponent {


  //

  //Que tipo de dato voy a utilizar
  public LstConsumibles: Consumibles[];//string[];
  private urlApi = 'https://localhost:52667/api/Consumibles/Consumibles';
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { }

  getall(): Observable<Consumibles[]> {
    return this.http.get< Consumibles[]>(/*baseUrl + */this.urlApi );
  }
  ngOnInit() {
    //console.log(this.getall());
    this.getall().subscribe(data => console.log(data));
  }
    //http.get<Consumibles[]>(baseUrl + 'api/Consumibles/Consumibles').subscribe(result => {
    //  this.LstConsumibles = result;

    //}, error => console.error(error));
 // }
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

