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


//Punto 4

Console.WriteLine("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();
int longCadena = cadena1.Length;
Console.WriteLine($"La longitud de la cadena ingresada es: {longCadena}");
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena2 = Console.ReadLine();
string concatenar = cadena1 + cadena2;
Console.WriteLine($"Las cadenas concatenadas es: {concatenar}");
string subCadena = concatenar.Substring(0, 4);
Console.WriteLine($"La subcadenas de las concatenadas es: {subCadena}");
foreach (char caracter in concatenar)
{
    Console.WriteLine(caracter);
}

Console.WriteLine("Ingrese la palabra a buscar:");
string palabra = Console.ReadLine();
int posicion = concatenar.IndexOf(palabra);
if (posicion != -1){
    Console.WriteLine($"La palabra '{palabra}' se encuntra en la posicion {posicion} de la cadena '{concatenar}'");
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no se encuentra en la cadena '{concatenar}'");
}

string mayusculas = concatenar.ToUpper();
Console.WriteLine($"Cadena en mayúsculas: {mayusculas}");

string minusculas = concatenar.ToLower();
Console.WriteLine($"Cadena en minúsculas: {minusculas}");

Console.WriteLine("Por favor, ingrese una cadena de texto con separadores:");
string cadena11 = Console.ReadLine(); // Ejemplo de entrada: "manzana,banana,naranja,pera"

        
Console.WriteLine("Ingrese el carácter separador:");
String separador = Console.ReadLine(); // Ejemplo de entrada: ','

string[] partes = cadena11.Split(separador);
// Mostrar las partes resultantes por pantalla

Console.WriteLine("Las partes de la cadena son:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

