import { HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { Observable } from 'rxjs';

export class ErrorHandler {
    static handleError(error: HttpErrorResponse | any): Observable<any> {

        let errorMesage: string;
        if (error instanceof HttpErrorResponse) {
            if (error.error) {
                errorMesage = error.error[0];
            }
            else {
                errorMesage = `Erro ${error.status} ao acessar a URL ${error.url} - ${error.statusText}`;
            }
        }
        else {
            errorMesage = error.toString();
        }

        return throwError(errorMesage);
    }
}