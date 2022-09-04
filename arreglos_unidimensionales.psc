Algoritmo arreglos_unidimensionales
	Definir opc Como Entero
	Definir buffer Como Entero
	Definir size Como Entero
	//size<-8  
	Repetir
		Limpiar Pantalla
		Escribir "MENU DE ARREGLOS UNIDIMENSIONALES"
		Escribir "1. Ingresar el tamaño del arreglo"
		Escribir "2. Ingresar valores al arreglo"
		Escribir "3. Imprimir valores del arreglo"
		Escribir "4. Imprimir el valor mas alto del arreglo"
		Escribir "5. Imprimir el valor mas bajo del arreglo"
		Escribir "6. Imprimir la suma total del arreglo"
		Escribir "7. Imprimir el arreglo al reves"
		Escribir "8. Salir"
		
		Escribir "Ingresar opcion del menu: "
		Leer opc
		
		Segun opc Hacer
			1: 
				Escribir "Ingresa el tamaño del arreglo" 
				Leer size 
				Dimension list[size]
				Escribir "Proceso finalizado..."
			2:
				Escribir "Ingresando valores al arreglo"
				Para i<-1 Hasta size Con Paso 1 Hacer
					Escribir "Ingrese un numero para la posición ",i 
					Leer list[i]
				FinPara
				Escribir "Proceso finalizado..."
			3:
				Escribir "Imprimiendo valores del arreglo"
				Para i<-1 Hasta size Con Paso 1 Hacer
					Escribir "Posicion [",i,"]:",list[i] 
				FinPara
			4:
				Escribir "Imprimiendo el valor mas alto del arreglo"
				buffer<-0
				Para i<-1 Hasta size Con Paso 1 Hacer
					Si list[i] es mayor que buffer Entonces
						buffer=list[i]
					FinSi
				FinPara
				Escribir "El numero mayor es: " , buffer
			5:
				Escribir "Imprimiendo el valor mas bajo del arreglo"
				buffer<-0
				Para i<-1 Hasta size Con Paso 1 Hacer
					Si i == 1 Entonces
						buffer=list[i]
					Finsi
					Si list[i] es menor que buffer Entonces
						buffer=list[i]
					FinSi
				FinPara
				Escribir "El numero menor es: " , buffer
			6:
				Escribir "Imprimiendo la suma total del arreglo"
				buffer<-0
				Para i<-1 Hasta size Con Paso 1 Hacer
					buffer= buffer+list[i]
				FinPara
				Escribir "La suma del arreglo es: " , buffer
			7:
				Escribir "Imprimiendo el arreglo al reves"
				Para i<-size Hasta 1 Con Paso -1 Hacer
					Escribir "Posicion [",i,"]:",list[i] 
				FinPara
			8: 
				Escribir "Adios, gracias por usar el programa"
			De Otro Modo:
				Escribir "Opps algo salio mal, ingrese una opcion nuevo"
		Fin Segun
		Esperar Tecla
	Hasta Que opc=8
FinAlgoritmo