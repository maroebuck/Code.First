import { Inject, Component, Input, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Gender } from './gender';

@Component({
    selector: 'app',
    templateUrl: 'app/app.component.html',
    styleUrls: ['app/app.component.css']
})
export class AppComponent implements OnInit {
    private items: Gender[];

    constructor( @Inject(DataService) public dataService: DataService) {
    }

    ngOnInit() {
        this.dataService.collection$.subscribe(latestCollection => {
            this.items = latestCollection;
        });
        this.dataService.getItems();
    }

}