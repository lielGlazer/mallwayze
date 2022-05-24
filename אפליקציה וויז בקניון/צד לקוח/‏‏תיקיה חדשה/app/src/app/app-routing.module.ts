import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CateroryComponent } from './component/caterory/caterory.component';
import { EnterComponent } from './component/enter/enter.component';
import { ErrorComponent } from './component/error/error.component';
import { HomeComponent } from './component/home/home.component';
import { OneStoreComponent } from './component/one-store/one-store.component';
import { RouteCategoryComponent } from './component/route-category/route-category.component';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
import { RouteSmartComponent } from './component/route-smart/route-smart.component';
import { RouteStorComponent } from './component/route-stor/route-stor.component';
import { SearchCategorysComponent } from './component/search-categorys/search-categorys.component';
import { SearchStorsComponent } from './component/search-stors/search-stors.component';
import { SearchComponent } from './component/search/search.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { StorDataComponent } from './component/stor-data/stor-data.component';
import { StorsComponent } from './component/stors/stors.component';
import { UserComponent } from './component/user/user.component';


const routes: Routes = [
  //דף הבית//
  { path: '', pathMatch: 'full', component: HomeComponent },
  //חיפוש//
  {
    path: 'search', component: SearchComponent, children: [
      {
        path: 'search-stor', component: SearchStorsComponent, children: [
          { path: 'stor-data', component: StorDataComponent }
        ]
      },
      { path: 'search-category', component: SearchCategorysComponent }
    ]
  },
  //כל החניות //
  { path: 'all-stor', component: StorsComponent },
  // //כניסה.//
  // {
  //   path: 'enter', component: EnterComponent, children: [
  //     //להרשם//
  { path: 'sign-up', component: SignUpComponent },
  //להתחבר//
  {
    path: 'sign-in', component: SignInComponent, children: [
      { path: 'roate-smart', component: RouteSmartComponent }
    ]
  },
  
    
  
  //חישוב מסלול//
  {
    path: 'route-selection', component: RouteSelectionComponent, children: [
      //מסלול לחנות//
      { path: 'route-stor', component: RouteStorComponent },
      //מסלול לקטגוריות//
      { path: 'route-category', component: RouteCategoryComponent },
      //מסלול חכם//
      { path: 'roate-smart', component: RouteSmartComponent }
    ]
  },

  //טעות//
  { path: 'error', component: ErrorComponent }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
