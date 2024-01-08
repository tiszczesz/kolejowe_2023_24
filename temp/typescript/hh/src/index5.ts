interface User{
    login:string;
    email:string;
    phone:string;
    isActive:boolean;
}
const Users :User[] = [
    { "login": "Admin", "email": 'admin@lo-dddd.pl', "phone": '34343434',"isActive":true },
    { "login": "Rymek", "email": 'Rymek@lo-dddd.pl', "phone": '5555555' ,"isActive": false},
    { "login": "Adminek", "email": 'adminek@lo-dddd.pl', "phone": '4444445',"isActive": true },
    { "login": "Admin", "email": 'admin@lo-dddd.pl', "phone": '44444',"isActive": false }
];
const generTab = (users:User[]):string =>{
    let html = "<table class='table table-striped table-hover'>"
    html += '<tr><th>Lp</th><th>Login</th><th>Email</th><th>Telefon</th></tr>';
    let lp = 0;
    users.forEach((u)=>{
        lp++;
        html += `<tr><td>${lp}</td><td>${u.login}</td><td>${u.email}</td><td>${u.phone}</td></tr>`;
    })
    return html+"</table>";
}
const result:HTMLElement|null = document.querySelector(".result");
if(result!==null){
    result.innerHTML = generTab(Users);
}
