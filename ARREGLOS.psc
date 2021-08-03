SubProceso Suma <- SumadorArreglo ( Arreglo )
	definir suma como entero;
	Suma <- Arreglo[0] + Arreglo[1] + Arreglo[2] + Arreglo[3];
FinSubProceso

Proceso EjemploSumaArreglo
	
	definir i como entero;
	definir arreglo como entero;
	dimension arreglo[4];
	
	Para i<-0 Hasta 3 Con Paso 1 Hacer
		escribir "Ingrese un numero", " -> ", i +1;
		leer arreglo[i];
	FinPara
	escribir "";
	escribir "Presione una tecla para ver el resultado de los numeros ingresados";
	esperar tecla;
	Limpiar Pantalla;
	escribir "La suma es"," = ", SumadorArreglo(Arreglo);
	
FinProceso
