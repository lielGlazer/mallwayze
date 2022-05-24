import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Store } from '../models/Store';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class DbService {

  constructor(private httpClient:HttpClient) { }
 //מחזיר את כל המשתמשים
  getAllUser(): Observable<User[]>  {
    return this.httpClient.get<User[]>("http://localhost:64724/api/Users/GetAllUser");
  }
  //רישום
  signUp(user:User):Observable<User>{
    return this.httpClient.post<User>("http://localhost:64724/api/Users/Login" , user );
  }
  //התחברות
  signIn(user:User):Observable<User>{
    // const data=new FormData();
    // data.append('user',JSON.stringify(user));
    // console.log(data.get('user'));
    
    return this.httpClient.post<User>("http://localhost:64724/api/Users/Login" , user );
  }
  getAllSore(){
    return this.httpClient.get<Store[]>("http://localhost:53154/api/Stor/GetAllStor");
  }
}
