import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MyList, Person } from '../lista';
import { PersonsListComponent } from './persons-list/persons-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,PersonsListComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'first-app';
  list:Person[] = MyList;
}
