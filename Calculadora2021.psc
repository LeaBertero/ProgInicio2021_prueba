Proceso sin_titulo
	
	definir num1, num2, res como real;
	definir opcion como entero;
	
	escribir "Presione una tecla para iniciar la calculadora:";
	esperar tecla;
	
	escribir "";
	
	escribir "Menú de opciones:";
	escribir "";
	escribir "Opcion 1 - Suma";
	escribir "Opcion 2 - Resta";
	escribir "Opcion 3 - Salir";
	escribir "";
	escribir "Ingrese una opcion";
	leer opcion;
	
	Repetir
		Segun opcion Hacer
			1:
				Limpiar Pantalla;
				escribir "Ha ingresado a la opcion 1 - SUMA - Presione una tecla";
				esperar tecla;
				Limpiar Pantalla;
				escribir "Ingrese primer sumando";
				leer num1;
				escribir "Ingrese segundo sumando";
				leer num2;
				res <- num1 + num2;
				escribir "El resultado es", " - ", res;
				escribir "";
				escribir "Ingrese opcion para si desea realizar otra operacion, de lo contrario ingrese opcion 9 para salir del programa";
				leer opcion;
			2:
				Limpiar Pantalla;
				escribir "Ha ingresado a la opcion 1 - RESTA - Presione una tecla";
				esperar tecla;
				Limpiar Pantalla;
				escribir "Ingrese primer sumando";
				leer num1;
				escribir "Ingrese segundo sumando";
				leer num2;
				res <- num1 - num2;
				escribir "El resultado es", " - ", res;
				escribir "";
				escribir "Ingrese una de las opciones si desea realizar una nueva operación, de lo contrario 3 para salir..";
				leer opcion;
			3:
				escribir "Salir del programa? -  Presione una tecla";
				Esperar Tecla;
				Borrar Pantalla;
			De Otro Modo:
				escribir "Opcion equivocada, ingrese nuevamente";
				leer opcion;
		FinSegun
	Hasta Que opcion = 3;
	
	escribir "Ha salido del programa - Presione una tecla";
	esperar tecla;
	escribir "I see you later =D";
	
FinProceso
