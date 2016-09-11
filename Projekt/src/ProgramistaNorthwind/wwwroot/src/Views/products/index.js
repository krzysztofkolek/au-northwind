import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class ProductsIndex {

    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate() {
        
        return this.downloader
                   .setApiUrl('/products')
                   .getAll()
                   .then(product => {
                       this.product = product;
                   });
    } 
}