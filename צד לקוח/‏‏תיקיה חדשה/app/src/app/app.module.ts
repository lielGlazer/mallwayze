import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './component/user/user.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { HomeComponent } from './component/home/home.component';
import { CateroryComponent } from './component/caterory/caterory.component';
import { JoinComponent } from './component/join/join.component';
import { HttpClientModule } from '@angular/common/http';
import { SingUpComponent } from './component/sing-up/sing-up.component';


@NgModule({
  declarations: [
  
    AppComponent,
    UserComponent,
    SignInComponent,
    HomeComponent,
    CateroryComponent,
    JoinComponent,
    SingUpComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,  
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
