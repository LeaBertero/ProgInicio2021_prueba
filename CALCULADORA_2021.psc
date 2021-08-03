Proceso Calculadora
	
	///Variables enteras de operaciones aritmeticas
	definir num1 como real;
	definir num2 como real;
	definir res como real;
	definir opcion como entero;
	definir contador como entero;
	definir clave_acceso como entero;
	
	//	clave_acceso <- 1234;
	escribir "///////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////";
	Escribir  "////////// ESTE PROGRAMA ES UNA CALCULADORA //////////";
	escribir "///////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////";
	escribir "";
	escribir "Bienvenido - A continuación ingrese clave para acceder:";
	escribir "";
	escribir "Ingrese clave";
	leer clave_acceso;
	escribir "La clave ingresada es", " " , clave_acceso;
	si clave_acceso <> 1234 entonces
		Repetir
			escribir " clave incorrecta - Ingrese nuevamente";
			leer clave_acceso;
		Hasta Que clave_acceso = 1234;
		Borrar Pantalla;
		escribir "La clave", " " , clave_acceso, " ", "es correcta";
		escribir "Presione una tecla";
		esperar tecla;
	SiNo
		escribir " ##### La clave", " " , clave_acceso, " ", "es correcta ##### ";
		escribir "";
		escribir "Presione una tecla para iniciar";
		esperar tecla;
	FinSi
	
	Borrar Pantalla;
	
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	Escribir  "////////// ESTE PROGRAMA ES UNA CALCULADORA - BIENVENIDO! - //////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "Presione una tecla";
	esperar tecla;
	Borrar Pantalla;
	escribir "a continuación una cuenta regresiva de 5 segundos.. aguarde !";
	escribir "Presione una tecla";
	esperar tecla;
	escribir "//////////////////////////////////////////////////";
	escribir "//////////////////////////////////////////////////";
	escribir "--------------------------------------------------";
	escribir "Comienza cuenta regresiva, preste atencion !";
	escribir "--------------------------------------------------";
	escribir "//////////////////////////////////////////////////";
	escribir "//////////////////////////////////////////////////";
	contador <- 5;
	contador <- contador -1;
	escribir "";
	///Estructura de cuenta regresiva que da inicio al programa
	escribir "//////////////////////////////////////////////////";
	Para contador <- (-4) Hasta 1 Con Paso 1 Hacer
		escribir " --- El programa comenzara en breve --- ", "Faltan...", " " , contador - 1 ," Segundos... ";
	FinPara
	escribir "//////////////////////////////////////////////////";
	escribir "//////////////////////////////////////////////////";
	escribir "";
	escribir "Presione una tecla para comenzar el programa";
	esperar tecla;
	escribir "";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	Escribir  "////////// ESTE PROGRAMA ES UNA CALCULADORA - BIENVENIDO! - //////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "";
	escribir "Bienvenido a la CALCULADORA - presione una tecla para seleccionar una de las opciones del menú que se encuentra a continuación";
	escribir "";
	escribir "Presione una tecla...";
	esperar tecla;
	
	Borrar Pantalla;
	
	///Menú de opciones
	escribir "--------------------------------------------------";
	escribir "//////////////////////////////////////////////////";
	escribir "Opcion 1 - Suma";
	escribir "Opcion 2 - Resta";
	escribir "//////////////////////////////////////////////////";
	escribir "Opcion 3 - Multiplicación";
	escribir "Opcion 4 - División";
	escribir "//////////////////////////////////////////////////";
	escribir "Opcion 9 - Salir";
	escribir "//////////////////////////////////////////////////";
	escribir "--------------------------------------------------";
	escribir "";
	escribir "Elija una de las opciones";
	leer opcion;
	
	///estructura de repeticion de secuencias de accion
	Repetir
		Segun opcion Hacer
			1:
				///Borra la pantalla
				Borrar Pantalla;
				///Indica que ingresa a la suma, luego de elegir la opcion del menu
				escribir "Ha ingresado a la suma, presione una tecla para iniciar";
				///espera tecla
				esperar tecla;
				Borrar Pantalla;
				///ingreso de primer numero
				escribir "Ingrese el primer numero a sumar";
				leer num1;
				escribir "";
				///ingresa el segundo numero a operar
				escribir "Ingrese segundo numero a sumar";
				leer num2;
				Borrar Pantalla;
				escribir "Presione una tecla para ver el resultado de la suma";
				esperar tecla;
				///suma del ingreso del primer y segundo numero
				res <- num1 + num2;
				escribir "";
				///muestra resultado de operacion
				escribir "El resultado de la suma es:", " " , res;
				escribir "";
				escribir "Presione una tecla para continuar";
				esperar tecla;
				Borrar Pantalla;
				///finaliza la suma y muestra nuevamente menu de opciones
				escribir "Ha finalizado la suma, a continuacion presione enter para elijir otra opcion o 9 para finalizar";
				escribir "";
				escribir "Presione una tecla para continuar";
				
				Esperar Tecla;
				Borrar Pantalla;
				
				///Menu de opciones
				escribir "--------------------------------------------------";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 1 - Suma";
				escribir "Opcion 2 - Resta";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 3 - Multiplicación";
				escribir "Opcion 4 - División";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 9 - Salir";
				escribir "//////////////////////////////////////////////////";
				escribir "--------------------------------------------------";
				escribir "";
				escribir "Elija una de las opciones";
				leer opcion;
			2:
				Borrar Pantalla;
				///Ingresa a la segunda opcion - Resta
				escribir "Ha ingresado a la Resta, presione ua tecla para iniciar";
				esperar tecla;
				Borrar Pantalla;
				///Ingresa primer numero
				escribir "Ingrese el primer numero a restar";
				leer num1;
				escribir "";
				///Ingresa segundo numero
				escribir "Ingrese segundo numero a restar";
				leer num2;
				Borrar Pantalla;
				escribir "Presione una tecla para ver el resultado de la resta";
				esperar tecla;
				/// A resultado se le asigna numero 1 - numero 2
				res <- num1 - num2;
				escribir "";
				///Da el resultado de la resta de los numeros ingresados
				escribir "Su resultado de la resta es:", " " , res;
				escribir "";
				///Finaliza operación y muestra menú, el cual pide ingresar una opcion de menu obligatoriamente
				escribir "Ha finalizado la Resta, a continuacion presione enter para elijir otra opcion o 9 para finalizar";
				escribir "";
				escribir "Presione una tecla para continuar";
				
				Esperar Tecla;
				Borrar Pantalla;
				
				escribir "--------------------------------------------------";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 1 - Suma";
				escribir "Opcion 2 - Resta";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 3 - Multiplicación";
				escribir "Opcion 4 - División";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 9 - Salir";
				escribir "//////////////////////////////////////////////////";
				escribir "--------------------------------------------------";
				escribir "";
				escribir "Elija una de las opciones";
				leer opcion;
			3:
				Borrar Pantalla;
				escribir "Ha ingresado a la Multiplicación, presione ua tecla para iniciar";
				esperar tecla;
				Borrar Pantalla;
				escribir "Ingrese el primer numero a multiplicar";
				leer num1;
				escribir "";
				escribir "Ingrese segundo numero a multiplicar";
				leer num2;
				Borrar Pantalla;
				escribir "Presione una tecla para ver el resultado de la multiplicación";
				esperar tecla;
				res <- num1 * num2;
				escribir "";
				escribir "El resultado de la multiplicación es:", " " , res;
				escribir "";
				escribir "Ha finalizado la multiplicación, a continuacion presione enter para elijir otra opcion o 9 para finalizar";
				escribir "";
				escribir "Presione una tecla para continuar";
				
				Esperar Tecla;
				Borrar Pantalla;
				
				escribir "--------------------------------------------------";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 1 - Suma";
				escribir "Opcion 2 - Resta";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 3 - Multiplicación";
				escribir "Opcion 4 - División";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 9 - Salir";
				escribir "//////////////////////////////////////////////////";
				escribir "--------------------------------------------------";
				escribir "";
				escribir "Elija una de las opciones";
				leer opcion;
			4:	
				Borrar Pantalla;
				escribir "Ha ingresado a la Division, presione ua tecla para iniciar";
				esperar tecla;
				Borrar Pantalla;
				escribir "Ingrese el primer numero a dividir";
				leer num1;
				escribir "";
				escribir "Ingrese segundo numero a dividir";
				leer num2;
				Borrar Pantalla;
				escribir "Presione una tecla para ver el resultado de la división";
				esperar tecla;
				res <- num1 / num2;
				escribir "";
				escribir "Su resultado de la división es:", " " , res;
				escribir "";
				escribir "Ha finalizado la división, a continuacion presione enter para elijir otra opcion o 9 para finalizar";
				escribir "";
				escribir "Presione una tecla para continuar";
				
				Esperar Tecla;
				Borrar Pantalla;
				
				escribir "--------------------------------------------------";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 1 - Suma";
				escribir "Opcion 2 - Resta";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 3 - Multiplicación";
				escribir "Opcion 4 - División";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 9 - Salir";
				escribir "//////////////////////////////////////////////////";
				escribir "--------------------------------------------------";
				escribir "";
				escribir "Elija una de las opciones";
				leer opcion;
			9:
				Borrar Pantalla;
				escribir "Sallir del programa, presione una tecla";
				esperar tecla;
				
			De Otro Modo:
				Borrar Pantalla;
				escribir "No ha seleccionado ninguna opción, seleccione nuevamente";
				escribir "";
				escribir "--------------------------------------------------";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 1 - Suma";
				escribir "Opcion 2 - Resta";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 3 - Multiplicación";
				escribir "Opcion 4 - División";
				escribir "//////////////////////////////////////////////////";
				escribir "Opcion 9 - Salir";
				escribir "//////////////////////////////////////////////////";
				escribir "--------------------------------------------------";
				escribir "";
				escribir "Elija una de las opciones";
				leer opcion;
		FinSegun
	Hasta Que opcion = 9;
	escribir "";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "//////// Ha salido del Programa - See you have a NICE DAY =) //////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "///////////////////////////////////////////////////////////////////////";
	escribir "Presione una tecla para finalizar";
	esperar tecla;
	
FinProceso
