import { Injectable, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { Gender } from './gender';
import 'rxjs/add/operator/share';

@Injectable()
export class DataService {
    public collection$: Observable<Gender[]>;
    private _collectionObserver: any;

    constructor( @Inject(Http) private http: Http) {
        this.http = http;
        this.collection$ = new Observable(observer => {
            this._collectionObserver = observer;
        }).share();
    }

    getItems() {
        this.http.get('api/codefirst').map((res: Response) => res.json()).subscribe(items => {
            this._collectionObserver.next(items);
        });
    }

}
