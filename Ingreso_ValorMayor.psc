Proceso mayor
	
	definir valor1, valor2, res como entero;
	
	escribir "Ingrese el primer valor que será mayor o igual a 30 y menor o igual a 1000";
	escribir "";
	escribir "Ingresar valor 1";
	leer valor1;

	Repetir
		si valor1 >= 30 Entonces
			escribir "Valor incorrecto";
			escribir "Ingrese nuevamente el valor";
			leer valor1;
		FinSi
	Hasta Que Valor1 <= 1000;	
	
	escribir "El Valor" , " " , valor1, " " , "Es correcto, precione una tecla para ingresar el segundo valor";
	esperar tecla;
	Borrar Pantalla;
	
	escribir "Presione una tecla para ingresar valor 2";
	esperar tecla;
	Borrar Pantalla;
	
	escribir "Ingrese el primer valor que será menor o igual a 700 y meyor o igual a 1500";
	
	escribir "Ingrese valor 2";
	leer valor2;
	
	Repetir
		si valor2  <= 700 Entonces
			escribir "Valor incorrecto";
			escribir "Ingrese nuevamente el valor";
			leer valor2;
		FinSi
	Hasta Que Valor2 >= 1500;	
	
	escribir "El Valor" , " " , valor2, " " , "Es correcto, precione una tecla para continuar";
	esperar tecla;
	
	escribir "Realizar suma de numeros ingresados";
	
	res <- valor1 / valor2;
	
	escribir "El resultado es:", res;
	
	escribir "Presione una tecla para salir";
	esperar tecla;
FinProceso
