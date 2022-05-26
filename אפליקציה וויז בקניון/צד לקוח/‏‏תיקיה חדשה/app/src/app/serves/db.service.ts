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
  //מחזיר לכל משתמש את הרשימה של החניות האהובות עליו עליו 
  getListStorOfUser(user:User): Observable<Store[]> {
    return  this.httpClient.post<Store[]>("http://localhost:64724/api/Users/GetAllUser", user);
  }
 
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
  GetSORTETPAT(stores:Store[]):Observable<any[]>{
    // const data=new FormData();
    // data.append('user',JSON.stringify(user));
    // console.log(data.get('user'));
    
    return this.httpClient.post<any[]>("http://localhost:64724/api/Users/Login" ,  stores);
  }
  
}