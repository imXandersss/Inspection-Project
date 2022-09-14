import { Component, OnInit } from '@angular/core';
import {  Observable } from "rxjs";
import {InspectionApiService} from "../../inspection-api.service"

@Component({
  selector: 'app-show-inspection',
  templateUrl: './show-inspection.component.html',
  styleUrls: ['./show-inspection.component.css']
})
export class ShowInspectionComponent implements OnInit {

  inspectionList$!: Observable<any[]>;
  inspectionTypesList$!:Observable<any[]>;
  inspectionTypesList:any=[]

  //Map to display  data associate with foreign keys
  inspectionTypesMap:Map<number,string>= new Map();

  constructor(private service: InspectionApiService) { }

  ngOnInit(): void {
    this.inspectionList$=this.service.getAllInspections();
    this.inspectionTypesList$=this.service.getAllInspectionsType();
    this.refreshInspectionTypesMap();
  }


  //variables (properties)
  modalTitle:string='';
  activateAddEditInspectionComponent:boolean=false;
  inspection:any;


  modalAdd(){
    this.inspection={
      id:0,
      status:null,
      comments:null,
      idInspectionType:null
    }
    this.modalTitle="Add Inspection";
    this.activateAddEditInspectionComponent=true;
  }

  refreshInspectionTypesMap(){
    this.service.getAllInspectionsType().subscribe(data=>{
      this.inspectionTypesList=data;
      for(let i=0; i <data.length; i++){
        this.inspectionTypesMap.set(this.inspectionTypesList[i].id, this.inspectionTypesList[i].inspectionName);
      }
    });
  }

  modalClose(){
    this.activateAddEditInspectionComponent=false;
    this.inspectionList$=this.service.getAllInspections();
  }

}
