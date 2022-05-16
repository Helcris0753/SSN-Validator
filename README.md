# Proceso de instalacion del SSN Validator

## Presentacion
Bienvenido al aplicativo SSN Validator. Este consiste en la validacion de un SSN (Social Security Numer).

Para que un SSN fuese valido debe cumplir los siguientes criterios:

- el numero introducido debe ser de 9 (nueve) digitos
- No introducir letras
- Los primeros tres numeros no deben ser ni 000, 666 o estar entre 900 y 999.
- Los siguientes 2 numeros en el formato no deben ser 00.
___
## Tutorial de instalacioon
Para proceder a instalar el aplicativo, debe estar claro que este tutorial de instalacion es para Linux Ubuntu.

1. Instalar Mono Proyect

Mono Proyect es un comjunto de herramientas libres, basadas en GNU/Linux y compatibles con **.NET**, para darle supone al lenguaje de programacion C# en Ubuntu y demas distribuciones de Linux.

Para proceder a instalar esta, debemos de ejecutar el siguietene comando en nuestra **terminal**

    sudo apt install mono-devel -y

*(la "-y" es para no confirmar la instalacion)*

2. Descarga y descomprimir el repertorio.

Descargamos el repertorio y lo descomprimimos, preferiblemente en el escritoio.

3. Compilar el aplicativo.

Despues de descomprimir, procedemos a dirigirnos a la carpeta interna del proyecto y encontraremos el un archivo de extension **.cs**. 

Procedemos entonces a dar click derecho sobre un espacio vacio en nuestra carpeta. Y hacemos click izquierda a la opcion **Abrir terminal**. Esta accion nos abrira una nueva instancia de un terminal en la carpeta fijada.

Luego, compilamos el aplicativo escribiendo en la terminal:

    mcs Program.cs

4. Ejecucion del aplicativo

Despues de compilar, se nos creara un acrhivo llamado: **Program.exe**. Este es un ejecitable del anterior arhivo con extencion **.cs**.

Linux no tiene compatibilidad con este tipo de archivos, por lo que debemos de ejecutar en la misma terminar el sigueine comando:

    mono hola_mundo.exe

Y ya está, nuestra aplicacion funciona.
