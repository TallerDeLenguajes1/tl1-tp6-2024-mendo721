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

bool calculadora = true;
while (calculadora)
{
    Console.WriteLine("Calculadora\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n\nIngrese la operacion que desea realizar: ");
    string textoo = Console.ReadLine();
    int operacion;
    int.TryParse(textoo, out operacion);
    Console.WriteLine("Ingrese el primer numero: ");
    string numeroA = Console.ReadLine();
    int numA;
    int.TryParse(numeroA, out numA);
    Console.WriteLine("Ingrese el segundo numero: ");
    string numeroB = Console.ReadLine();
    int numB;
    int.TryParse(numeroB, out numB);
    int resultados;

    switch (operacion)
    {
        case 1: 
            resultados = numA + numB;
            Console.WriteLine($"El resultado de la suma de los dos numeros ingresados es: {resultados}");
            break;
        
        case 2: 
            resultados = numA - numB;
            Console.WriteLine($"El resultado de la resta de los dos numeros ingresados es: {resultados}");
            break;

        case 3: 
            resultados = numA * numB;
            Console.WriteLine($"El resultado de la multiplicacion de los dos numeros ingresados es: {resultados}");
            break;

        case 4: 
            resultados = numA / numB;
            Console.WriteLine($"El resultado de la division de los dos numeros ingresados es: {resultados}");
            break;
        default:
            break;
    }

    Console.WriteLine("Desea realizar otra operacion: 1.si - 0.no");
    string opcion = Console.ReadLine();
    if (opcion == "1")
    {
        calculadora = true;
    }
    else
    {
        calculadora = false;
    }
}
Console.WriteLine("Ingrese un numero");
string text = Console.ReadLine();
int numero;
bool check = int.TryParse(text, out numero);
int abs;
if(numero >= 0){
    abs = numero;
}else{
    abs = -numero;
}
double anguloRadianes = numero * Math.PI / 180;
Console.WriteLine($"El valor absoluto del numero ingresado es: {abs}");
Console.WriteLine($"El cuadrado del numero ingresado es: {numero * numero}");
Console.WriteLine($"La raiz del numero ingresado es: {Math.Sqrt(numero)}");
Console.WriteLine($"El seno es {Math.Sin(anguloRadianes)}");
Console.WriteLine($"El coseno es {Math.Cos(anguloRadianes)}");
Console.WriteLine($"La parte entera de un float es {(int)numero}");

Console.WriteLine("Ingrese dos numeros:");
string numero1 = Console.ReadLine();
string numero2 = Console.ReadLine();
int num1, num2;
int.TryParse(numero1, out num1);
int.TryParse(numero2, out num2);
if (num1 > num2)
{
    Console.WriteLine($"El mayor es {num1}");
    Console.WriteLine($"El menor es {num2}");
}else{
    Console.WriteLine($"El mayor es {num2}");
    Console.WriteLine($"El menor es {num1}");
}