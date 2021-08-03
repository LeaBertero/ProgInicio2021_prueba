Proceso NUM_ESCONDIDO
	
	definir num_ingresado como entero;
	definir num_secreto como entero;
	
	escribir "Ingrese un numero del 1 al 30";
	escribir "El numero ingresado es:";
	leer num_ingresado;
	
	num_secreto <- 23;
	
	si num_ingresado = num_secreto Entonces
		escribir "Numero ingreado es correcto, usted a ganado, felicitaciones !";
	SiNo
		Repetir
			Borrar Pantalla;
			escribir "El numero ingresdo no es el correcto, ingrese nuevamente";
			escribir "El numero ingresado es:";
			leer num_ingresado;
		Hasta Que num_ingresado = num_secreto;
	FinSi
	Borrar Pantalla;
	escribir "Ha adivinado el numero, felicitaciones !";
	
FinProceso
