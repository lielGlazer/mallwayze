import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../models/Category';
import { Store } from '../models/Store';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private httpClient:HttpClient) { }
  getAllCaregory(): Observable<Category[]>  {
    return this.httpClient.get<Category[]>("http://localhost:64724/api/Category/GetCaterory");
  }
  gelAllStorOfCategory(_nameCategory=""): Observable<Store[]>  {
    return this.httpClient.get<Store[]>("http://localhost:53154/api/Stor/GetStoresByCategory/{nameCategory}");
  }
}
