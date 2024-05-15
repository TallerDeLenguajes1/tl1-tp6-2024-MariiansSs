# tl1-tp6-2024-MariiansSs

String es un tipo por referencia. C# usa la palabra clave string para representar el tipo de datos de cadenas de texto. La palabra clave string es un alias para el tipo System.String.

Secuencia de escape de cadena:
\': Comilla simple.
\": Comilla doble.
\ :	Barra diagonal inversa
\0:	Null
\a:	Alerta
\b:	Retroceso
\f:	Avance de página
\n:	Nueva línea
\r:	Retorno de carro
\t:	Tabulación horizontal
\v:	Tabulación vertical
\u:	Secuencia de escape Unicode (UTF-16)
\U:	Secuencia de escape Unicode (UTF-32)
\x:	Secuencia de escape Unicode similar a "\u" excepto con longitud variable

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
    El @ se utiliza para las cadenas literales.  las cadenas literales de cadena textual son más adecuados para cadenas de varias líneas, cadenas que contienen caracteres de barra diagonal inversa o comillas dobles insertadas. Las cadenas textuales conservan los caracteres de nueva línea como parte del texto de la cadena.
    
    El $ se utiliza en la interpolacion de cadenas. Es un tipo de plantilla que permite construir una sola cadena (denominada cadena de resultado) a partir de una cadena que incluye código incrustado. Las expresiones de cadena interpoladas son especialmente útiles para insertar valores en una cadena o para concatenar (unir entre sí) varias cadenas.
