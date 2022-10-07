import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import {IPhrase} from "../../models/Interfaces/IPhrase";
import {ICreatePhraseDto, IDecryptDto} from "../../models/IPhraseDto";

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  apiUrl:string = 'https://localhost:7096/api/Phrase'

  constructor(
    private http:HttpClient
  ) { }

  getAllPhrases(){
    return this.http.get<IPhrase[]>(`${this.apiUrl}`);
  }
  createPhrase(phrase:ICreatePhraseDto){
    return this.http.post<IPhrase>(`${this.apiUrl}`,phrase);
  }

  decryptPhrase(phraseDto:IDecryptDto){
    return this.http.put<IPhrase>(`${this.apiUrl}`,phraseDto);
  }
  deletePhrase(id:number){
    return this.http.delete(`${this.apiUrl}/${id}`);
  }

}
