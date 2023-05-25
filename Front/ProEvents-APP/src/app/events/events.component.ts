import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})

export class EventsComponent {
    constructor(private http: HttpClient){}
    public Event: any;


    public getEvents(): void {
      this.http.get('https://localhost:5001/api/eventos').subscribe(
        Response => this.Event = Response,
        Error => console.log(Error),
      );
    }
}
