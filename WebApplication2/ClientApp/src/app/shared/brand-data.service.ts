import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Brand } from "./brand";
import { environment } from "src/environments/environment";

@Injectable({
  providedIn: "root",
})
export class BrandDataService {
  constructor(private http: HttpClient) {}

  loadBrands(): Observable<Brand[]> {
    return this.http.get<Brand[]>(`${environment.url}/api/brands`);
  }
}
