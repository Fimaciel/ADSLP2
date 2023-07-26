void Randomnumber()
{
    Random random = new Random();
    int answer = random.Next(1, 100), number;

    do
    {
        Console.WriteLine("Enter a number between 1-100:");
        number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("You can't put that's number!");
        }
        else
        {
            switch (number == answer)
            {
                case true:
                    Console.WriteLine("Right answer!");
                    break;
                case false:
                    if (number > answer)
                    {
                        System.Console.WriteLine("Number is over than Random number");
                    }
                    else
                    {
                        System.Console.WriteLine("Number is lower than Random number");
                    }
                    break;
            }
        }

    } while (number != answer);

}

Randomnumber();

Console.ReadKey();