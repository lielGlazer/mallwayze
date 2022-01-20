import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CateroryComponent } from './caterory/caterory.component';
import { JoinComponent } from './join/join.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  {path:"SignIn", component:SignInComponent},
  {path:"Join",component:JoinComponent},
  {path:"User",component:UserComponent},
  {path:"Category",component:CateroryComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
