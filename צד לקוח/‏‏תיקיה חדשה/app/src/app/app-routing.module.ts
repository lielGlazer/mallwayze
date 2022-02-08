import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CateroryComponent } from './component/caterory/caterory.component';
import { JoinComponent } from './component/join/join.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { UserComponent } from './component/user/user.component';


const routes: Routes = [
  {path:"SignIn", component:SignInComponent},
  {path:"SignUp", component:SignUpComponent},
  {path:"Join",component:JoinComponent},
  {path:"User",component:UserComponent},
  {path:"Category",component:CateroryComponent},
  {path:"Category",component:CateroryComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
