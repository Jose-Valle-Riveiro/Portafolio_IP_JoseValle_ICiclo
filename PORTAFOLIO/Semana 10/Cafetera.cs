using System;

namespace CAFETERA_JV
{
    class Program
    {
        bool lleno;
        int codigo = 1149123;
        int capacidad;
        int disponibles;

        public void HacerCafe(int ingreso) //HACER CAFE
        {

            lleno = true;
            capacidad = ingreso; 
            disponibles = capacidad;

        }

        public void ServirTaza(int cantidad) //SERVIR TAZA
        {

            if (cantidad <= capacidad && cantidad > 0)
            {
                disponibles = disponibles - cantidad;
            }
            else
            {

                Console.WriteLine("ERROR: CANTIDAD INVALIDA. :(");
            }
            Console.WriteLine(disponibles);

        }

        public double ObtenerPorcentaje() //OBTENER PORCENTAJE
        {

            double porcentaje;

            porcentaje = ((double)disponibles / capacidad) * 100;
            
            return porcentaje;

        }

        public void MostrarEstado() //MOSTRAR ESTADO
        {
            double p = ObtenerPorcentaje();
            string texto ="CCODIGO: " + codigo + "    CAPACIDAD: " + capacidad + "    TAZAS SERVIDAS: " + (capacidad - disponibles) + "   PORCENTAJE DE DISPONIBILIDAD: "  + p + "%";
            Console.WriteLine(texto);

        }
        static void Main(string[] args)
        {
            string opcion = "";
            Console.WriteLine("BIENVENIDO: ");
            Console.WriteLine("INGRESE LA CAPACIDAD DE LA CAFETERA: ");
            int cap = Convert.ToInt32(Console.ReadLine());

            //c. para usar funciones
            Program c = new Program();
            //
            //HACER CAFE
            Console.WriteLine("SE ESTA HACIENDO CAFÉ: ");
            c.HacerCafe(cap); 

            do
            {
           
                //SERVIR TAZAS
                Console.WriteLine("INGRESAR TAZAS A SERVIR");
                int tz = Convert.ToInt32(Console.ReadLine());
                c.ServirTaza(tz);




                //MOSTRAR ESTADO
                c.MostrarEstado();

                Console.WriteLine("¿DESEA CONTINUAR?: s/n");
                opcion = Console.ReadLine();

            } while (opcion == "s");

            


        }
    }
}
