import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MyList, Person } from '../lista';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'first-app';
  list:Person[] = MyList;
}
