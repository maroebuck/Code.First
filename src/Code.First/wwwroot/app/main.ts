import { bootstrap } from '@angular/platform-browser-dynamic';
import { AppComponent } from './app.component';
import { HTTP_PROVIDERS } from '@angular/http';
import { DataService } from './data.service';

bootstrap(AppComponent, [DataService, HTTP_PROVIDERS]);