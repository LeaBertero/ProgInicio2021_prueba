Proceso Realiza_operaciones_varias_veces
	
	definir num1, num2, res, opcion como entero;
	definir nombre como caracter;
	escribir "Bienvenido al sistema... Vamos a relizar sumas, presione una tecla para comenzar:";
	esperar tecla;
	
	opcion <- 9;
	
	escribir "";
	Repetir
		escribir "Ingrese el primer numero";
		leer num1;
		escribir "Ingrese el segundo numero";
		leer num2;
		res <- num1 + num2;
		escribir "El resultado es:", " ", res;
		escribir "La suma ha finalizado ...";
		escribir "";
		escribir "Ingrese opcion 9 para finalizar, de lo contrario presione cualquier tecla para volver a sumar";
		escribir "";
		escribir "Presione una tecla para continuar..";
		esperar tecla;
		escribir "La opcion elegida es:";
		leer opcion;
	Hasta Que opcion = 9
	
	escribir "Continuar programa:";
	escribir "Presione una tecla para continuar";
	esperar tecla;
	Borrar Pantalla;
	escribir "Presione una tecla para ingresar sus datos personales:";
	esperar tecla;
	Borrar Pantalla;
	escribir "Ingrese Nombre y apellido:";
	leer nombre;
	escribir "Ingreso correcto, ha finalizado el programa, presione una tecla para salir.";
FinProceso
