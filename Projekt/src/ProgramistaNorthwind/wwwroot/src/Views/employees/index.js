import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class EmployeesIndex {

    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate() {
        
        return this.downloader
                   .setApiUrl('/employees')
                   .getAll()
                   .then(employees => {
                       this.employees = employees;
                   });
    }
}