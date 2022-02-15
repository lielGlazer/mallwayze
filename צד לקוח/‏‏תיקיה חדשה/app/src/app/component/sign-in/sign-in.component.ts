import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { User } from 'src/app/models/User';
import { DbService } from 'src/app/serves/db.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {

  signInForm: any;
  constructor(private dbService: DbService, private router:Router) { }

  ngOnInit(): void {

    this.signInForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(8)])),
        password: new FormControl('')
      }
    )

  }


  doSignIn() {
    console.log(this.signInForm);

    const user: User = {
      UserCode: 0,
      UserName: this.signInForm.controls.userName.value,
      Password: this.signInForm.controls.password.value
    }

    console.log(user);




    this.dbService.signIn(user).subscribe(res => {
      console.log(res);
      if (res == null)
        alert("שגיאת שרת אין אפשרות לחבר אותך מצטערים 😨😱😰");
      else {
        alert("התחברת בהצלחה! הקוד שלך הוא " + res.UserCode);
        user.UserCode = res.UserCode;
        this.router.navigate(["route-selection"]);


      }
    })


  }
}