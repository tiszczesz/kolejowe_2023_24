int[] tab = new int[10];
showTab(tab);

tab[6] = 666;
//tab[10] = 7777;
showTab(tab);
fillTab(tab);
showTab(tab);

//Console.WriteLine(tab.Length);
void showTab(int[] t){
    foreach (int elem in t)    {
        Console.Write(elem + " ");
    }
    Console.WriteLine();
}
void fillTab(int[] t){
    Random rnd = new Random();
    for(int i=0; i<t.Length;i++){
        t[i] = rnd.Next(0,200);
    }
}