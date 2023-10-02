class MyClass{
    #firstname;
    #lastname;
    constructor(firstname,lastname){
        this.#firstname = firstname;
        this.#lastname = lastname;
    }
}
const my = new MyClass("wwww","tttttt");
console.log(my.firstname);