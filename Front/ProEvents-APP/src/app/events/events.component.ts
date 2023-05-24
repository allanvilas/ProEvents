import { Component } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent {
    public Event: any = [
      {
        Theme: 'Angular',
        Local: 'Limeira'
      },
      {
        Theme: '.NET 5',
        Local: 'Americana'
      },
      {
        Theme: 'C#',
        Local: 'Hortolândia'
      }
    ]
}
