import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { BusyService } from '../_services/busy.service';
import { delay, finalize } from 'rxjs';

export const loadingInterceptor: HttpInterceptorFn = (req, next) => {
  const busyService = inject(BusyService);

  // starts the loading spinner
  busyService.busy();

  // rquest completed, uses finalize to set idle to turn off loading spinner
  return next(req).pipe(
    delay(1000), 
    finalize(() => {
      busyService.idle()
    })
  )
};
