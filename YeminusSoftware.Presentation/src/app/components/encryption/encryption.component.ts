import { Component, OnInit } from '@angular/core';
import {ApiService} from '../../services/encryption/api.service'
import {IPhrase} from '../../models/Interfaces/IPhrase'
@Component({
  selector: 'app-encryption',
  templateUrl: './encryption.component.html',
  styleUrls: ['./encryption.component.scss']
})
export class EncryptionComponent implements OnInit {

  datatable:IPhrase[] = []
  gettingPhrase:IPhrase = {
    code : 0  ,
    phrase: '',
    key: 0
  }

  constructor(
    private phraseService:ApiService
  ) { }

  ngOnInit(): void {
    this.onGetAllPhrases();
  }

  onGetAllPhrases(){
    this.phraseService.getAllPhrases().subscribe(data=>{
      this.datatable = data;
    })
  }


  getDataEdit(select:any){

  }

  onUpdatePhrase(){

  }


  getDataDelete(select:any){
    this.gettingPhrase.code = select.code;
    this.gettingPhrase.phrase = select.phrase;
    this.gettingPhrase.key = select.key;
    this.onDeletePhrase(this.gettingPhrase,this.gettingPhrase.code)
  }

  onDeletePhrase(data:IPhrase, id:number){
    this.phraseService.deletePhrase(id)
      .subscribe(()=>{
        this.onGetAllPhrases();
      })
  }
}

