import {inject} from "aurelia-framework";
import {HttpClient} from "aurelia-http-client";

let baseUrl = "/api/";

@inject(HttpClient)
export class ApiDataDownloader {
    
    constructor(httpClient) {
        this.http = httpClient;
    }

    setApiUrl(url) {
        this.url  = `${baseUrl}/${url}`;
        return this;
    }


    getById(id) {
        return this.http.get(`${this.url}/${id}`)
                        .then(response => response.content);
    }

    getAll() {
        return this.http.get(this.url)
                        .then(response => {
                            return response.content;
                        });
    }

    save(item) {
        var request = this.http.createRequest();
        request.asPut()
               .withUrl(baseUrl)
               .withContent(item);

        return request.send()
                      .then(response => response.content);
    }
}