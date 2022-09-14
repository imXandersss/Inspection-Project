import { Component,Input, OnInit } from '@angular/core';
import {  Observable } from "rxjs";
import { InspectionApiService} from "src/app/inspection-api.service";

@Component({
  selector: 'app-add-edit-inspection',
  templateUrl: './add-edit-inspection.component.html',
  styleUrls: ['./add-edit-inspection.component.css']
})
export class AddEditInspectionComponent implements OnInit {

inspectionList$!:Observable<any[]>;
statusList$!:Observable<any[]>;
inspectioTypesList$!:Observable<any[]>;

  constructor(private service:InspectionApiService ) { }

  @Input() inspection:any;
  id:number=0;
  status:string="";
  comments:string=""; 
  idInspectionType!:number;


  ngOnInit(): void {
    this.initializer();

  }

  initializer(){
    this.id=this.inspection.id;
    this.status=this.inspection.status;
    this.comments=this.inspection.comments;
    this.idInspectionType=this.inspection.idInspectionType;
    this.statusList$=this.service.getAllStatues();
    this.inspectionList$=this.service.getAllInspections();
    this.inspectioTypesList$=this.service.getAllInspectionsType();
  }


  addInspection(){
    var inspection={
      status: this.status,
      comments:this.comments,
      idInspectionType:this.idInspectionType 
    }
    this.service.insertAInspection(inspection).subscribe(res=>{

    
      var btnModal=document.getElementById('add-edit-modal-close');
      if(btnModal!=null){
        btnModal.click();
      }

      var showAddSuccess=document.getElementById('add-success-alert');
      if(showAddSuccess){
        showAddSuccess.style.display="block";
      }

      setTimeout(function(){
        if(showAddSuccess){
          showAddSuccess.style.display="none"
        }
      }, 4000);

    });
  }

  updateInspection(){

  }

}
