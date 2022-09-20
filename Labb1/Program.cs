//Skapa en konsollapplikation som tar en textsträng (string) som argument till Main eller uppmanar användaren mata in en sträng i konsollen.
//Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan.
//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.


Console.WriteLine("Hej! Skriv in ett tal: \n ");
string input = Console.ReadLine();
string delsträng = String.Empty;
bool isDigit;
string first = string.Empty;
string last = string.Empty;
double count = 0;

for (int i = 0; i < input.Length; i++)
    {
    for (int j = i + 1; j < input.Length; j++)
        {
        isDigit = Char.IsDigit(input[j]);
        if (isDigit)
            {

            if (input[i] == input[j])

                {
                //Sparar delsträng
                delsträng = input.Substring(i, j - i + 1);

                //Summan av delsträngarna
                double sum = double.Parse(delsträng);
                count += sum;

                first = input.Substring(0, i);

                //För att få fram startindex till variabeln last
                var length = first.Length + delsträng.Length;

                last = input.Substring(length);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(first);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(delsträng);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(last + "\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
                }

            }
        else
            {
            break;
            }

        }

    }
Console.WriteLine("Detta är summan av alla delsträngar: " + count);









