Console.WriteLine("Wybierz program: ");
Console.WriteLine("1. Kalkulator");
Console.WriteLine("2. Konwerter temperatur");
Console.WriteLine("3. Obliczanie średniej ocen");

int choice;
while (!int.TryParse(Console.ReadLine(), out choice))
    Console.WriteLine("Nieprawidłowy wybór, wpisz liczbę: ");

switch (choice)
{
    case 1:
        Calculate();
        break;
    case 2:
        ConvertTemperature();
        break;
    case 3:
        CalculateAverageGrade();
        break;
    default:
        Console.WriteLine("Nieprawidłowy wybór!");
        break;
}

void CalculateAverageGrade()
{
    Console.WriteLine("Wpisz liczbę ocen: ");
    int numberOfGrades;
    while (!int.TryParse(Console.ReadLine(), out numberOfGrades) || numberOfGrades <= 0)
        Console.WriteLine("Nieprawidłowa wartość, wpisz liczbę całkowitą większą od 0: ");

    float average = 0;
    for (int i = 0; i < numberOfGrades; i++)
    {
        Console.WriteLine("Wpisz ocenę " + (i + 1) + ": ");
        int grade;
        while (!int.TryParse(Console.ReadLine(), out grade))
            Console.WriteLine("Nieprawidłowa ocena, wpisz liczbę: ");
        average += grade;
    }
    average /= numberOfGrades;
    Console.WriteLine("Średnia: " + average);
    Console.WriteLine(average >= 3 ? "Uczeń zdał" : "Uczeń nie zdał");
    Console.ReadLine();
}

void ConvertTemperature()
{
    Console.WriteLine("Wpisz c, jeśli chcesz zamienić stopnie Celsjusza na Fahrenheita lub f, jeśli chcesz zamienić stopnie Fahrenheita na Celsjusza: ");
    char unit;
    string? unitInput;
    do
    {
        unitInput = Console.ReadLine();
    }
    while (string.IsNullOrEmpty(unitInput) || !char.TryParse(unitInput, out unit) || (unit != 'c' && unit != 'f'));
    char.TryParse(unitInput, out unit);

    Console.WriteLine("Wpisz temperaturę: ");
    float temperature;
    while (!float.TryParse(Console.ReadLine(), out temperature))
        Console.WriteLine("Nieprawidłowa temperatura, wpisz liczbę: ");

    switch (unit)
    {
        case 'c':
            temperature = temperature * 1.8f + 32;
            break;
        case 'f':
            temperature = (temperature - 32) / 1.8f;
            break;
    }

    Console.WriteLine("Przekonwertowana temperatura wynosi: " + temperature);
}

static void Calculate()
{
    bool isCorrect = true;
    float result = 0;

    do
    {
        isCorrect = true;

        Console.WriteLine("Wprowadź pierwszą liczbę: ");
        float a;
        while (!float.TryParse(Console.ReadLine(), out a))
            Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie: ");

        Console.WriteLine("Wprowadź drugą liczbę: ");
        float b;
        while (!float.TryParse(Console.ReadLine(), out b))
            Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie: ");

        Console.WriteLine("Wybierz operację (+, -, *, /): ");
        char operation;
        string? opInput;
        do
        {
            opInput = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(opInput) || !char.TryParse(opInput, out operation));
        char.TryParse(opInput, out operation);

        switch (operation)
        {
            case '+':
                result = a + b;
                break;
            case '-':
                result = a - b;
                break;
            case '*':
                result = a * b;
                break;
            case '/':
                if (b != 0)
                    result = a / b;
                else
                {
                    Console.WriteLine("Nie można dzielić przez zero!");
                    isCorrect = false;
                }
                break;
            default:
                Console.WriteLine("Nieprawidłowa operacja!");
                isCorrect = false;
                break;
        }
    }
    while (!isCorrect);

    Console.WriteLine("Wynik: " + result);
    Console.ReadLine();
}
