import {IProduct} from "./Interfaces/IProduct";

export interface ICreateProductDto extends Omit<IProduct, 'code'>{}
export interface IUpdateProductDto extends Omit<IProduct, 'code'>{}
