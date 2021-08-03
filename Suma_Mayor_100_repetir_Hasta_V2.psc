Proceso Suma_mayor_100
	
	definir num1 como entero;
	definir num2 como entero;
	definir res como entero;
	
	escribir "Encuentre un numero que sumando dos digitos, obtenga un resultado igual a 100, siendo que el primer numero sea su edad actual";
	escribir "";
	escribir "Presione una tecla para comenzar";
	esperar tecla;
	
	Repetir
		Borrar Pantalla;
		escribir "Ingrese un numero";
		leer num1;
		escribir "Ingrese otro numero";
		leer num2;
		
		res <- num1 + num2;
		escribir "El resultado es," , " " , res;
		
		si res > 100 Entonces
			escribir "";
			escribir "El resultado es mayor a 100";
		SiNo
			si res = 100 Entonces
				escribir "El resultado es igual a 100";
			SiNo
				escribir "El resultado no es mayor a 100";
			FinSi
			Borrar Pantalla;
			escribir "Presione una tecla para ingresar nuevamente una suma de dos numeros ";
			esperar tecla;
		FinSi
		escribir "El numero es igual a 100, ahora puede salir del programa...";
	Hasta Que res = 100;
	
	escribir "A continuacion presione una tecla";
	esperar tecla;
	Borrar Pantalla;
	
	escribir "Ahora sumando dos numeros, debe obterner un resultado mayor a 100";
	escribir "Presione una tecla para continuar";
	esperar tecla;
	
	Repetir
		Borrar Pantalla;
		escribir "Presione una tecla para ingresar nuevamente una suma de dos numeros ";
		esperar tecla;
		Borrar Pantalla;
		escribir "Ingrese un numero";
		leer num1;
		escribir "Ingrese otro numero";
		leer num2;
		
		res <- num1 + num2;
		escribir "El resultado es," , " " , res;
		
		si res > 100 Entonces
			escribir "";
			escribir "El resultado es mayor a 100";
		SiNo
			si res = 100 Entonces
				escribir "El resultado es igual a 100";
			SiNo
				escribir "El resultado no es mayor a 100";
			FinSi
		FinSi
		escribir "El numero es igual a 100, ahora puede salir del programa...";
	Hasta Que res > 100;
	escribir "Presione una tecla para  seguir";
	esperar tecla;
	Borrar Pantalla;
	
	escribir "Ahora sumando dos numeros, debe obterner un resultado mayor a 100";
	escribir "Presione una tecla para continuar";
	esperar tecla;
	
	Repetir
		Borrar Pantalla;
		escribir "Presione una tecla para ingresar nuevamente una suma de dos numeros ";
		esperar tecla;
		Borrar Pantalla;
		escribir "Ingrese un numero";
		leer num1;
		escribir "Ingrese otro numero";
		leer num2;
		
		res <- num1 + num2;
		escribir "El resultado es," , " " , res;
		
		si res > 100 Entonces
			escribir "";
			escribir "El resultado es mayor a 100";
		SiNo
			si res = 100 Entonces
				escribir "El resultado es igual a 100";
			SiNo
				escribir "El resultado no es mayor a 100";
			FinSi
		FinSi
		escribir "El numero es menor a 100, ahora puede salir del programa...";
	Hasta Que res < 100;
	
FinProceso
