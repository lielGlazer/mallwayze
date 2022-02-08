import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class DbService {

  constructor(private httpClient:HttpClient) { }
 
  getAllUser(): Observable<User[]>  {
    return this.httpClient.get<User[]>("http://localhost:62684/api/Users/GetAllUser");
  }
  signUp(user:User):Observable<User>{

    return this.httpClient.post<User>("http://localhost:62684/api/Users/Register" , user );

  }
  singIn(user:User):Observable<User>{

    return this.httpClient.post<User>("http://localhost:62684/api/Users/Login" , user );

  }
}
