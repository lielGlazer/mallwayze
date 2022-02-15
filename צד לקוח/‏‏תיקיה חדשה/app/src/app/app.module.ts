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




@NgModule({
  declarations: [
  
    AppComponent,
    UserComponent,
    SignInComponent,
    HomeComponent,
    CateroryComponent,
    SignUpComponent,
    EnterComponent,
    RouteSelectionComponent
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
