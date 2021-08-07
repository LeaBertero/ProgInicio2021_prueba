Proceso sin_titulo
	
	
	definir i como entero;
	definir frase Como Caracter;
	
	escribir "ingrese frase";
	leer frase;
	
	Para i<-0 Hasta Longitud(frase)-1 Con Paso 1 Hacer
		escribir SubCadena(frase,i,i);
		esperar tecla;
	FinPara
	
	
FinProceso
