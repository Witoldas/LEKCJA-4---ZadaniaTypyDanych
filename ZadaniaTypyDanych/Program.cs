using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
        które chcesz przetrzymywać to:
        a. Imię,
        b. Nazwisko
        c. Wiek
        d. Płeć (‘m’ albo ‘k’)
        e. PESEL
        f. Numer pracownika (np. 2509324094)
        Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
        */

                Console.WriteLine(" Zadanie 1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.");
        Console.WriteLine(" ");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("Uzupełnij poniżej swoje dane.");
        Console.WriteLine("1. Podaj swoje imię: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Twoje imię to: {firstName}");
        Console.WriteLine(" ");

        Console.WriteLine("2. Podaj swoje nazwisko: ");
        string secondName = Console.ReadLine();
        Console.WriteLine($"Twoje nazwisko to: {secondName}");
        Console.WriteLine(" ");

        Console.WriteLine("3. Podaj swój wiek: ");
        string age = Console.ReadLine();
        int age1 = Int32.Parse(age);
        Console.WriteLine($"Twój wiek to: {age1} lat.");
        Console.WriteLine(" ");

        Console.WriteLine("4. Podaj swoją płeć (M/K): ");
        string sex = Console.ReadLine();
        if (sex == "m" || sex == "M")
        {
            sex = "mężczyzna";
        }
        else if (sex == "k" || sex == "K")
        {
            sex = "kobieta";
        }
        else
        {
            Console.WriteLine("zły wybór");
        }

        Console.WriteLine($"Twoje płeć to : {sex}.");
        Console.WriteLine(" ");

        Console.WriteLine("5. Podaj swój numer Pesel: ");
        string id = Console.ReadLine();
        long id1 = Int64.Parse(id);
        Console.WriteLine($"Twój numer pesel: {id1}.");
        Console.WriteLine(" ");

        Console.WriteLine("6. Podaj swój numer pracownika: ");
        string workerNumber = Console.ReadLine();
        long workerNumber1 = Int32.Parse(workerNumber);
        Console.WriteLine($"Twój numer pracownika to: {workerNumber1}.");
        Console.WriteLine(" ");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");
        Console.WriteLine("Twoje dane to:");
        Console.WriteLine($"Imię: {firstName}");
        Console.WriteLine($"Nazwisko: {secondName}");
        Console.WriteLine($"Wiek: {age1}");
        Console.WriteLine($"Płeć: {sex}");
        Console.WriteLine($"Pesel: {id1}");
        Console.WriteLine($"Numer pracownika: {workerNumber1}");
        Console.WriteLine(" ");

        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        /*
         2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
        odwrotnej kolejności niż zostały zadeklarowane.
        */

        Console.WriteLine(" Zadanie 2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, " +
            "a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.");
        Console.WriteLine(" ");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("Podaj pierszą literę: ");
        string letterA = Console.ReadLine();
        Console.WriteLine("Podaj pierszą literę: ");
        string letterB = Console.ReadLine();
        Console.WriteLine("Podaj pierszą literę: ");
        string letterC = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine($"Podane przez Ciebie litery w odwrotnej kolejności to: {letterC}, {letterB}, {letterA}");
        Console.WriteLine(" ");

        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        /*
                 3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
                    przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
        */

        Console.WriteLine(@" Zadanie 3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
                            przekątnej. Aby obliczyć kwadrat liczby użyj metody Math.Pow()");
        Console.WriteLine(" ");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        string dana1 = "szerokość prostokąta";
        string dana2 = "długość prostokąta";
        Console.WriteLine($"Podaj {dana1} w centymetrach.");
        string width = Console.ReadLine();
        float width1 = Int32.Parse(width);
        Console.WriteLine(" ");
        Console.WriteLine($"Podaj {dana2} prostokąta w centymetrach.");
        string length = Console.ReadLine();
        float length1 = Int32.Parse(length);
        Console.WriteLine(" ");

        Console.WriteLine($"Podane przez Ciebie wymiary to: {width1} i {length1}.");
        Console.WriteLine(" ");

        // obliczam kwadraty podanych liczb
        float width1Square = width1 * width1;
        float length1Square = length1 * length1;

        // obliczam długośc przekątnej
        float diagonalLengthSquare = width1Square + length1Square;
        Console.WriteLine($"Kwadrat przekątnej prostokąta o podanych przez Ciebie wymiarach wynosi: {diagonalLengthSquare}.");
        double diagonalLength = Math.Sqrt(diagonalLengthSquare);
        Console.WriteLine($"Długość przekątnej prostokąta o podanych przez Ciebie wymiarach wynosi: {diagonalLength}.");
        Console.WriteLine(" ");

        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        /*
         4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, 
            a następnie przypiszesz im następujące wartości:
                    a. 10
                    b. Szkoła Dotneta
                    c. 12,5
                    Pamiętaj o użyciu poprawnych typów danych.
        */

        Console.WriteLine(@" Zadanie 4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, 
            a następnie przypiszesz im następujące wartości: \n
                    a. 10 \n
                    b. Szkoła Dotneta \n
                    c. 12,5 \n
                    Pamiętaj o użyciu poprawnych typów danych.");
        Console.WriteLine(" ");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("napisz: 10");
        string a = Console.ReadLine();
        int a1 = Int32.Parse(a);
        Console.WriteLine(" ");

        Console.WriteLine($"Napisz: Szkoła Dotneta.");
        string b1 = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("napisz: 12.5");
        string c = Console.ReadLine();
        Console.WriteLine(" ");

        double c1 = double.Parse(c, CultureInfo.InvariantCulture);
        // float c1 = Int32.Parse(c);  // -   nie wiem jak to przekonwertować :(

        Console.WriteLine($"Twoje wpisane wartości to: {a1}, {b1} i {c1}.");
        Console.WriteLine(" ");

        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        /*      5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj.Imię, nazwisko,
                        numer telefonu, adres email, wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej)
                        i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
                        typDanych.Parse(odpowiedźOdUżytkownika).
        */
 
        Console.WriteLine($"Zadanie 5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj.Imię, nazwisko,\r\n                        numer telefonu, adres email, wzrost, waga(np. 85, 7), itp(postaraj się wymyślić jak najwięcej)\r\n                        i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:\r\n                        typDanych.Parse(odpowiedźOdUżytkownika)");
        Console.WriteLine(" ");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("Uzupełnij poniżej swoje dane.");
        Console.WriteLine("1. Podaj swoje imię: ");
        string firstName2 = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("2. Podaj swoje nazwisko: ");
        string secondName2 = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("3. Podaj swój numer telefonu: ");
        string sphoneNumber2= Console.ReadLine();
        long phoneNumber2 = Int32.Parse(sphoneNumber2);
        Console.WriteLine(" ");

        Console.WriteLine("4. Podaj swoją płeć (M/K): ");
        string sex2 = Console.ReadLine();
        if (sex2 == "m" || sex2 == "M")
        {
            sex2 = "mężczyzna";
        }
        else if (sex2 == "k" || sex2 == "K")
        {
            sex2 = "kobieta";
        }
        else
        {
            Console.WriteLine("zły wybór");
        }
        Console.WriteLine(" ");

        Console.WriteLine("5. Podaj swój adres email,: ");
        string emailAddress2 = Console.ReadLine();
        Console.WriteLine(" ");

        Console.WriteLine("6. Podaj swój wzrost w centymetrach: ");
        string sheigh2 = Console.ReadLine();
        int heigh2 = Int32.Parse(sheigh2);
        Console.WriteLine(" ");

        Console.WriteLine("7. Podaj swoją wagę w kg: ");
        string sweight2 = Console.ReadLine();
        int weight2 = Int32.Parse(sweight2);
        Console.WriteLine(" ");

        Console.WriteLine($"Oto Twoje dane: ");
        Console.WriteLine($"imię            - {firstName2}");
        Console.WriteLine($"nazwisko        - {secondName2}");
        Console.WriteLine($"nr telefonu     - {phoneNumber2}");
        Console.WriteLine($"płeć            - {sex2}");
        Console.WriteLine($"adres e-mail    - {emailAddress2}");
        Console.WriteLine($"wzrost          - {heigh2}");
        Console.WriteLine("Wciśnij dowolny klawisz");
        Console.ReadLine();
        Console.WriteLine("Dobranoc :)");
    }
}