import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class ProductsDetails {
    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate(params) {
        return this.downloader
                   .setApiUrl('/products/')
                   .getById(params.id)
                   .then(product => {
                       this.productName =     product.productName;     
                       this.discontinued =    product.discontinued;    
                       this.quantityPerUnit = product.quantityPerUnit;
                       this.reorderLevel =    product.reorderLevel;    
                       this.unitPrice =       product.unitPrice + '$';       
                       this.unitsInStock =    product.unitsInStock;    
                       this.unitsOnOrder =    product.unitsOnOrder;    
                   });		
    }
}