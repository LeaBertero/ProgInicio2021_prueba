Proceso adivine_un_numero
	
	definir numingresado como entero;
	definir intentos como entero;
	definir numsecreto como entero;
	
	numsecreto <- azar (100);
	numsecreto <- 74;
	intentos <- 3;
	
	escribir "Ingrese un numero del 1 al 100";
	escribir "";
	escribir "Ingrese numero";
	leer numingresado;
	
	si numingresado <> numsecreto y intentos = 3 Entonces
		Repetir
			Escribir "Muy alto";
			intentos <- intentos -1;
			escribir "Quedan", " ", intentos, " ", "intentos";
			escribir "";
			escribir "Ingrese nuevamente";
			leer numingresado;
		Hasta Que numingresado = numsecreto; 
	SiNo
		
		Repetir
			escribir "Muy bajo";
			intentos <- intentos -1;
			escribir "Quedan", " ", intentos, " ", "intentos" ;
			escribir "";
			escribir "Ingrese nuevamente";
			leer numingresado;
		Hasta Que numingresado = numsecreto; 
		Borrar Pantalla;
		escribir "Muy bien, ha conseguido adivinar el numero secreto !!";
		escribir "Presione una tecla para finalizar";
		esperar tecla;
	FinSi
	
	
FinProceso
