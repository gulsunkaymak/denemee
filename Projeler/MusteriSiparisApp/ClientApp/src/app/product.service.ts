import { Injectable } from '@angular/core';
import { Model } from './Model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  model =new Model();
  constructor() { }

  // getStatu(){
  //   return this.model.isActive;
  // }
  // getOrder(){
  //   return this.model.orders;
  // }
}
