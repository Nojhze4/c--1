using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        string miString = "esto es una cadena de texto";
        miString = "Aqui cambia el valor de la cadena de texto";
        Console.WriteLine(miString);

        int myInt = 7;
        myInt = myInt + 4;
        Console.WriteLine(myInt);
        Console.WriteLine(myInt - 1);

        float myFloat = 6.5f;
        Console.WriteLine(myFloat);

        // Estructura

        var myArray = new string[] { "jhon", "ramirez", "nojhze", };
        Console.WriteLine(myArray[0]);

        myArray[2] = "28";
        Console.WriteLine(myArray[2]);

        var myDictionary = new Dictionary<string, int>
        {
            {"nojhze", 28},
            {"jhon", 18},
            {"alejandro", 20},
        };
        Console.WriteLine(myDictionary["nojhze"]);
    }
}

