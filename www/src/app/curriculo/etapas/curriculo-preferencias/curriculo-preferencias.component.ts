import { Component, OnInit } from '@angular/core';
import { AbstractControl } from '@angular/forms';
import { NavegacaoService } from '../../services/navegacao.service';

@Component({
  selector: 'app-curriculo-preferencias',
  templateUrl: './curriculo-preferencias.component.html',
  styleUrls: ['./curriculo-preferencias.component.css']
})
export class CurriculoPreferenciasComponent implements OnInit {

  constructor(public navegacaoService: NavegacaoService) {
    this.navegacaoService.titulo = 'Quais as suas preferências?! =D';
  }

  ngOnInit(): void {
  }

  get upToFourHoursPerDay(): AbstractControl { return this.navegacaoService.form.get('preference').get('upToFourHoursPerDay'); }
  get fourToSixHoursPerDay(): AbstractControl { return this.navegacaoService.form.get('preference').get('fourToSixHoursPerDay'); }
  get sixtoEightHoursPerDay(): AbstractControl { return this.navegacaoService.form.get('preference').get('sixtoEightHoursPerDay'); }
  get upToEightHoursADay(): AbstractControl { return this.navegacaoService.form.get('preference').get('upToEightHoursADay'); }
  get onlyWeekends(): AbstractControl { return this.navegacaoService.form.get('preference').get('onlyWeekends'); }
  get morning(): AbstractControl { return this.navegacaoService.form.get('preference').get('morning'); }
  get afternoon(): AbstractControl { return this.navegacaoService.form.get('preference').get('afternoon'); }
  get night(): AbstractControl { return this.navegacaoService.form.get('preference').get('night'); }
  get dawn(): AbstractControl { return this.navegacaoService.form.get('preference').get('dawn'); }
  get business(): AbstractControl { return this.navegacaoService.form.get('preference').get('business'); }
}
