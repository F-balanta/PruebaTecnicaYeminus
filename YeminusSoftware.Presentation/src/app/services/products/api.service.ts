import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {IProduct} from "../../models/Interfaces/IProduct";
import {ICreateProductDto} from "../../models/ProductDTO";


@Injectable({
  providedIn: 'root'
})
export class ApiService {
  apiUrl: string = 'https://localhost:7096/api/Product';

  constructor(
    private http:HttpClient
  ) { }


  getAllProducts(){
    return this.http.get<IProduct[]>(`${this.apiUrl}`);
  }
  getProduct(id:number){
    return this.http.get<IProduct>(`${this.apiUrl}/${id}`)
  }
  createProduct(dtoCreate: ICreateProductDto){
    return this.http.post<IProduct>(`${this.apiUrl}`,dtoCreate);
  }
  updateProduct(product:IProduct){
    return this.http.put<IProduct>(`${this.apiUrl}/`,product);
  }
  deleteProduct(id:number) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

}
