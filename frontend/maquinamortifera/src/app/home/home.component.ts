import { Component } from '@angular/core';
import { first } from 'rxjs/operators';

import { Usuario } from '../_models/usuario';
import { UserService } from '../_services/user.service';
import { AuthenticationService } from '../_services/authentication.service';

@Component({ templateUrl: 'home.component.html' })
export class HomeComponent {
    loading = false;
    users: Usuario[];

    constructor(private userService: UserService) { }

    ngOnInit() {
        this.loading = false;
    }
}