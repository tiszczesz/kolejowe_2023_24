import { Component, Input } from '@angular/core';
import { Person } from '../../lista';
@Component({
  selector: 'app-persons-list',
  standalone: true,
  imports: [],
  templateUrl: './persons-list.component.html',
  styleUrl: './persons-list.component.css'
})
export class PersonsListComponent {
change() {
  this.isRed=!this.isRed;
}
  @Input() persons!:Person[];
  info = "hello from Angular";
  isRed = true;
}
