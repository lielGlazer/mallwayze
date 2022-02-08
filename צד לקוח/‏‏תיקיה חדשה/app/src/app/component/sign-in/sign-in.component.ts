import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/models/User';
import { DbService } from 'src/app/serves/db.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignUpComponent implements OnInit {

  signInForm: any;
  constructor(private dbService: DbService) { }

  ngOnInit(): void {

    this.signInForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(8)])),
        password: new FormControl('')
      }
    )

  }


  doSignUp() {
    console.log(this.signInForm);

    const user: User = {
      UserCode: 0,
      UserName: this.signInForm.controls.userName.value,
      Password: this.signInForm.controls.password.value
    }

    console.log(user);




    this.dbService.signUp(user).subscribe(res => {
      console.log(res);
      if (res == null)
        alert("שגיאת שרת אין אפשרות לחבר אותך מצטערים 😨😱😰");
      else
        alert("התחברת בהצלחה! הקוד שלך הוא " + res.UserCode);
    })


  }}