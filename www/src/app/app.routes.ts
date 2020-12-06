import { Routes } from '@angular/router';
import { CurriculoComponent } from './curriculo/curriculo.component';
import { CandidatoComponent } from './candidato/candidato.component';

import { HomeComponent } from './home/home.component';

export const ROUTES: Routes = [
    { path: '', component: HomeComponent },
    { path: 'curriculo', component: CurriculoComponent },
    { path: 'candidatos', component: CandidatoComponent },
    { path: 'candidatos/:crud', component: CandidatoComponent }
];
