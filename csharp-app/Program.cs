// See https://aka.ms/new-console-template for more information
Console.WriteLine("Wprowadź pierwszą liczbę: ");
float a = int.Parse(Console.ReadLine());
Console.WriteLine("Wprowadź drugą liczbę: ");
float b = int.Parse(Console.ReadLine());
Console.WriteLine("Wybierz operację (+, -, *, /): ");
char operation = char.Parse(Console.ReadLine());

float result;

switch (operation) {
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
        break;
    default:
        Console.WriteLine("Nieprawidłowa operacja!");
        break;
}
Console.WriteLine("Wynik: " + result);
Console.ReadLine();

}