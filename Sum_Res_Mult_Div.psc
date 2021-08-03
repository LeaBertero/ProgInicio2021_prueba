Proceso Ejemplo_Repetir_Operandos_Suma_Resta_Mult_Div
	//Variables de manejo y Menu
	definir opcion como entero;
	
	definir operador1 como real;
	definir operador2 como real;
	definir Res como real;
	
	
	Repetir
		//Muestra Menu Principal
		escribir "MENÚ DE OPCIONES - SI ELIGE UNA OPCION QUE NO ESTE DENTRO DEL MENÚ, EL PROGRAMA LE PEDIRÁ QUE INGRESE NUVAMENTE UNA OPCIÓN VÁLIDA ";
		escribir "";
		escribir "A continuación, seleccione la opción deseada..";
		escribir "";
		escribir "Opcion 1 - *** Sumar ***";
		escribir "Opcion 2 - *** Restar ***";
		escribir "Opcion 3 - *** Multiplicacion ***";
		escribir "Opcion 4 - *** Division ***";
		escribir "";
		escribir "Opcion 9 - *** Salir ***";
		escribir "Presione una tecla para continuar";
		Esperar Tecla;
		Borrar Pantalla;
		escribir "Ingrese una Opcion del Menu";
		leer opcion;
		
		Segun opcion Hacer
			1:
				//SUMAR
				limpiar pantalla;
				escribir "SUMA";
				escribir "Ingrese el primer operador";
				leer operador1;
				escribir "Ingrese segundo operador";
				leer operador2; 
				Res <- operador1 + operador2;
				escribir "Resultado =", Res;
				escribir "Preione una tecla para continuar";
				escribir "";
				escribir "Elija una opcion de Memu";
				esperar tecla;
			2:
				//RESTAR
				escribir "RESTA";
				escribir "Ingrese primer operador";
				leer operador1;
				escribir "Ingrese segundo operador";
				leer operador2;
				Res <- operador1 - operador2;
				escribir "Restultado =" ,Res;
				escribir "Presione una tecla para continuar";
				escribir "";
				escribir "Elija una opcion de Memu";
				esperar tecla;
			3:
				//Multiplicacion
				escribir "MULTIPLICAR";
				escribir "Ingrese primer operador";
				leer operador1;
				escribir "Ingrese segundo operador";
				leer operador2;
				Res <- operador1 * operador2;
				escribir "Restultado =" ,Res;
				escribir "Presione una tecla para continuar";
				escribir "";
				escribir "Elija una opcion de Memu";
				esperar tecla;
				
			4:
				//DIVISION
				escribir "DIVIDIR";
				escribir "Ingrese primer operador";
				leer operador1;
				escribir "Ingrese segundo operador";
				leer operador2;
				Res <- operador1 / operador2;
				escribir "Restultado =" ,Res;
				escribir "Presione una tecla para continuar";
				escribir "";
				escribir "Elija una opcion de Memu";
				esperar tecla;
			9:
			De Otro Modo:
				//error , elegir nuevamente
				escribir "Opcion equivocada elija de nuevo.";
				escribir "Presione una tecla";
				esperar tecla;
		FinSegun
	Hasta Que opcion = 9;
	
	
FinProceso
