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
import { EnterComponent } from './component/enter/enter.component';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
import { SearchComponent } from './component/search/search.component';
import { SearchStorsComponent } from './component/search-stors/search-stors.component';
import { SearchCategorysComponent } from './component/search-categorys/search-categorys.component';
import { StorsComponent } from './component/stors/stors.component';
import { RouteStorComponent } from './component/route-stor/route-stor.component';
import { RouteCategoryComponent } from './component/route-category/route-category.component';
import { RouteSmartComponent } from './component/route-smart/route-smart.component';
import { StorDataComponent } from './component/stor-data/stor-data.component';
import { ErrorComponent } from './component/error/error.component';





@NgModule({
  declarations: [
  
    AppComponent,
    UserComponent,
    SignInComponent,
    HomeComponent,
    CateroryComponent,
    SignUpComponent,
    EnterComponent,
    RouteSelectionComponent,
    SearchComponent,
    SearchStorsComponent,
    SearchCategorysComponent,
    StorsComponent,
    RouteStorComponent,
    RouteCategoryComponent,
    RouteSmartComponent,
    StorDataComponent,
    ErrorComponent,
  
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
