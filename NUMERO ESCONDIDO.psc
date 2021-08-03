Proceso Numero_escondido
	
	definir num1 como entero;
	definir num2 como entero;
	definir intentos como entero;
	
	num1 <- 7;
	num2 <- 5;
	intentos <- 3;
	
	escribir "En esta ocasion se encuentran dos números escondidos que usted deberá advinar, si acierta el primer numero, podrá pasar a adivinar el segundo y el juego finaliza con un premio, de lo contrario si no acierta el primer numero, en 3 oportunidades, no podrá seguir participando";
	escribir "";
	escribir "Comencemoos...";
	escribir "Presione una tecla";
	
	esperar tecla;
	Borrar Pantalla;
	
	escribir "Ingrese primer numero";
	leer num1;
	
	si num1 = 7 Entonces
		escribir "verdadero";
	SiNo
		Repetir
			escribir "Falso";
			escribir "incorrecto, ingrese nuevamente";
			leer num1;
		Hasta Que num1 = 7;
		escribir "Ha acertado, felicitaciones !! -  acerto en ", intentos -1 ;
		escribir "El numero escondido es", " ", num1 ;
	FinSi
	
	escribir "Presione una tecla para ingresar el segundo numero";
	esperar tecla;
	
	Borrar Pantalla;
	escribir "Ingrese segundo numero";
	leer num2;
	
	si num2 <> 5 y intentos = 3 Entonces
		intentos <- -1;
		escribir "Le quedan", " ",intentos ;
	SiNo
		Repetir
			escribir "Falso";
			escribir "incorrecto, ingrese nuevamente";
			leer num2;
		Hasta Que num2 = 5;
		escribir "Ha acertado, felicitaciones !!";
          escribir "";
		escribir "El numero escondido es", " ", num2 ;
		escribir "";
		escribir "Presione una tecla para finalizar programa";
		esperar tecla;
	FinSi
	
	escribir "El programa ha finalizado";
	
FinProceso
