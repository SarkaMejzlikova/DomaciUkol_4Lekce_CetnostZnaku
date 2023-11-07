//Zadání
//Vytvoř program, který nad zadaným textem provede statistiku znaků.
//Tedy spočítej kolikrát se který znak v textu vyskytuje. Nejlépe využij pro tento program listu, kde typem listu bude tvůj vlastní typ obsahující samotný znak a počet jeho výskytů.
//(Ano, pro znalejší v podstatě vytváříš typ dictionary, o kterém se budeme bavit příště :) )
//Pokud si budeš chtít vyhrát můžeš spočítat i kolik je bílých znaků, kolik písmen je velkých, kolik malých apod. (tedy využití funkcí typu char) 

using DomaciUkol_4Lekce_CetnostZnaku;
using System.Collections.Generic;

string vstupniText = "Sarka";

List<Znak> statistika = new List<Znak>();

foreach (char znak in vstupniText)
{
        Znak provereniZnaku = null;
        for (int i = 0; i < statistika.Count; i++)
        {
            if ( statistika[i].Pismeno == znak)
            {
                provereniZnaku = statistika[i];
            }
        }

        if (provereniZnaku != null) 
        {
            provereniZnaku.Pocet++;
        }
        else
        {
            statistika.Add(new Znak() { Pismeno = znak, Pocet = 1 });
        }
}

foreach (var i in statistika)
{
    Console.WriteLine($"{ i.Pismeno} - {i.Pocet}" );

}

Console.ReadLine();
