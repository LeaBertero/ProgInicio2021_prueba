Proceso sin_titulo
	
	definir i como entero;
	definir opcion como entero;
	
	opcion <- 9;
	i <- 0;
	
	Mientras i = 0 Hacer
		Repetir
			Limpiar Pantalla;
			escribir "Ingrese el valor de I";
			leer i;
			escribir "";
			escribir "Se ha añadido un valor a la variable (I) + 10", " = ", i + 10;
			escribir "";
			escribir "Para volver a repetir la secuencia, presione ENTER, de lo contrario 9 para salir:";
			escribir "";
			escribir "La opción elegida es:";
			leer opcion;
		Hasta Que opcion = 9;
		
	FinMientras
	
FinProceso
