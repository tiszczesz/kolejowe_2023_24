export type Recipe = {
    name: string;
    ingredient: string[];
    price: number;
    description: string;
};


export const Recipes:Recipe[] = [
    {
        name: "Pierogi z kapustą i grzybami",
        ingredient: ["Kapusta", "Grzyby", "Cebula", "Mąka", "Jajka", "Sól", "Pieprz"],
        price: 30,
        description: "Tradycyjne pierogi z kapustą i grzybami, idealne na wigilijny stół."
    },
    {
        name: "Barszcz czerwony z uszkami",
        ingredient: ["Buraki", "Cebula", "Czosnek", "Marchew", "Seler", "Zioła", "Mąka", "Jajka"],
        price: 25,
        description: "Klasyczny barszcz czerwony podawany z domowymi uszkami. Idealny na zimowe dni."
    },
    {
        name: "Karp po żydowsku",
        ingredient: ["Karp", "Cebula", "Marchew", "Mąka", "Jajka", "Przyprawy"],
        price: 40,
        description: "Karp marynowany i pieczony w tradycyjnym stylu żydowskim."
    },
    {
        name: "Kutia",
        ingredient: ["Mąka pszenna", "Mąka żytnia", "Miód", "Migdały", "Rodzynki", "Orzechy"],
        price: 24,
        description: "Słodka i sycąca kutia, tradycyjne danie wigilijne."
    },
    {
        name: "Piernik",
        ingredient: ["Mąka", "Miód", "Jajka", "Przyprawy korzenne", "Cukier"],
        price: 26,
        description: "Klasyczne świąteczne ciasto, słodkie i korzenne."
    },
    {
        name: "Sałatka śledziowa",
        ingredient: ["Śledzie", "Ziemniaki", "Marchew", "Cebula", "Ogórki kiszone", "Jajka", "Majonez"],
        price: 36,
        description: "Popularna sałatka na wigilijnym stole, idealna jako przystawka."
    },
    {
        name: "Kluski śląskie z sosem grzybowym",
        ingredient: ["Ziemniaki", "Mąka ziemniaczana", "Jajka", "Grzyby", "Cebula", "Śmietana"],
        price: 30,
        description: "Tradycyjne kluski podawane z gęstym sosem grzybowym."
    },
    {
        name: "Barszcz ukraiński z pasztecikami",
        ingredient: ["Buraki", "Cebula", "Czosnek", "Marchew", "Seler", "Mąka", "Jajka", "Mięso", "Przyprawy"],
        price: 33,
        description: "Pyszny barszcz podawany z domowymi pasztecikami, idealny na chłodne wieczory."
    },
    {
        name: "Ryba po grecku",
        ingredient: ["Ryba (np. dorsz)", "Marchew", "Cebula", "Pieczarki", "Mąka", "Jajka", "Majonez"],
        price: 45,
        description: "Tradycyjna ryba marynowana i pieczona z warzywami, lekka i smaczna."
    },
    {
        name: "Szarlotka",
        ingredient: ["Jabłka", "Mąka", "Cukier", "Masło", "Jajka", "Cynamon"],
        price: 28,
        description: "Klasyczna szarlotka z kwaśnymi jabłkami i aromatycznym cynamonem."
    }
]
