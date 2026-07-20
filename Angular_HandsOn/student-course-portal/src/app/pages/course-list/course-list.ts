import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CourseCard } from '../../components/course-card/course-card';

@Component({
  selector: 'app-course-list',
  imports: [
    CommonModule,
    CourseCard
  ],
  templateUrl: './course-list.html',
  styleUrl: './course-list.css'
})
export class CourseList implements OnInit {

  isLoading = true;

  selectedCourseId = 0;

  courses = [

    {
      id:101,
      name:'Angular Fundamentals',
      code:'ANG101',
      credits:4,
      gradeStatus:'passed',
      enrolled:false
    },

    {
      id:102,
      name:'TypeScript',
      code:'TS102',
      credits:3,
      gradeStatus:'pending',
      enrolled:false
    },

    {
      id:103,
      name:'Web Development',
      code:'WEB103',
      credits:4,
      gradeStatus:'failed',
      enrolled:false
    },

    {
      id:104,
      name:'Database Systems',
      code:'DB104',
      credits:4,
      gradeStatus:'passed',
      enrolled:false
    },

    {
      id:105,
      name:'Software Engineering',
      code:'SE105',
      credits:3,
      gradeStatus:'pending',
      enrolled:false
    }

  ];

  ngOnInit(): void {

    setTimeout(() => {

      this.isLoading = false;

    },1500);

  }

  onEnroll(courseId:number){

    console.log(
      'Enrolling in course: '+courseId
    );

    this.selectedCourseId = courseId;

  }

  // trackBy improves performance by allowing Angular
  // to reuse existing DOM elements instead of recreating them.
  trackByCourseId(index:number,course:any){

      return course.id;

  }

}