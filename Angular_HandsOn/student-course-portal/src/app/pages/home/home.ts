import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-home',
  imports: [FormsModule],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home implements OnInit, OnDestroy {

  // Interpolation
  portalName = 'Student Course Portal';

  // Property Binding
  isPortalActive = true;

  // Event Binding
  message = '';

  // Two-Way Binding
  // Property Binding [property]
  // Component -----> DOM
  //
  // Two-Way Binding [(ngModel)]
  // Component <-----> DOM
  searchTerm = '';

  availableCourses = 0;

  ngOnInit(): void {

    this.availableCourses = 12;

    console.log(
      'HomeComponent initialised — courses loaded'
    );

  }

  ngOnDestroy(): void {

    console.log(
      'HomeComponent destroyed'
    );

  }

  onEnrollClick(): void {

    this.message = 'Enrollment opened!';

  }

}