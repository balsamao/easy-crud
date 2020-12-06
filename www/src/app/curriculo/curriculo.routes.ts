import { Routes } from '@angular/router';
import { CurriculoComponent } from './curriculo.component';
import { CurriculoApresentacaoComponent } from './etapas/curriculo-apresentacao/curriculo-apresentacao.component';
import { CurriculoContatoComponent } from './etapas/curriculo-contato/curriculo-contato.component';
import { CurriculoPreferenciasComponent } from './etapas/curriculo-preferencias/curriculo-preferencias.component';
import { CurriculoConhecimentoComponent } from './etapas/curriculo-conhecimento/curriculo-conhecimento.component';

export const CURRICULO_ROUTES: Routes = [
    {
        path: 'curriculo',
        data: { headerTitle: 'Banco de talentos - Currículo', title: 'Banco de talentos - Currículo' },
        component: CurriculoComponent,
        children: [
            {
                path: '',
                redirectTo: 'apresentacao',
                pathMatch: 'full'
            },
            {
                path: 'apresentacao',
                component: CurriculoApresentacaoComponent,
                data: { headerTitle: 'Banco de talentos - Apresentação', title: 'Currículo' }
            },
            {
                path: 'apresentacao/:id',
                component: CurriculoApresentacaoComponent,
                data: { headerTitle: 'Banco de talentos - Apresentação', title: 'Currículo' }
            },
            {
                path: 'contato',
                component: CurriculoContatoComponent,
                data: { headerTitle: 'Banco de talentos - Contato', title: 'Currículo' }
            },
            {
                path: 'preferencias',
                component: CurriculoPreferenciasComponent,
                data: { headerTitle: 'Banco de talentos - Preferências', title: 'Currículo' }
            },
            {
                path: 'conhecimento',
                component: CurriculoConhecimentoComponent,
                data: { headerTitle: 'Receita Antecipada - Negociação Fechada', title: 'Cadastro' }
            }
        ]
    }
];