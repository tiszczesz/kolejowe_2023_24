
Ex1();
Ex2();
void Ex2(){
    //uzytkownik proszony jest o podawanie tekstu liniami
    //az do uzycia napisu null lub Null lub nULL
    // raczej do ramu List a potem do pliku jedna komenda
    //wtedy konczy i zapisuje do pliku
    //nastepnie pyta czy wczytac plik i go wyswietlic
    // jesli odpowiadamy y to to robi lub konczy program
    File.ReadAllLines("dane.txt"); 

}
void Ex1()
{
    List<string> words = new List<string>{
    "ala ma kota",
    "rybki ...",
    "cos odkrywczego"
};
    File.WriteAllLines("dane.txt", words);
}