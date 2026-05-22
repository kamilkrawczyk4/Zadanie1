Console.WriteLine("Wybierz program: ");
Console.WriteLine("1. Kalkulator");
Console.WriteLine("2. Konwerter temperatur");
Console.WriteLine("3. Obliczanie średniej ocen");
int choice = int.Parse(Console.ReadLine());

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
    int numberOfGrades = int.Parse(Console.ReadLine());
    float average = 0;
    for (int i = 0; i < numberOfGrades; i++)
    {
        Console.WriteLine("Wpisz ocenę " + (i + 1) + ": ");
        int grade = int.Parse(Console.ReadLine());
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
    char unit = char.Parse(Console.ReadLine());
    Console.WriteLine("Wpisz temperaturę: ");
    float temperature = float.Parse(Console.ReadLine());
    switch (unit)
    {
        case 'c':
            temperature = temperature * 1.8f + 32;
            break;
        case 'f':
            temperature = (temperature - 32) / 1.8f;
            break;
        default:
            Console.WriteLine("Nieprawidłowy wybór!");
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
        float a = float.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Wprowadź drugą liczbę: ");
        float b = float.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Wybierz operację (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine() ?? "");

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
                    Console.WriteLine("Nie można dzielić przez zero!");
                isCorrect = false;
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