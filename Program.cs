namespace edu.PR.Ejercicio6._0104
{
    internal class Program
    {
        static string rutaTextoUno = "C:\\Users\\Carlos\\Desktop\\Cs1\\PROGRAMACION\\ficheroParaActividades\\TextoUno.txt";
        static void Main(string[] args)
        {

            int opcionUsuario;
            bool cerrarMenu = false;
            do
            {
                opcionUsuario = menuYSeleccionTextoUno();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado volver");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("has indicado modificar línea");
                        modificarLineaTUno();
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado agregar texto en posicion especifica");
                        textoUnoPosicion();
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                        break;
                }



            } while (!cerrarMenu);

        }

        static private void menuTextoUno()
        {
            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = menuYSeleccionTextoUno();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado volver");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("has indicado modificar línea");
                        modificarLineaTUno();
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado agregar texto en posicion especifica");
                        textoUnoPosicion();
                        break;

                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                        break;
                }

            } while (!cerrarMenu);
        }


        static private int menuYSeleccionTextoUno()
        {
            int opcionSeleccionada;
            Console.WriteLine("Elija una opción");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Modificar línea");
            Console.WriteLine("2.Agregar texto en posición especifica");
            Console.WriteLine("_________________________________________");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }

        static private void modificarLineaTUno()
            {
                using (StreamReader sr = new StreamReader(rutaTextoUno))
                {
                    string contenido = sr.ReadToEnd();
                    Console.WriteLine("-----------------------------------------------------------------------");
                    Console.WriteLine("Contenido del archivo:\n" + contenido);

                    Console.WriteLine("-----------------------------------------------------------------------");
                }
                Console.WriteLine("Introduzca el texto que deseas");

                string textoUsuario = Console.ReadLine();
                Console.WriteLine("Introduzca la línea que deseas introducir el texto");
                int numeroLinea = Convert.ToInt32(Console.ReadLine());

                try
                {

                    string[] lineas = File.ReadAllLines(rutaTextoUno);


                    if (numeroLinea >= 1 && numeroLinea <= lineas.Length)
                    {

                        lineas[numeroLinea - 1] = textoUsuario;


                        File.WriteAllLines(rutaTextoUno, lineas);

                        Console.WriteLine("El texto se ha escrito correctamente en la línea especificada.");
                    }
                    else
                    {
                        Console.WriteLine("El número de línea especificado está fuera del rango del archivo.");
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("Error al leer/escribir el archivo: " + e.Message);
                }
            }

        static private void textoUnoPosicion()
        {
            using (StreamReader sr = new StreamReader(rutaTextoUno))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");

            }

            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca la posicion");
            int posicion = Convert.ToInt32(Console.ReadLine());

            try
            {
                string[] filas = File.ReadAllLines(rutaTextoUno);

                if (numLinea >= 1 && numLinea <= filas.Length)
                {
                    string linea = filas[numLinea - 1];

                    if (posicion >= 0 && posicion <= linea.Length)
                    {
                        string nuevaLinea = linea.Insert(posicion, textoUsuario);

                        filas[numLinea - 1] = nuevaLinea;

                        File.WriteAllLines(rutaTextoUno, filas);

                        Console.WriteLine("El texto ha sido introducido correctamente");
                    }
                    else
                    {
                        Console.WriteLine("la posicion indicada no corresponde con el texto");
                    }
                }
                else
                {
                    Console.WriteLine("la línea indicada no corresponde con el texto");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }





        }







    }
    
}
