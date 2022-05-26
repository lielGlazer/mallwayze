import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from '../models/Category';
import { Store } from '../models/Store';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class CatgoryStorService {
 
  constructor(private httpClient:HttpClient) { }

  //מחזיר רשימה של כל החניות 
  getAllSore(): Observable<Store[]>
  {
    return this.httpClient.get<Store[]>("http://localhost:53154/api/Stor/GetAllStor");
  }
   //מחזיר רשימה של  כל הקטגוריות 
  getAllCaregory(): Observable<Category[]>  {
    return this.httpClient.get<Category[]>("http://localhost:64724/api/Category/GetCaterory");
  }
  //מחזיר רשימה של חנויות לפי קטגוריות
  gelAllStorOfCategory(nameCategory:string): Observable<Store[]>  {
    return this.httpClient.get<Store[]>("http://localhost:53154/api/Stor/GetStoresByCategory/{nameCategory}");
  }
  //מחזיר רשימת קטגוריות לפי חנות
  gelAllCategoryOfStor(nameStor:string): Observable<Category[]>  {
    return this.httpClient.get<Category[]>("http://localhost:53154/api/Stor/GetAllCategorysForStor/{nameStor}");
  }
 
}
