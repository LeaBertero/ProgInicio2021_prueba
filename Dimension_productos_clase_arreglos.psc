Proceso arreglo_clase
	
	definir i como entero;
	definir productos como caracter;
	dimension productos[5];
	
	Para i<-0 Hasta 4 Con Paso 1 Hacer
		escribir "Ingrese el nombre del producto", " " , i + 1;
		leer productos[i];
	FinPara
	
	Para i<-0 Hasta 4 Con Paso 1 Hacer
		escribir i + 1, " - " , productos[i];
	FinPara
	

	
	
	
	
	
	
	
FinProceso
