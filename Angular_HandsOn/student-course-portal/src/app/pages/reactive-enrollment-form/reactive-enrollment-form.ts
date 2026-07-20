import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { FormArray, FormControl } from '@angular/forms';
import { noCourseCode } from '../../validators/course-code.validator';
import { simulateEmailCheck } from '../../validators/email.validator';

@Component({
  selector: 'app-reactive-enrollment-form',
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  templateUrl: './reactive-enrollment-form.html',
  styleUrl: './reactive-enrollment-form.css'
})
export class ReactiveEnrollmentForm implements OnInit {
  enrollForm!: FormGroup;

  constructor(
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
  this.enrollForm = this.fb.group({
    studentName: [
      '', 
      [Validators.required, Validators.minLength(3)]
    ],
    studentEmail: this.fb.control(
      '', 
      [Validators.required, Validators.email], 
      [simulateEmailCheck]
    ),
    courseId: [
      '', 
      [Validators.required, noCourseCode]
    ],
    preferredSemester: ['Odd', Validators.required],
    agreeToTerms: [false, Validators.requiredTrue],
    additionalCourses: this.fb.array([])
  });
}

get additionalCourses(): FormArray<FormControl> {
  return this.enrollForm.get(
    'additionalCourses'
  ) as FormArray<FormControl>;
}

addCourse(): void {
  this.additionalCourses.push(
    this.fb.control('', Validators.required)
  );
}

removeCourse(index: number): void {
  this.additionalCourses.removeAt(index);
}


  onSubmit(): void {
    console.log('Form Value');
    console.log(this.enrollForm.value);
    
    console.log('Raw Value');
    console.log(this.enrollForm.getRawValue());
  }
}
