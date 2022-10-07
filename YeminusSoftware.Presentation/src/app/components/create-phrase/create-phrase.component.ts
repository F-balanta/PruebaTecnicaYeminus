import { Component, OnInit } from '@angular/core';
import {IPhrase} from "../../models/Interfaces/IPhrase";
import {ApiService} from '../../services/encryption/api.service'
import {ICreatePhraseDto} from "../../models/IPhraseDto";

@Component({
  selector: 'app-create-phrase',
  templateUrl: './create-phrase.component.html',
  styleUrls: ['./create-phrase.component.scss']
})
export class CreatePhraseComponent implements OnInit {
  newPhrase:ICreatePhraseDto ={
    phrase : '',
    key: 0
  }
  constructor(
    private phraseService: ApiService
  ) { }

  ngOnInit(): void {
  }

  getDataForm(select:any){
    this.newPhrase.phrase = select.phrase;
    this.newPhrase.key = select.key;
    this.onCreatePhrase(this.newPhrase)
  }

  onCreatePhrase(newPhrase: ICreatePhraseDto){
    this.phraseService.createPhrase(newPhrase)
      .subscribe(data=>{
        console.log(data);
      });
  }
}
