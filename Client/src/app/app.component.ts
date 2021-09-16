import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Subscriber } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Dating App';
  Users: any;

  constructor(private http:HttpClient){}

  ngOnInit(): void {
    this.getUsers();
  }
  getUsers(){
    this.http.get('https://localhost:5001/api/getdataofusers').subscribe(response=>{
      this.Users= response;
    },error=>{
      console.log(error);
    })
  }
}
