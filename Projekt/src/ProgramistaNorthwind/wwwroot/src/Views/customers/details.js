import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class CustomersDetails {
    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate(params) {
        return this.downloader
                   .setApiUrl('/Customers')
                   .getById(params.id)
                   .then(custumer => {
                       this.companyName  =   custumer.companyName;   
                       this.contactName  =   custumer.contactName;   
                       this.contactTitle  =  custumer.contactTitle;   
                       this.address  =       custumer.address;   
                       this.city  =          custumer.city;  
                       this.region  =        custumer.region;  
                       this.postalCode  =    custumer.postalCode;  
                       this.country  =       custumer.country;        
                       this.phone  =         custumer.phone;           
                       this.fax  =           custumer.fax;      
                   });		
    }
}