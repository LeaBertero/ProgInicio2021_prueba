Proceso Prueba_correccion_no_guardado
	
	definir Prod1, Prod2, Prod3, Prod4, Prod5 como caracter;
	definir Pre1, Pre2, Pre3, Pre4, Pre5, Total como Real;
	
	escribir " ***** Nota para el Usuario ***** ";
	escribir "";
	escribir "En este programa podrá cargar hasta 5 productos, no podrá cargar productos con precios cero, lo cual le generará error y deberá cargar nuevamente el precio indicado, según corresponda...";
	escribir "";
	escribir "Presione una tecla para comenzar:";
	esperar tecla;
	//Ingreso de primer producto
	Borrar Pantalla;
	escribir "Ingrese el primer producto";
	leer Prod1;
	Borrar Pantalla;
	//Ingresa precio
	escribir "Ingrese precio";
	leer Pre1;
	
	Si Pre1 > 0 Entonces
		escribir "Ingrese el segundo producto";
		leer Prod2;
	SiNo
		//Vuelve a pedir el ingreso del precio en caso de que sea un valor de cero reiteradas veces 
	     //hasta que el valor sea distinto de cero.
		Repetir
			escribir "Vuelva a ingresar precio 1 por tener una valor nulo";
			leer Pre1;
		Hasta Que Pre1 > 0;
		Borrar Pantalla;
		escribir "Ingrese el segundo producto";
		leer Prod2;
	FinSi
	
	//Ingresa segundo producto
	escribir "Ingrese precio:";
	leer Pre2;
	
	Si Pre2 > 0 Entonces
		escribir "Ingrese el tercer producto";
		leer Prod3;
	SiNo
		//Vuelve a pedir el ingreso del precio en caso de que sea un valor de cero reiteradas veces 
		//hasta que el valor sea distinto de cero.
		Repetir
			escribir "Vuelva a ingresar precio 2 por tener una valor nulo";
			leer Pre2;
		Hasta Que Pre2 > 0;
		Borrar Pantalla;
		escribir "Ingrese el tercer producto";
		leer Prod3;
	FinSi
	//Ingresa tercer producto
	escribir "Ingrese precio:";
	leer Pre3;
	
	Si Pre3 > 0 Entonces
		escribir "Ingrese el cuarto producto";
		leer Prod4;
	SiNo
		//Vuelve a pedir el ingreso del precio en caso de que sea un valor de cero reiteradas veces 
		//hasta que el valor sea distinto de cero.
		Repetir
			escribir "Vuelva a ingresar precio 3 por tener una valor nulo";
			leer Pre3;
		Hasta Que Pre3 > 0;
		Borrar Pantalla;
		escribir "Ingrese el cuarto producto";
		leer Prod4;
	FinSi
	//Ingresa cuarto producto
	escribir "Ingrese precio:";
	leer Pre4;
	
	Si Pre4 > 0 Entonces
		escribir "Ingrese el quinto producto";
		leer Prod5;
	SiNo
		//Vuelve a pedir el ingreso del precio en caso de que sea un valor de cero reiteradas veces 
		//hasta que el valor sea distinto de cero.
		Repetir
			escribir "Vuelva a ingresar precio 4 por tener una valor nulo";
			leer Pre4;
		Hasta Que Pre4 > 0;
		Borrar Pantalla;
		escribir "Ingrese el quinto producto";
		leer Prod5;
	FinSi
	//Ingresa quinto producto
	escribir "Ingrese precio:";
	leer Pre5;
	
	Si Pre5 > 0 Entonces
		escribir "Mostrar lista de productos con sus precios y total";
		escribir "....";
		escribir "Producto 1"," - ", Prod1;
		escribir "Precio", " - ", Pre1;
		escribir "------------------------";
		escribir "Producto 2", " - ", Prod2;
		escribir "Precio", " - ", Pre2;
		escribir "-------------------------";
		escribir "Producto 3", " - ",Prod3;
		escribir "Precio", " - ", Pre3;
		escribir "-------------------------";
		escribir "Producto 4", " - ", Prod4;
		escribir "Precio"," - ", Pre4;
		escribir "-------------------------";
		escribir "Producto 5", " - ",Prod5;
		escribir "Precio", " - ", Pre5;
	SiNo
		//Vuelve a pedir el ingreso del precio en caso de que sea un valor de cero reiteradas veces 
		//hasta que el valor sea distinto de cero.
		Repetir
			escribir "Vuelva a ingresar precio 5 por tener una valor nulo";
			leer Pre5;
		Hasta Que Pre5 > 0;
		Borrar Pantalla;
		escribir "";
		escribir "Mostrar lista de productos con sus precios y total";
		escribir "....";
		escribir "Producto 1"," - ", Prod1;
		escribir "Precio", " - ", Pre1;
		escribir "------------------------";
		escribir "Producto 2", " - ", Prod2;
		escribir "Precio", " - ", Pre2;
		escribir "-------------------------";
		escribir "Producto 3", " - ",Prod3;
		escribir "Precio", " - ", Pre3;
		escribir "-------------------------";
		escribir "Producto 4", " - ", Prod4;
		escribir "Precio"," - ", Pre4;
		escribir "-------------------------";
		escribir "Producto 5", " - ",Prod5;
		escribir "Precio", " - ", Pre5;
		escribir "-------------------------";
	FinSi
	//muestra total final
	Total <- Pre1 + Pre2 + Pre3 + Pre4 + Pre5;
	escribir "";
	escribir "Su total es de", "  ", "$"," ... ",Total;
	escribir "";
	escribir " ********** GRACIAS POR SU VISITA, LO ESPERAMOS NUEVAMENTE ********** ";
FinProceso
