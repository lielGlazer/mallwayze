import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategorysComponent } from './component/categorys/categorys.component';
import { EnterComponent } from './component/enter/enter.component';
import { HomeComponent } from './component/home/home.component';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
import { SearchCategorysComponent } from './component/search-categorys/search-categorys.component';
import { SearchStorsComponent } from './component/search-stors/search-stors.component';
import { SearchComponent } from './component/search/search.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { StorsComponent } from './component/stors/stors.component';
import { UserInformationComponent } from './component/user-information/user-information.component';
import { UserComponent } from './component/user/user.component';


const routes: Routes = [
  {path:'', component:HomeComponent},
  {path:'enter',component:EnterComponent,children:[
    {path:'sign-in', component:SignInComponent,children:[
      {path:'search', component:SearchComponent,children:[
        {path:'searchStores', component:SearchStorsComponent,children:[
          {path:'stors', component:StorsComponent,children:[
            {path:'Store-details',component:StorsComponent},
            {path:'view-route',component:RouteSelectionComponent}
          ]},
        ]},
        {path:'search-categorys', component:SearchCategorysComponent,children:[
            {path:'categorys',component:CategorysComponent},
            {path:'view-route',component:StorsComponent}
          ]}
        ]}
    ]},//הירשם
    {path:'sign-up', component:SignUpComponent,children:[
      {path:'search-stors', component:SearchStorsComponent},
      {path:'user-information',component:UserInformationComponent},
    ]},
  ]},

 
  
  {path:'route-selection', component:RouteSelectionComponent},
  

 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
