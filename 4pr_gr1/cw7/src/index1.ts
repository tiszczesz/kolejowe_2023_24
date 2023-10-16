import { Posts,Post } from "./posts.js";
import { User,users,Address } from "./users.js";

console.log(Posts);
(document.querySelector("#users")as HTMLDivElement).innerHTML = generUsers()

const lis = document.querySelectorAll("li");
console.log(lis);

lis.forEach((u)=>{
    u.addEventListener("click",(e)=>{
        console.log(u.id);   
        const userPosts = Posts.filter((e)=>{return e.userId===parseInt(u.id)}) 
        document.querySelector("#posts")!.innerHTML = generPostsHTML(userPosts);
            
    })
})

function generPostsHTML(posts:Post[]):string {
    let html = "";
    for(const p of posts){
        html += `
        <div class="card m-2" style="width: 18rem;">       
        <div class="card-body">
          <h5 class="card-title bg-light bg-gradient p-1">${p.title}</h5>
          <p class="card-text">${p.body}</p>
        </div>
      </div>
        `
    }

    return html;
}
function generUsers(): string {
    let html = "<ul class=\"list-group\">";
        for(const u of users){
            html += `<li id=${u.id} class="list-group-item" ><span class='btn btn-primary w-100'>${u.name}</span></li>`;
        }
    return html + "</ul>";
}

