import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Store } from '../models/Store';

@Injectable({
  providedIn: 'root'
})
export class StoreService {

  constructor(private http: HttpClient) { }

//todo: Store.ts in model

  GetAllStor(): Observable<Store[]>  {
    return this.http.get<Store[]>("http://localhost:64724/api/Stor/GetAllStor");
  }
    
  
}
