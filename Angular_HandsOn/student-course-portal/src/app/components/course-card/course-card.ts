import { Component, EventEmitter, Input, Output, OnChanges, SimpleChanges } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-course-card',
  imports: [
    CommonModule
  ],
  templateUrl: './course-card.html',
  styleUrl: './course-card.css'
})
export class CourseCard implements OnChanges {

  @Input()
  course!: {
    id: number;
    name: string;
    code: string;
    credits: number;
    gradeStatus: 'passed' | 'failed' | 'pending';
  };

  @Output()
  enrollRequested = new EventEmitter<number>();

  ngOnChanges(changes: SimpleChanges): void {

    console.log(
      'Course Changed',
      changes['course']
    );

  }

  enroll(): void {
    this.enrollRequested.emit(this.course.id);
  }

}