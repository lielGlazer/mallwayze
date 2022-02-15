import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CateroryComponent } from './component/caterory/caterory.component';
import { HomeComponent } from './component/home/home.component';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { UserComponent } from './component/user/user.component';


const routes: Routes = [

 
  {path:'sign-in', component:SignInComponent},
  {path:'sign-up', component:SignUpComponent},
  {path:'route-selection', component:RouteSelectionComponent},
  {path:'', component:HomeComponent},

 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
