import {IPhrase} from "./Interfaces/IPhrase";

export interface ICreatePhraseDto extends Omit<IPhrase, 'code'>{}
export interface IDecryptDto extends Omit<IPhrase, 'phrase' | 'key'>{}
