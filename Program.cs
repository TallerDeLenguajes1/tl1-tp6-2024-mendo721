// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

Console.WriteLine("Ingrese un numero que desee invertir: ");
string texto = Console.ReadLine();
int num;
bool resultado = int.TryParse(texto, out num);

if (resultado)
{
    int aux = 0;
    int digito = 0;
    while (num > 0)
    {
        aux *= 10;
        digito = num % 10;
        aux += digito;
        num /= 10;
    }
    Console.WriteLine($"El invertido del numero ingresado es: {aux}");
}
