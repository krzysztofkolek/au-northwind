export class App {
    constructor() {
        this.message = "Welcome to Aurelia!";
    }

    configureRouter(config, router) {
        this.router = router;

        config.map([
			{ route:["", "home"], moduleId:"src/Views/home", title:"Home", nav:true, name:"home"},
            { route:"employees", moduleId:"src/Views/employees/index", title:"Employees", nav:true},
			{ route: "employeesdetails/:id", moduleId: "src/Views/employees/details", title: "Employees details", 
			                                                                          nav:false, name: "employeesdetails"},
            { route:"Customers", moduleId:"src/Views/Customers/index", title:"Customers", nav:true},
            { route: "Customersdetails/:id", moduleId: "src/Views/Customers/details", title: "Customers details", 
                                                                                      nav:false, name: "Customersdetails"},
            { route:"products", moduleId:"src/Views/products/index", title:"Products", nav:true},
            { route: "productsdetails/:id", moduleId: "src/Views/products/details", title: "Products details", 
                                                                                    nav:false, name: "productsdetails"},
        ]);
    }
}