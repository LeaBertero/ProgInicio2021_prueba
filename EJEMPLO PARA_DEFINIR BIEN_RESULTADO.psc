Proceso EJEMPLO_PARA
	
	definir prod como caracter;
	definir pre, total como real;
	definir contador como entero;
	
	contador <-1;
	total <- 0;
	
	Para contador<-1 Hasta 2 Con Paso 1 Hacer
		escribir "Ingrese producto";
		leer prod;
		escribir "Ingrese precio";
		leer pre;
		Borrar Pantalla;
	FinPara
	
	escribir "FIN DE CARGA DE PRODUCTOS, PRESIONE UNA TECLA PARA VER EL TOTAL DE SUS PRODUCTOS CON SUS PRECIOS";
	esperar tecla;
	total <- total + pre;
	escribir "";
	escribir "El total de sus productos es de:", total;
	
FinProceso