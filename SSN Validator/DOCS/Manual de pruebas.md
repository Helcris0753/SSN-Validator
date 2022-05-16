# Test Manual

This testing manual is intended to show the tests that will be used to validate the inputs. These tickets must meet the following requirements to be considered valid:

1. The number entered must be 9 (nine) digits

If a 9-digit number is not entered, a message appears on the screen indicating that the number does not have 9 digits and asking again to enter a number again.

For example:
~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 12345678

Codigo invalidado!
Verifique que el numero introducido posee exactamente 9 digitos.

Por favor, introduzca su SSN: 
~~~
The same will happen if you enter a number greater than 9 digits:

~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 1234567899

Codigo invalidado!
Verifique que el numero introducido posee exactamente 9 digitos.
Por favor, introduzca su SSN: 
~~~

2. Do not enter letters

If we enter letters, we will be alerted to this.
~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 1234567899

Codigo invalidado!
Verifique que el numero introducido no posee letras.

Por favor, introduzca su SSN: 
~~~
3. The first three numbers must not be 000, 666 or between 900 and 999.

If the first three numbers do not satisfy the requirement, we will be alerted to this.

~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 0004567899

Codigo invalidado!
Los tres primeros numeros no pueden ser ni '000', ni '666' o estar entre '900' y '999'.

Por favor, introduzca su SSN: 
~~~
4. The next 2 numbers in the format must not be 00.

If the numbers 4 and 5 form the number '00', it will be displayed to alert you to this:

~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 1230067899

Codigo invalidado!
Los numeros en la posicion 4 y 5 no pueden ser a la vez '0', formando asi el codigo: '00'.

Por favor, introduzca su SSN: 
~~~
---
Note that error alerts are cumulative. That is, if an entry has multiple errors.

For example:

~~~
BIenvenido al SSN Validator.
Por favor, introduzca su SSN: 00000A7899

Codigo invalidado!

Verifique que el numero introducido posee exactamente 9.

Verifique que el numero introducido no posee letras.

Los tres primeros numeros no pueden ser ni '000', ni '666' o estar entre '900' y '999'

Los numeros 4 y 5 no pueden ser a la vez '0', formando asi el codigo: '00'.

Por favor, introduzca su SSN: 
~~~
