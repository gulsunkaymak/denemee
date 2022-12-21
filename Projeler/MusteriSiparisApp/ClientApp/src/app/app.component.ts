import { Component, EventEmitter, Output } from '@angular/core';
import { Model, Order } from './Model';
import { ProductService } from './product.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MusteriSiparisApp';
  model=new Model();
  @Output() somename = new EventEmitter();



  constructor(private productService:ProductService) {

  }


   getOrder(){
     return this.model.orders;
   }

}
