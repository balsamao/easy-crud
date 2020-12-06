import { Component, OnInit } from '@angular/core';
import { AbstractControl, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { NavegacaoService } from '../../services/navegacao.service';

@Component({
  selector: 'app-curriculo-apresentacao',
  templateUrl: './curriculo-apresentacao.component.html',
  styleUrls: ['./curriculo-apresentacao.component.css']
})
export class CurriculoApresentacaoComponent implements OnInit {

  regexEmail = '^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$';

  constructor(public navegacaoService: NavegacaoService, private route: ActivatedRoute) {
    this.email.setValidators([Validators.required, Validators.maxLength(150), Validators.pattern(this.regexEmail)]);
    this.name.setValidators([Validators.required, Validators.maxLength(150)]);
    this.hourlySalary.setValidators([Validators.required]);
    this.navegacaoService.titulo = 'Se apresente! ;)';
  }

  ngOnInit(): void {
    if (this.route.snapshot.params.id) {
      this.navegacaoService.listarPorId(this.route.snapshot.params.id);
    }
  }

  get name(): AbstractControl { return this.navegacaoService.form.get('name'); }
  get email(): AbstractControl { return this.navegacaoService.form.get('email'); }
  get portfolio(): AbstractControl { return this.navegacaoService.form.get('portfolio'); }
  get hourlySalary(): AbstractControl { return this.navegacaoService.form.get('hourlySalary'); }

}
