import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './component/user/user.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { HomeComponent } from './component/home/home.component';
import { HttpClientModule } from '@angular/common/http';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EnterComponent } from './component/enter/enter.component';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
import { SearchComponent } from './component/search/search.component';
import { SearchStorsComponent } from './component/search-stors/search-stors.component';
import { SearchCategorysComponent } from './component/search-categorys/search-categorys.component';
import { StorsComponent } from './component/stors/stors.component';
import { CategorysComponent } from './component/categorys/categorys.component';
import { StorsDetailsComponent } from './component/stors-details/stors-details.component';
import { HistoryComponent } from './component/history/history.component';
import { UserInformationComponent } from './component/user-information/user-information.component';
import { NavComponent } from './component/nav/nav.component';




@NgModule({
  declarations: [
  
    AppComponent,
    UserComponent,
    SignInComponent,
    HomeComponent,
    SignUpComponent,
    EnterComponent,
    RouteSelectionComponent,
    SearchComponent,
    SearchStorsComponent,
    SearchCategorysComponent,
    StorsComponent,
    CategorysComponent,
    StorsDetailsComponent,
    HistoryComponent,
    UserInformationComponent,
    NavComponent
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
