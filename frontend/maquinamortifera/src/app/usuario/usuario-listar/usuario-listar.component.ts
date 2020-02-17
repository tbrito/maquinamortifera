import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/_services/user.service';
import { Usuario } from 'src/app/_models/usuario';

@Component({
  selector: 'app-usuario-listar',
  templateUrl: './usuario-listar.component.html',
  styleUrls: ['./usuario-listar.component.css']
})
export class UsuarioListarComponent implements OnInit {

  usuarios: Usuario[];

  cols: any[];

  constructor(private usuarioService: UserService) { }

  ngOnInit() {
    this.usuarioService.getAll().subscribe(resp => {
      this.usuarios =  resp;
    });

    this.cols = [
        { field: 'login', header: 'Login' },
        { field: 'nome', header: 'Nome' }
    ];
  }
}
