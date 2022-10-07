import { Component, OnInit } from '@angular/core';
import {IProduct} from "../../models/Interfaces/IProduct";
import {ApiService} from '../../services/products/api.service'
import {NgbModal} from '@ng-bootstrap/ng-bootstrap'

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  productChoseen:IProduct = {
    code: 0,
    description: '',
    price: 0,
    imgUrl: '',
    forSale: false,
    vat: 0
  }
  datatable:IProduct[] = [];


  constructor(
    private productsService:ApiService,
    public modal:NgbModal
  ) { }

  ngOnInit(): void {
    this.onGetAllProducts()
  }

  onGetAllProducts(){
    this.productsService.getAllProducts().subscribe(response =>{
        this.datatable = response
      })
  }

  onGetProductById(id: number){
    console.log("id = " + id);
    this.productsService.getProduct(id)
      .subscribe(data=>{
        console.log("Products by id" + data.description);
      })
  }
  getDataEdit(select:any){
    this.productChoseen.code = select.code;
    this.productChoseen.description = select.description;
    this.productChoseen.imgUrl = select.imgUrl;
    this.productChoseen.price = select.price;
    this.productChoseen.forSale = select.forSale;
    this.productChoseen.vat = select.vat;

  }

  getDataDelete(select:any){
    this.productChoseen.code = select.code;
    this.productChoseen.description = select.description;
    this.productChoseen.imgUrl = select.imgUrl;
    this.productChoseen.price = select.price;
    this.productChoseen.forSale = select.forSale;
    this.productChoseen.vat = select.vat;
    this.onDeleteProduct(this.productChoseen,this.productChoseen.code)

  }

  onUpdateProduct(dato:IProduct){
    const id = dato.code;
    this.productsService.updateProduct(dato)
      .subscribe(data=>{
        const productIndex = this.datatable.findIndex(x=>x.code === id)
        this.datatable[productIndex] = data;
        this.onGetAllProducts();
      })
  }
  onDeleteProduct(dato:IProduct,id:number){
    this.productsService.deleteProduct(id)
      .subscribe(()=>{
        this.onGetAllProducts();
      })
  }
}
