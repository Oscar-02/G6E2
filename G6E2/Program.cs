using System;

namespace G6E2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROGRAMACION ESTRUCTURADA 07L
             * GUIA 6 EJERCICIO 2
             * 
             * OSCAR ROLANDO CAÑAS VALDIZON
             */

            //Declarar y definir variables (obligacion definirlas)
            int puntos = 0, x = 0, y = 0;
            string coords;
            //VARIABLES PARA CONTROL REPETITIVO Y MANEJO DE ERRORES
            bool error1 = true, error2 = true;
            //Ciclo para solicitar el dato requerido en caso de error
            while(error1 == true)
            {
                try
                {
                    //Solicitud de puntos totales
                    Console.WriteLine("Ingrese el numero de puntos cardinales a procesar...");
                    puntos = int.Parse(Console.ReadLine());
                    //SE DEFINE COMO FALSA LA VARIABLE DE ERROR PARA
                    //CERRAR EL CICLO Y NO SOLICITAR EL DATO DE NUEVO
                    error1 = false;
                }
                catch
                {
                    //SE VUELVE A DEFINIR LA VARIABLE COMO FALSA PARA REINICIAR EL CICLO DE NUEVO
                    error1 = true;
                    //Mensaje de error
                    Console.WriteLine("El valor ingresado debe ser un numero, vuelvalo a intentar...");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear(); //Limpia la consola
                }
            }
            //Ciclo basado en el numero de puntos solicitados
            for (int i = 0; i < puntos; i++)
            {
                //Ciclo para solicitar el dato requerido en caso de error
                while (error2 == true)
                {
                    try
                    {
                        //Solicitud de datos
                        Console.WriteLine("\nIngrese las cordenadas en formato x,y");
                        coords = Console.ReadLine();
                        //Corte de cadena de texto y conversion a enteros int32
                        x = int.Parse(coords.Substring(0, coords.IndexOf(",")));
                        y = int.Parse(coords.Substring((coords.IndexOf(",") + 1)));
                        //SE DEFINE COMO FALSA LA VARIABLE DE ERROR PARA
                        //CERRAR EL CICLO Y NO SOLICITAR EL DATO DE NUEVO
                        error2 = false;
                    }
                    catch
                    {
                        //Mensaje de Error
                        Console.WriteLine("Has ingresado de manera incorrecta los valores, recuerda que debes ingresarlos \nen formato x,y SIN ESPACIOS Y SIN PARENTESIS");
                        //EN ESTE PASO EL USUARIO PUEDE ELEGIR 2 OPCIONES...
                        //1. SI PRESIONA LA TECLA 'R' O 'r' PUEDE VOLVER A INTENTAR INGRESAR LOS DATOS
                        //2. SI PRESIONA LA TECLA 'E' o 'e' CERRARA LA APLICACION
                        Console.WriteLine("PRESIONA 'R' PARA VOLVER A INTENTARLO O 'E' PARA TERMINAR EL PROGRAMA");
                        char key = Console.ReadKey().KeyChar; //Obtiene la tecla presionada (tipo de dato generalizado en char)
                        //CONDICIONALES PARA LAS TECLAS
                        if (key == 'r' || key == 'R') //Para R o r
                        {
                            error2 = true; //DECLARA VERDADERA LA VARIABLE PARA REINICIAR EL CICLO
                            Console.Clear(); //Limpia la consola
                        }
                        else if (key == 'e' || key == 'E') //Para E o e
                        {
                            return; //Cierra el programa sin devolver ningun dato
                        }
                    }
                }
                //Imprime las coordenadas ingresadas
                Console.WriteLine("Las primeras coordenadas ingresadas fueron (" + x + ", " + y + ")...\n");
                //Condicionales para cada cuadrante
                if (x > 0 && y > 0) //CUADRANTE 1
                {
                    Console.WriteLine("El par ordenado ingresado se encuentra en el cuadrante 1");
                }
                else if (x < 0 && y > 0) //CUADRANTE 2
                {
                    Console.WriteLine("El par ordenado ingresado se encuentra en el cuadrante 2");
                }
                else if (x < 0 && y < 0) //CUADRANTE 3
                {
                    Console.WriteLine("El par ordenado ingresado se encuentra en el cuadrante 3");
                }
                else if (x > 0 && y < 0) //CUADRANTE 4
                {
                    Console.WriteLine("El par ordenado ingresado se encuentra en el cuadrante 4");
                }
                else if (x == 0 && y == 0) //CENTRO
                {
                    Console.WriteLine("El par ordenado ingresado se encuentra en el centro de la grafica");
                }
                error2 = true; //DECLARA LA VARIABLE DE ERROR COMO VERDADERA PARA INICIAR EL CICLO while UBICADO EN LA LINEA 48
            }
        }
    }
}