//literalne towrzenie obiektów  =>
const Book1 = {
  //pola obiektu
  title: "ABC programowania w JS",
  author: "Antoni Kropka",
  year: 2021,
  price: 19.99,
  //metody obiektu
  info: function () {
    return `
            <div>
            Tytuł: ${this.title} Autor: ${this.author} 
            Cena: ${this.price} zł Rok wydania: ${this.year}
            </div>
        `;
  },
  setPrice: function (price) {
    this.price = price;
  },
  thisArrow: ()=>{
    console.log(this);
  },
  thisFunction: function(){
    console.log(this);
  }
};
Book1.setPrice(99.69);

console.log(Book1.thisArrow());
console.log(Book1.thisFunction());
////////////////////////////
function Game(title,price,genre){
  this.title = title;
  this.price = price;
  this.genre = genre;
  this.show = function(){
    return `
      <div>
      Tytuł: ${this.title} Cena: ${this.price} Rodzaj: ${this.genre}      
      </div>
    `
  };
}
const g1 = new Game("Wiedźmin 3",45.99,2015);
const g2 = new Game("Wiedźmin 4",345.99,2028);
console.log(g2);
document.querySelector("#root1").innerHTML = Book1.info();
document.querySelector("#root2").innerHTML = g2.show();
