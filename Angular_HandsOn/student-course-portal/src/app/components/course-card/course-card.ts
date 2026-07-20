import {
  Component,
  EventEmitter,
  Input,
  Output,
  OnChanges,
  SimpleChanges
} from '@angular/core';

import { CommonModule } from '@angular/common';
import { HighlightDirective } from '../../directives/highlight';
import { CreditLabelPipe } from '../../pipes/credit-label-pipe';
@Component({
  selector: 'app-course-card',
  imports: [CommonModule, HighlightDirective, CreditLabelPipe],
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
    gradeStatus: string;
    enrolled?: boolean;
  };

  @Output()
  enrollRequested = new EventEmitter<number>();

  isExpanded = false;

  ngOnChanges(changes: SimpleChanges): void {

    console.log(
      'Course Changed',
      changes['course']
    );

  }

  enroll(): void {

    this.course.enrolled = true;

    this.enrollRequested.emit(this.course.id);

  }

  toggleDetails(): void {

    this.isExpanded = !this.isExpanded;

  }

  // Getter keeps the template cleaner by moving
  // conditional class logic into the component.
  get cardClasses() {

    return {

      'card--enrolled': this.course.enrolled,

      'card--full': this.course.credits >= 4,

      'expanded': this.isExpanded

    };

  }

  getBorderColor(): string {

    switch (this.course.gradeStatus) {

      case 'passed':
        return 'green';

      case 'failed':
        return 'red';

      default:
        return 'gray';

    }

  }

}