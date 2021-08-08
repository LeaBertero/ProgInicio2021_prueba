Proceso Dimensiones_pre_prod
	
	definir producto como caracter;
	Dimension  producto[3];
	
	definir precio como real;
	Dimension  precio[3];
	
	definir total como real;
	
	definir contador como entero;
	
	Para contador<-0 Hasta 2 Con Paso 1 Hacer
		escribir "Ingrese producto", " N° ", contador +1;
		leer producto[2];
		
		escribir "Ingrese precio", " N° ", contador +1;
		leer precio[2];
	FinPara
	
	escribir "Carga de producto finalizado, presione una tecla para ver el total";
	
	total <- 0;
	
	total <- precio[2] + precio[2] + precio[2];
	
	escribir "La suma total es de $", " ", total;
	
FinProceso
