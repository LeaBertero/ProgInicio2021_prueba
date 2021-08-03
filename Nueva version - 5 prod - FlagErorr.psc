Proceso Prod_Pre_FlagError
	
	
	definir Prod1, Prod2, Prod3, Prod4, Prod5 Como Caracter;
	Definir Pre1, Pre2, Pre3, Pre4, Pre5, Total como Real;
	Definir FlagError1, FlagError2, FlagError3, FlagError4, FlagError5 Como Logico;
	
	//Ingreso del primero producto con su respectivo precio
	escribir "Ingrese el primer producto";
	Leer Prod1;
	Borrar Pantalla;
	escribir "ingrese el precio";
	leer Pre1;
	
	Borrar Pantalla;
	
	Repetir
		Si Pre1 > 0 Entonces
			escribir "Ingrese el segundo producto";
			leer Prod2;
			escribir "Ingrese el precio";
			leer Pre2;
			FlagError1 <- Verdadero;
		SiNo
			Escribir  "Ingrese nuevamente precio1 , por tener valor nulo.. ";
			leer Pre1;
			FlagError1 <- Falso;
			Si Pre1 > 0 Entonces
				Escribir "Ingreso correcto, presione una tecla para seguir..";
				esperar tecla;
			SiNo
				escribir "Ingreso incorrecto, vuelva a ingresar";
				leer Pre1;
			FinSi
		FinSi
	Hasta Que Pre1 > 0;
	
	Borrar Pantalla;
	
	//Ingreso del segundo producto con sus respectivo precio
	escribir "Ingrese el segundo producto";
	Leer Prod2;
	Borrar Pantalla;
	escribir "ingrese el precio";
	leer Pre2;
	
	Repetir
		Si Pre2 > 0 Entonces
			escribir "Ingrese el tercer producto";
			leer Prod3;
			escribir "Ingrese el precio";
			leer Pre3;
			FlagError3 <- Verdadero;
		SiNo
			Escribir  "Ingreso incorrecto, vuelva a ingresar.. ";
			leer Pre2;
			FlagError3 <- Falso;
			Si Pre2 > 0 Entonces
				Escribir "Ingreso correcto, presione una tecla para seguir..";
				esperar tecla;
			SiNo
				escribir "Ingreso incorrecto, vuelva a ingresar";
				leer Pre2;
			FinSi
		FinSi
	Hasta Que Pre2 > 0;
	
	Borrar Pantalla;
	
	//Ingreso del tercer producto con su respetivo precio
	escribir "Ingrese el tercer producto";
	Leer Prod3;
	Borrar Pantalla;
	escribir "ingrese el precio";
	leer Pre3;
	
	Repetir
		Si Pre3 > 0 Entonces
			escribir "Ingrese el cuarto producto";
			leer Prod4;
			FlagError3 <- Verdadero;
		SiNo
			Escribir  "Ingreso incorrecto, vuelva a ingresar.. ";
			leer Pre3;
			FlagError3 <- Falso;
			Si Pre3 > 0 Entonces
				Escribir "Ingreso correcto, presione una tecla para seguir..";
				esperar tecla;
			SiNo
				escribir "Ingreso incorrecto, vuelva a ingresar";
				leer Pre3;
			FinSi
		FinSi
	Hasta Que Pre3 > 0;
	
	Borrar Pantalla;
	
	//Ingreso del cuarto producto con su respectivo precio
	escribir "Ingrese el cuarto producto";
	Leer Prod4;
	Borrar Pantalla;
	escribir "ingrese el precio";
	leer Pre4;
	
	Repetir
		Si Pre4 > 0 Entonces
			escribir "Ingrese el quinto producto";
			leer Prod5;
			FlagError4 <- Verdadero;
		SiNo
			Escribir  "Ingreso incorrecto, vuelva a ingresar.. ";
			leer Pre4;
			FlagError4 <- Falso;
			Si Pre4 > 0 Entonces
				Escribir "Ingreso correcto, presione una tecla para seguir..";
				esperar tecla;
			SiNo
				escribir "Ingreso incorrecto, vuelva a ingresar";
				leer Pre4;
			FinSi
		FinSi
	Hasta Que Pre4 > 0;
	
	Borrar Pantalla;
	
	//Ingreso del quinto producto con su respectivo precio
	escribir "Ingrese el quinto producto";
	Leer Prod5;
	Borrar Pantalla;
	escribir "ingrese el precio";
	leer Pre5;
	
	Total <- 0;
	
	Repetir
		Si Pre5 > 0 Entonces
			escribir "Aguarde.. Realizando la sumatoria de sus productos..";
			Total <- Pre1 + Pre2 + Pre3 + Pre4 + Pre5;
			FlagError5 <- Verdadero;
			escribir "";
			//se muestra la lista de productos al final
			escribir "********** LISTA DE PRODUCTOS CON SUS PRESPECTIVOS PRECIOS **********";
			Escribir "";
			escribir "lista de productos adquiridos con sus respectivos precios..";
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
			escribir "Su total es de", "  ", "$"," ... ",Total;
		SiNo
			Escribir  "Ingreso incorrecto, vuelva a ingresar.. ";
			leer Pre5;
			FlagError5 <- Falso;
			Si Pre5 > 0 Entonces
				Escribir "Ingreso correcto, presione una tecla para seguir..";
				esperar tecla;
				escribir "Aguarde... Realizando la sumatoria de sus productos..";
				Total <- Pre1 + Pre2 + Pre3 + Pre4 + Pre5;
				escribir "La suma de sus productos es de.."," $ ", Total;
				escribir "";
				//se muestra la lista de productos al final
				escribir "********** LISTA DE PRODUCTOS CON SUS PRESPECTIVOS PRECIOS **********";
				Escribir "";
				escribir "lista de productos adquiridos con sus respectivos precios..";
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
				escribir "Su total es de", "  ", "$"," ... ",Total;
			FinSi
		FinSi
	Hasta Que Pre5 > 0;
	//finaliza el programa
	Escribir "********** Gracias por su visita, lo esperamos.. NUEVAMENTE !!";
	Escribir "Presione una tecla para finalizar..";
	esperar tecla;
FinProceso
