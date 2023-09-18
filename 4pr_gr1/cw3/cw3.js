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
};
Book1.setPrice(99.69);
document.querySelector("#root").innerHTML = Book1.info();