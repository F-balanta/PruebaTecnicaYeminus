import {CreateProductComponent} from './components/create-product/create-product.component'
import {ProductsComponent} from './components/products/products.component'
import {HomeComponent} from './components/home/home.component'
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {EncryptionComponent} from "./components/encryption/encryption.component";
import {CreatePhraseComponent} from "./components/create-phrase/create-phrase.component";

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'createProduct', component: CreateProductComponent},
  {path: 'showProduts', component: ProductsComponent},
  {path: 'showPhrases', component: EncryptionComponent},
  {path: 'createPhrases', component: CreatePhraseComponent}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
