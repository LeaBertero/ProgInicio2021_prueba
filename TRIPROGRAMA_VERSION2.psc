Proceso ProgramaTri_Edicion_de_codigo_sin_guardar
	
	///Variables de carga de productos
	definir prod1, prod2 como caracter;
	///variables de precios
	definir pre1, pre2,res como real;
	///variable de segun opcion
	definir opcion como entero;
	///variables de ingreso de dos digitos para una multiplicacion
	definir mult1, mult2,Resmult como real;
	///variables de ingreso de usuarios
	definir usuario1, usuario2 Como Caracter;
	///Variables para division
	definir div1, div2, Resdiv como real;
	
	escribir "Bienvenido al programa, dentro de este programa tiene 3 subprogramas a elegir, entre ellos:";
	escribir "";
	///Menu de opciones para el usuario
	escribir "1) - Carga de dos productos";
	escribir "2) - Repeticion de carga de nombres";
	escribir "3) - Multiplicación de dos numeros";
	escribir "";
	escribir "A CONTINUACIÓN SELECCIONE UNA OPCION DE LA LISTA DE MENÚ";
	escribir "";
	escribir "Presione una tecla";
	esperar tecla;
	Borrar Pantalla;
	escribir "Ingrese la opcion que desee a continuacion";
	escribir "";
	///Menu de opciones para el usuario
	escribir "Opcion 1 - Carga de dos productos";
	escribir "Opcion 2 - Repeticion de carga de nombres";
	escribir "Opcion 3 - Multiplicación de dos numeros";
	escribir "";
	///opcion de salida
	escribir "Opcion 9 - Salir";
	escribir "";
	///usuario selecciona opcion de subprograma segun preferencia
	escribir "La opcion elegida es:";
	leer opcion;
	
	Repetir
		Segun opcion Hacer
			1:
				Borrar Pantalla;
				escribir "Ha ingresado a Opcion 1 = Carga de 2 productos, a continuación ingrese sus productos:";
				escribir "";
				escribir "Presione una tecla";
				esperar tecla;
				Borrar Pantalla;
				escribir "Ingrese producto 1";
				leer prod1;
				escribir "";
				escribir "Ingrese precio1";
				leer pre1;
				si pre1 > 0 Entonces
					Borrar Pantalla;
					escribir "Ingrese producto 2";
					leer prod2;
					escribir "Ingrese precio 2 ";
					leer pre2;
					escribir "";
					escribir "Para ver el resultado de sus productos, presione una tecla";
					esperar tecla;
					res <- pre1 + pre2;
					escribir "Su resultado es", " ", res;
					escribir "";
					escribir "Presione una tecla para continuar";
					esperar tecla;
				SiNo
					Repetir
						escribir "Ingrese nuevamente precio 1, por tener un valor a cero...";
						escribir "Su precio es de:";
						leer pre1;
					Hasta Que pre1 >0;
					Borrar Pantalla;
					escribir "Ingrese producto 2";
					leer prod2;
					escribir "";
					escribir "Ingrese precio 2";
					leer pre2;
					si pre2 > 0 entonces 
						escribir "Presione una tecla para ver el resultado de sus productos";
						esperar tecla;
						res <- pre1 + pre2;
						escribir "Su resultado es de:", res;
					SiNo
						Repetir
							escribir "Ingrese nuevamente precio 2, por tener un valor de cero";
							escribir "Ingrese precio 2";
							escribir "Su precio es de:";
							leer pre2;
						Hasta Que pre2 > 0;
						escribir "Presione una tecla para ver el resultado de sus productos:";
						esperar tecla;
						res <- pre1 + pre2;
						escribir "Su resultado es:"," ", res;
						escribir "";
						escribir "Carga de productos, ha finalizado, presione una tecla para continuar...";
						esperar tecla;
					FinSi
				FinSi
				Borrar Pantalla;
				escribir "Ingrese la opcion que desee a continuacion";
				escribir "";
				escribir "Opcion 1 - Carga de dos productos";
				escribir "Opcion 2 - Repeticion de carga de nombres";
				escribir "Opcion 3 - Multiplicación de dos numeros";
				escribir "";
				escribir "Opcion 9 - Salir";
				escribir "";
				escribir "La opcion elegida es:";
				leer opcion;
			2:
				Borrar Pantalla;
				escribir "Ha ingresado en CARGA DE NOMBRES, presione una tecla para comenzar...";
				esperar tecla;
				
				Repetir
					Borrar Pantalla;
					escribir "Ingrese su nombre";
					leer usuario1;
					escribir "Hola", " ", usuario1, " ", "Como estás hoy?";
					escribir "";
					escribir usuario1, " ", "Responde: Estoy muy bien, gracias por preguntar, usted? =D";
					escribir "";
					escribir "Respuesta: Que le importa.. jajaja";
					escribir "";
					escribir usuario1, " " , "Dice.. "," ", "No te doy otra nomas por que...";
					escribir "Presione una tecla para ingresar otro nombre...";
					
					Esperar Tecla;
					Borrar Pantalla;
					
					Borrar Pantalla;
					escribir "ingrese otro nombre ";
					leer usuario2;
					escribir "Hola", " ", usuario2, " ", "Como esta usted?";
					escribir usuario2, "Tampoco quiere responder.. =( ";
					escribir "";
					escribir "Si desea agregar otro nombre, presione ENTER, de lo contrario presione 9 para SALIR";
					escribir "";
					escribir "La opcion elegida es:";
					leer opcion;
				Hasta Que opcion = 9;
				
				Borrar Pantalla;
				escribir "Ha salido del programa CARGA DE NOMBRES, presione una tecla a continuación";
				esperar tecla;
				Borrar Pantalla;
				
				escribir "SELECCIONE UNA OPCION DE MENU";
				escribir "";
				escribir "Opcion 1 - Carga de dos productos";
				escribir "Opcion 2 - Repeticion de carga de nombres";
				escribir "Opcion 3 - Multiplicación de dos numeros";
				escribir "";
				escribir "Opcion 9 -  salir";
				escribir "";
				escribir "La opcion elegida es:";
				leer opcion;
				
			3:
				Repetir
					Borrar Pantalla;
					escribir "Ha ingresado en el sistema de multiplicar o dividir dos numeros";
					escribir "Presione una tecla para ver el menú";
					esperar tecla;
					Borrar Pantalla;
					escribir "MENÚ DE OPCIONES:";
					escribir "";
					escribir "Opcion 1 - Multiplicación";
					escribir "";
					escribir "Opción 2 - División";
					escribir "";
					leer opcion;
					
					
					Segun opcion Hacer
						1:
							escribir "Ha ingresado en opcion 1 - Multiplicación";
							escribir "";
							escribir "Ingrese primer numero";
							leer mult1;
							escribir "";
							escribir "Ingrese segundo numero";
							leer mult2;
							escribir "Presione una tecla para ver el resultado:";
							Esperar Tecla;
							Resmult <- mult1 * mult2;
							Borrar Pantalla;
							escribir "Su resultado es de :", " ", Resmult;
							escribir "";
							escribir "Programa multiplicacion de dos digitos ha finalizado, si desea ingresar a otro programa, seleccione una opcion de menu:";
							escribir "";
							escribir "Presione una tecla para ingresar al menu:";
							esperar tecla;
							Borrar Pantalla;
							escribir "Ingrese una de las opciones:";
							escribir "";
							escribir "Opcion 1 - Carga de dos productos";
							escribir "Opcion 2 - Repeticion de carga de nombres";
							escribir "Opcion 3 - Multiplicación de dos numeros";
							escribir "";
							escribir "Opcion 9 - Salir";
							leer opcion;
						2:
							escribir "Ha ingresado en opcion 2 - Division";
							escribir "";
							escribir "Ingrese primer numero";
							leer div1;
							escribir "";
							escribir "Ingrese segundo numero";
							leer div2;
							escribir "Presione una tecla para ver el resultado:";
							Esperar Tecla;
							Resdiv <- div1 / div2;
							Borrar Pantalla;
							escribir "Su resultado es de :", " ", Resdiv;
							escribir "";
							escribir "Programa multiplicacion de dos digitos ha finalizado, si desea ingresar a otro programa, seleccione una opcion de menu:";
							escribir "";
							escribir "Presione una tecla para ingresar al menu:";
							esperar tecla;
							Borrar Pantalla;
							escribir "Ingrese una de las opciones:";
							escribir "";
							escribir "Opcion 1 - Carga de dos productos";
							escribir "Opcion 2 - Repeticion de carga de nombres";
							escribir "Opcion 3 - Multiplicación de dos numeros";
							escribir "";
							escribir "Opcion 9 - Salir";
							leer opcion;
							
						De Otro Modo:
							escribir "Opcion 1 - Carga de dos productos";
							escribir "Opcion 2 - Repeticion de carga de nombres";
							escribir "Opcion 3 - Multiplicación de dos numeros";
							escribir "";
							escribir "Opcion 9 - Salir";
							leer opcion;
					FinSegun 
				Hasta Que opcion = 9; 
				
				
			9:
				escribir "Ha seleccionado Opcion 9 Finalizar programa, presione una tecla para salir";
				esperar tecla;
				
				De Otro Modo
				Borrar Pantalla;
				escribir "Opcion equivocada seleccione nuevamente una de las opciones de menu:";
				escribir "";
				escribir "Opcion 1 - Carga de dos productos";
				escribir "Opcion 2 - Repeticion de carga de nombres";
				escribir "Opcion 3 - Multiplicación de dos numeros";
				escribir "";
				escribir "Opcion 9 -  Salir";
				escribir "";
				escribir "La opcion elegida es:";
				leer opcion;
				
		FinSegun
	Hasta Que opcion = 9; 
	
	escribir "Ha salido del programa, hasta pronto !";
FinProceso
