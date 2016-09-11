import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class CustomersIndex {
    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate() {
        
        return this.downloader
                   .setApiUrl('/Customers')
                   .getAll()
                   .then(Customers => {
                       this.Customers = Customers;
                   });
    }
}