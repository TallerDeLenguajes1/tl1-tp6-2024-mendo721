# tl1-tp6-2024-mendo721
# ¿String es una tipo por valor o un tipo por referencia?

En C#, String (cadena de caracteres) es un tipo por referencia. A pesar de que String tiene algunas características que lo hacen comportarse de manera similar a un tipo por valor, como la inmutabilidad (una vez creada una cadena, no puede ser modificada), sigue siendo un tipo por referencia.

# ¿Qué secuencias de escape tiene el tipo string?
\ - Barra invertida: Representa un carácter de barra invertida (\).
' - Comilla simple: Representa un carácter de comilla simple (').
" - Comilla doble: Representa un carácter de comilla doble (").
\n - Nueva línea: Representa un salto de línea (newline).
\r - Retorno de carro: Representa un retorno de carro (carriage return).
\t - Tabulador: Representa un tabulador horizontal.
\b - Retroceso: Representa un carácter de retroceso (backspace).
\f - Avance de página: Representa un avance de página (form feed).
\0 - Nulo: Representa un carácter nulo (\0).

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
El carácter @ convierte la cadena en un literal textual (verbatim string literal), lo que significa que las secuencias de escape no se interpretan. Esto es útil para escribir rutas de archivos o cualquier texto donde se utilizan muchas barras invertidas.
Ejemplo, string verbatimPath = @"C:\Users\NombreUsuario\Documentos";

El carácter $ permite la interpolación de variables y expresiones dentro de una cadena. Las expresiones se colocan entre llaves {} dentro de la cadena, y su valor se inserta en tiempo de ejecución.
Ejemplo, string interpolatedString = $"My name is {name} and I am {age} years old.";