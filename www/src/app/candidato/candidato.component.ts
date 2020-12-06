import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Developer } from '../curriculo/models/developer.model';
import { CurriculoService } from '../curriculo/services/curriculo.service';

@Component({
  selector: 'app-candidato',
  templateUrl: './candidato.component.html',
  styleUrls: ['./candidato.component.css']
})
export class CandidatoComponent implements OnInit {

  developers: Developer[] = [];
  sucesso = false;

  constructor(private curriculoService: CurriculoService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.curriculoService.listar()
      .subscribe(cargos => {
        this.developers = cargos;
        if (this.route.snapshot.params.crud) {
          this.sucesso = this.route.snapshot.params.crud;
        }
      });
  }

}
