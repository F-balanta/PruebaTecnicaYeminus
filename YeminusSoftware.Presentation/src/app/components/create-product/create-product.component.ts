import {Component} from '@angular/core';
import {ICreateProductDto} from "../../models/ProductDTO";
import {ApiService} from '../../services/products/api.service';
import {IProduct} from "../../models/Interfaces/IProduct";

@Component({
  selector: 'app-create-product',
  templateUrl: './create-product.component.html',
  styleUrls: ['./create-product.component.scss']
})
export class CreateProductComponent {

  products: ICreateProductDto[] = [];

  newProduct: IProduct = {
    code: 0,
    description: '',
    price: 0,
    imgUrl: '',
    forSale: false,
    vat: 0
  }

  constructor(
    private productsService: ApiService
  ) {
  }


  getDataForm(select: any) {
    this.newProduct.description = select.description;
    this.newProduct.price = select.price;
    this.newProduct.imgUrl = select.imgUrl;
    this.newProduct.forSale = select.forSale;
    this.newProduct.vat = select.vat;
    this.onCreateProduct(this.newProduct);
  }

  onCreateProduct(product: ICreateProductDto) {
    this.productsService.createProduct(product)
      .subscribe(response => {
        console.log(response);
      })
  }
}




