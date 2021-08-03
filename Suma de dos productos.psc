Proceso SUMA_DE_DOS_PORODUCTOS
	
	Definir prod1, prod2 como caracter;
	definir pre1, pre2, total como entero;
	
	escribir "bienvenido al sistema de carga de productos, para iniciar precione una tecla";
	esperar tecla;
	Borrar Pantalla;
	escribir "Ingrese primer producto:";
	leer prod1;
	escribir "Ingrese precio:";
	leer pre1;
	
	pre1 <- 0;
	
	Si pre1 > 0 Entonces
		Escribir "Ingreso correcto:";
		Borrar Pantalla;
		escribir "Ingrese segundo producto";
		leer prod2;
	SiNo
		escribir "Precio incorrecto, ingrese nuevamente:";
		leer pre1;
		escribir "Precio correcto, presione una tecla";
	FinSi
	Esperar Tecla;
	Borrar Pantalla;
	escribir "Ingrese el segundo producto:";
	leer prod2;
	escribir "Ingrese precio:";
	leer pre2;
	
	pre2 <- 0;
	
	Si Pre2 > 0 Entonces
		escribir "Ingreso correcto, presione una tecla para ver total:";
		total <- pre1 + pre2;
		escribir "Su precio final es de..", total;
		escribir "";
		escribir "Gracias por su visita, lo esperamos nuevamente!!";
	SiNo
		Escribir "Precio incorrecto, ingrese nuevamente:";
		leer pre2;
		escribir "Ingreso correcto:";
		escribir "Presione una tecla para ver su precio final";
		esperar tecla;
	FinSi
	Borrar Pantalla;
	total <- pre1 + pre2;
	
	escribir "Sus productos y sus precios";
	escribir Prod1;
	escribir " $ "," ", pre1;
	escribir "---------------------------";
	escribir prod2;
	escribir " $ "," ", pre2;
	escribir "";
	escribir " $ ", " ",total;
	escribir "";
	escribir "Gracias por su visita, lo esperamos nuevamente !!";
	
FinProceso
