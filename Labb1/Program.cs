
//Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan.
//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.


Console.WriteLine("Skriv in ett tal: ");
string input = Console.ReadLine();

string delsträng = String.Empty;
bool isDigit = false;

//Kör ett varv i taget, hoppar in i nästa loop och kör så många varv i rad som längden på input. Så för varje varv kan man jämföra i med resten av innehållet i strängen.

for (int i = 0; i < input.Length; i++)
    {

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(input[i]);


    for (int j = i + 1; j < input.Length; j++)
        {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(input[j]);

        isDigit = Char.IsDigit(input[j]);

        if (isDigit)
            {

            if (input[i] == input[j])

                {
                delsträng = input.Substring(i, j - i + 1); //Sparar matchningen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hittade en match! {delsträng}");
                }

            }
        else
            {
            break;
            }

        }

    }









