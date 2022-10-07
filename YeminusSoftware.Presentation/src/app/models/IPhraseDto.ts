import {IPhrase} from "./Interfaces/IPhrase";

export interface ICreatePhraseDto extends Omit<IPhrase, 'code'>{}
