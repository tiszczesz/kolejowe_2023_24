import { Posts,Post } from "./posts.js";
import { User,users,Address } from "./users.js";

console.log(Posts);
(document.querySelector("#users")as HTMLDivElement).innerHTML = generUsers()
function generUsers(): string {
    let html = "<ul class=\"list-group\">";
        for(const u of users){
            html += `<li class="list-group-item" ><span class='btn btn-primary w-100'>${u.name}</span></li>`;
        }
    return html + "</ul>";
}

