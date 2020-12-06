import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Developer } from '../models/developer.model';
import { API } from '../../app.api';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { ErrorHandler } from '../../app.error-handler';

const httpOptions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
};

@Injectable()
export class CurriculoService {

    constructor(private http: HttpClient) { }

    salvar(developer: Developer): Observable<number> {
        return this.http.post<Developer>(`${API}/api/developers`, developer, httpOptions)
            .pipe(catchError(ErrorHandler.handleError));
    }

    editar(developer: Developer): Observable<Developer> {
        return this.http.put<Developer>(`${API}/api/developers`, developer, httpOptions)
            .pipe(catchError(ErrorHandler.handleError));
    }

    listar(): Observable<Developer[]> {
        return this.http.get<Developer[]>(`${API}/api/developers`)
            .pipe(catchError(ErrorHandler.handleError));
    }

    listarPorId(id: number): Observable<Developer> {
        return this.http.get<Developer>(`${API}/api/developers/${id}`, httpOptions)
            .pipe(catchError(ErrorHandler.handleError));
    }
}
