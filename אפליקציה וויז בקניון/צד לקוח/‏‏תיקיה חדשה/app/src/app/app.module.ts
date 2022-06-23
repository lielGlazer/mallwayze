import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './component/user/user.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { HomeComponent } from './component/home/home.component';
import { CateroryComponent } from './component/caterory/caterory.component';
import { HttpClientModule } from '@angular/common/http';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
import { StorsComponent } from './component/stors/stors.component';
import { RouteStorComponent } from './component/route-stor/route-stor.component';
import { StorDataComponent } from './component/stor-data/stor-data.component';
import { ErrorComponent } from './component/error/error.component';
import { RouteOneStorComponent } from './component/route-one-stor/route-one-stor.component';
 import { RouteCategoryComponent } from './component/route-category/route-category.component';

import { PathComponent } from './component/path/path.component';






@NgModule({
  declarations: [
  
    AppComponent,
    UserComponent,
    SignInComponent,
    HomeComponent,
    CateroryComponent,
    SignUpComponent,
    RouteSelectionComponent,
    StorsComponent,
    RouteStorComponent,
    RouteCategoryComponent,
    StorDataComponent,
    ErrorComponent,
   RouteOneStorComponent,
   PathComponent,
   
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,  
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
