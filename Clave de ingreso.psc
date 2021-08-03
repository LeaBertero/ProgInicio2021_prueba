Proceso clave_acceso
	
	definir clave_ingreso como entero;
	
	escribir "Ingrese la contraseña para acceder";
	leer clave_ingreso;
	
	clave_ingreso <- 1234;
	
	si clave_ingreso <> 1234 Entonces
		escribir "La clave es correcta";
	SiNo
		Repetir
			escribir "La clave es incorrecta, ingrese nuevamente";
			leer clave_ingreso;
		Hasta Que clave_ingreso = 1234;
		escribir "Ingreso correcto";
	FinSi
	
	
FinProceso
