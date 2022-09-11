import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class InspectionApiService {

  readonly inspectionApiURL="https://localhost:7115/api";

  constructor(private httpClient: HttpClient) { }


  getAllInspections():Observable<any[]>{
    return this.httpClient.get<any>(this.inspectionApiURL.concat("/inspection"));
  }

  insertAInspection(data:any){
    return this.httpClient.post(this.inspectionApiURL.concat("/inspection"), data);
  }

  updateInspection(id:number|String,  data :any){
    return this.httpClient.put(this.inspectionApiURL.concat(`/inspection/${id}`),data);
  }

  deleteInspection(id:number|String){
    return this.httpClient.delete(this.inspectionApiURL.concat(`inspection/${id}`));
  }

  //InspectionType
  
  getAllInspectionsType():Observable<any[]>{
    return this.httpClient.get<any>(this.inspectionApiURL.concat("/inspectiontype"));
  }

  insertAInspectionType(data:any){
    return this.httpClient.post(this.inspectionApiURL.concat("/inspectiontype"), data);
  }

  updateInspectionType(id:number|String,  data :any){
    return this.httpClient.put(this.inspectionApiURL.concat(`/inspectiontype/${id}`),data);
  }

  deleteInspectionType(id:number|String){
    return this.httpClient.delete(this.inspectionApiURL.concat(`inspectiontype/${id}`));
  }


  //Status

  getAllStatues():Observable<any[]>{
    return this.httpClient.get<any>(this.inspectionApiURL.concat("status"));
  }

  insertStatus(data:any){
    return this.httpClient.post(this.inspectionApiURL.concat("/status"),data);
  }

  updateStatus(id:number|String, data:any){
    return this.httpClient.put(this.inspectionApiURL.concat(`/status/${id}`),data);
  }

  deletestatus(id:number){
    return this.httpClient.delete(this.inspectionApiURL.concat(`/status/${id}`));
  }


}
