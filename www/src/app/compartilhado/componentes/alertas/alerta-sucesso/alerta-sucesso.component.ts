import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-alerta-sucesso',
  templateUrl: './alerta-sucesso.component.html',
  styleUrls: ['./alerta-sucesso.component.css']
})
export class AlertaSucessoComponent implements OnInit {

  @Input() podeExibir = false;
  @Input() mensagem = 'Registro salvo com sucesso!';

  constructor() {
  }

  ngOnInit(): void {
  }

}
