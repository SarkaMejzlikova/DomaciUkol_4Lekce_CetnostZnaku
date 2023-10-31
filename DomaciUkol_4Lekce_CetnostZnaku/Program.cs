//Zadání
//Vytvoř program, který nad zadaným textem provede statistiku znaků.
//Tedy spočítej kolikrát se který znak v textu vyskytuje. Nejlépe využij pro tento program listu, kde typem listu bude tvůj vlastní typ obsahující samotný znak a počet jeho výskytů.
//(Ano, pro znalejší v podstatě vytváříš typ dictionary, o kterém se budeme bavit příště :) )
//Pokud si budeš chtít vyhrát můžeš spočítat i kolik je bílých znaků, kolik písmen je velkých, kolik malých apod. (tedy využití funkcí typu char) 

string vstupniText = "Vytvoř program, který nad zadaným textem provede statistiku znaků.";


while (vstupniText.Length > 0)
{
    Console.Write(vstupniText[0] + " : ");
    int count = 0;
    for (int j = 0; j < vstupniText.Length; j++)
    {
        if (vstupniText[0] == vstupniText[j])
        {
            count++;
        }
    }
    Console.WriteLine(count);
    vstupniText = vstupniText.Replace(vstupniText[0].ToString(), string.Empty);
}


Console.ReadLine();
