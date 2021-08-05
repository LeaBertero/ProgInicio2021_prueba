Proceso ejercicio_practica
	
	escribir "Bien dia presione una tecla para iniciar el programa:";
	esperar tecla;
	
	Limpiar Pantalla;
	
	escribir "Para salir del primer bucle - Presione 2";
	escribir "Para salir del primer bucle - Presione 3";
	
	definir num1, num2, opc1, opc2, res como entero;
	escribir "";
	escribir "Presione una tecla para ingresar el primer numero:";
	esperar tecla;
	
	Limpiar Pantalla;
	
	escribir "El numero que debe ingresar debe ser menor a 10";
	esperar tecla;
	
//	num1 <- 10;
	opc1 <- 2;
	opc2 <- 3;
	
	Repetir
		escribir "Ingrese primer numero:";
		leer num1;
		Repetir
			escribir "Ingrese nuevamente primer numero:";
			leer num1;
		Hasta Que num1 <= 10;
		escribir "Para ingresar el segundo numero, ingrese (2)";
		leer opc1;
	Hasta Que opc1 = 2;
	
	Repetir
		escribir "Ingrese segundo numero:";
		leer num2;
		Repetir
			escribir "Ingrese nuevamente segundo numero:";
			leer num2;
		Hasta Que num2 <= 10;
		escribir "Para realizar la suma, ingrese (3)";
		leer opc2;
	Hasta Que opc2 = 3;
	
	escribir "Presione una tecla para sumar los dos numeros:";
	
	res <- num1 + num2;
	escribir "El resultado es:", " - ", res;
	
FinProceso
