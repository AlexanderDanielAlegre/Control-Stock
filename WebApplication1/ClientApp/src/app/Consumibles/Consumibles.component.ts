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

  //Que tipo de dato voy a utilizar
  public LstConsumibles: Consumibles[];//string[];
  //En este caso particular indico que voy buscar un metodo a traves de un get
  //en este constructor paso las propiedades que se "Heredan" como la baseURL
  //el inject se tiene que referenciar en los imports EJEMPLO = import {  Inject  } from '@angular/core';
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    //http get es la forma que trae los metodos
    //Api/consumibles/index me marca en el controlador que metodo voy a traer siendo Consumiblescontroller y Index() el metodo 
    http.get<Consumibles[]>(baseUrl + 'api/Consumibles/Consumibles').subscribe(result => {
      //expresion lambda que me indica que voy a guardar los valores devueltos desde el controlador en el tipo de dato especificado al prinicpio
      //LstConsumibles: Consumibles[] es decir lista de consumibles
      this.LstConsumibles = result;
      //mensaje de error en la consola 
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

