# SSN (Social Security Number) Validator

Bienvenido al manual de usuario final para **SSN (Social Security Number) Validator** 

Esta aplicacion consiste en dar validacion al numero de seguridad social (SSN, por sus siglas en ingles) y por consecuente mostrarle el numero con un formato prefijado al usuario final.

Dicho formato es el siguiente:

    123-45-6789

Y debe de cumplir con los siguientes requisitos para ser considerado como validado:

- el numero introducido debe ser de 9 (nueve) digitos
- No introducir letras
- Los primeros tres numeros no deben ser ni 000, 666 o estar entre 900 y 999.
- Los siguientes 2 numeros en el formato no deben ser 00.

---
## Uso del aplicativo

En el momento despes de compilar la aplicacion para Linux UBUNTU (como se muestra en el archivo README.MD), procedemos a inicializar la aplicacion, dando dos clicks sobre ella, a lo cual se nos desplegara una ventana como un mensaje de cariñosa bienvenida y mostrandonos debajo que introduscamos un numero de 9 (nueve) digitos.

Despues de introducir dicho numero, procedemos a precionar **ENTER** y acto inmediato nos aparecera el numero con el formato ya planteado.

Ejemplo:

~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 123456789

Codigo validado!
el SSN 123-45-6789 es valido!
~~~
Siguiendo el flujo de ejecucion, el programa preguntara al usuario si desea salir. Informandole de esta forma:

~~~
Desea salir? Y/N:
~~~

Si la respuesta del usuario es afirmativa, el flujo de ejecucion volvera al inicio, dando los calidos saludos e indicandole al usuario que introduza su SSN. De lo contrario, el programa finalizará, despidiendose del usuario.

~~~
FIn del programa. 
Adios!
~~~

Acabe aclarar que si los requisitos para validar el SSN son violentados, se procedera a informar de su error.


