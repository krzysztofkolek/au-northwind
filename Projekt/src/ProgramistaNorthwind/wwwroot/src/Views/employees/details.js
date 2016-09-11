import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class EmployeesDetails {
    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate(params) {         
        return this.downloader
                   .setApiUrl('/employees/')
                   .getById(params.id)
                   .then(employee => {
                       this.firstname = employee.firstName;
                       this.lastname  = employee.lastName;
                       this.jobtitle = employee.jobTitle;                       
                       this.dateofhire = employee.dateOfHire;
                       this.image = employee.image;    
                   });		
		}
}