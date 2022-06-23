import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/models/User';
import { DbService } from 'src/app/serves/db.service';

@Component({
  selector: 'app-sign-up',
  templateUrl:'./sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {
  image = 'assets/build.png' 

  signUpForm: any;
  constructor(private dbService: DbService) { }

  ngOnInit(): void {


    this.signUpForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.maxLength(8)])),
        password: new FormControl('', [Validators.required]),   }
    )

  }


  doSignUp() {
    console.log(this.signUpForm);

    const user: User = {
      UserCode: 0,
      UserName: this.signUpForm.controls.userName.value,
      Password: this.signUpForm.controls.password.value
    }

    console.log(user);




    this.dbService.signUp(user).subscribe(res => {
      console.log(res);
      if (res == null)
        alert("נרשמת בהצלחה :)");
      else
        alert("נרשמת בהצלחה! הקוד שלך הוא " + res.UserCode);
    })


  }
}
