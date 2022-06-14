import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CateroryComponent } from './component/caterory/caterory.component';
import { ErrorComponent } from './component/error/error.component';
import { HomeComponent } from './component/home/home.component';
import { PathComponent } from './component/path/path.component';
import { RouteCategoryComponent } from './component/route-category/route-category.component';
import { RouteOneStorComponent } from './component/route-one-stor/route-one-stor.component';
import { RouteSelectionComponent } from './component/route-selection/route-selection.component';
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
      { path: 'route-stor', component: RouteStorComponent },
      { path: 'route-category', component: RouteCategoryComponent },

    ]
  },



  //חישוב מסלול//
  {
    path: 'route-selection', children: [
      {path:'', pathMatch:'full' , component: RouteSelectionComponent},
      // מסלול לחנויות//
      { path: 'route-stor', component: RouteStorComponent, children:[{path:'app-path',component:PathComponent}]},
      { path: 'app-path', component: PathComponent},
      //מסלול לקטגוריות//
      { path: 'route-category', component: RouteCategoryComponent,children:[{path:'app-path',component:PathComponent}]},
      //מסלול לחנות בודדת//
      { path: 'route-one-stor', component: RouteOneStorComponent ,children:[{path:'app-path',component:PathComponent}]},
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
