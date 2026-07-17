import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CourseList } from './pages/course-list/course-list';

import { Header } from './components/header/header';
import { Home } from './pages/home/home';

@Component({
  selector: 'app-root',
  imports: [
    RouterOutlet,
    Header,
    Home,
    CourseList
  ],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'student-course-portal';
}