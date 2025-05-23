import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, NgModule, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'client';
  users: any;

  constructor(private http: HttpClient) { }
  ngOnInit() {
   this.getUsers();
  }

  getUsers() {
    this.http.get('http://localhost:5113/api/users').subscribe(response => {
      this.users = response;
    }, error => {
      console.log('api error',error);
    });
  }
}
