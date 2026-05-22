// See https://aka.ms/new-console-template for more information
bool isCorrect = true;

float result = 0;

do
{
    Console.WriteLine("Wprowadź pierwszą liczbę: ");
    float a = int.Parse(Console.ReadLine());
    Console.WriteLine("Wprowadź drugą liczbę: ");
    float b = int.Parse(Console.ReadLine());
    Console.WriteLine("Wybierz operację (+, -, *, /): ");
    char operation = char.Parse(Console.ReadLine());

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