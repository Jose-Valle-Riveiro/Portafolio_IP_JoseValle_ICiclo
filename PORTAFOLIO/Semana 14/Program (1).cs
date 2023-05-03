
using System.Globalization;

class Temperatura
{
    /*
     PREGUNTAS:
    ¿QUE REPRESENTAN LAS FILAS? R//LAS FILAS REPRESENTA LA HORA DEL DIA (MAÑANA O TARDE)
    ¿QUE REPRESENTAN LAS COLUMNAS? R//LAS COLUMNAS REPRESENTAN EL DIA DE LA SEMANA
    ¿POR QUE SE UTILIZO ESE VALOR? R//SE UTILIZO DOUBLE PARA ACEPTAR TODOS LOS TIPOS DE DATOS
     */





    static void Main(string[] args)
    {

        double[,] Temp = new double[2, 7];
        string[] tiempo = new string[2];

        tiempo[0] = "Mañana";
        tiempo[1] = "Tarde";

        //CREADOR
        for (int f = 0; f < 2; f++)
        {

            Random rnd = new Random();
        
            for (int c = 0; c < 7; c++)
            {
                Temp[f, c] = rnd.Next(-12, 54);
                
            }
            
        }

        //MOSTRAR EN PANTALLA

        Console.WriteLine("\t" + "LUNES" + "\t" + "MARTES" + "\t" + "MIER" + "\t" + "JUEVES" + "\t" + "VIERNES" + "\t" + "SABADO" + "\t" + "DOMINGO");
        for (int f = 0; f < 2; f++)
        {
            Console.Write(tiempo[f] + ": ");
            for (int c = 0; c < 7; c++)
            {
                Console.Write(Temp[f, c]+ "°C" + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();


        //PROMEDIO
        double Suma, Promedio;

        Suma = Temp[0, 4] + Temp[0, 5] + Temp[0, 6];
        Promedio = Suma / 3;

        Console.WriteLine("EL PROMEDIO DE LOS ULTIMOS 3 DIAS EN LA MAÑANA ES: " + Promedio.ToString("0.00") + "°C");
        Console.WriteLine();

        //TARDE MAS CALUROSA
        double maximo = Temp[0, 0];

        for (int c = 0; c < 7; c++)
        {
            if(maximo < Temp[1, c])
            {
                maximo = Temp[1, c];
            }
        }

        //DETERMINAR EL DIA
        string dia = "";
        if (maximo == Temp[1, 0])
        {
            dia = "LUNES";
        }
        if (maximo == Temp[1, 1])
        {
            dia = "MARTES";
        }
        if (maximo == Temp[1, 2])
        {
            dia = "MIERCOLES";
        }
        if (maximo == Temp[1, 3])
        {
            dia = "JUEVES";
        }
        if (maximo == Temp[1, 4])
        {
            dia = "VIERNES";
        }
        if (maximo == Temp[1, 5])
        {
            dia = "SABADO";
        }
        if (maximo == Temp[1, 6])
        {
            dia = "DOMINGO";
        }


        Console.WriteLine("LA TARDE MAS CALUROSA ES EL DIA " + dia);
        Console.WriteLine() ;

        //MAÑANA MAS CALUROSA
        double minimo = Temp[0, 0];

        for (int c = 0; c < 7; c++)
        {
            if (minimo > Temp[0, c])
            {
                minimo = Temp[0, c];
            }
        }

        //DETERMINAR EL DIA
        
        if (minimo == Temp[0, 0])
        {
            dia = "LUNES";
        }
        if (minimo == Temp[0, 1])
        {
            dia = "MARTES";
        }
        if (minimo == Temp[0, 2])
        {
            dia = "MIERCOLES";
        }
        if (minimo == Temp[0, 3])
        {
            dia = "JUEVES";
        }
        if (minimo == Temp[0, 4])
        {
            dia = "VIERNES";
        }
        if (minimo == Temp[0, 5])
        {
            dia = "SABADO";
        }
        if (minimo == Temp[0, 6])
        {
            dia = "DOMINGO";
        }

        Console.WriteLine("LA MAÑANA MENOS CALUROSA ES EL DIA " + dia);
        Console.WriteLine();

        //DIAS MENORES A 30
        //DETERMINAR
        int conteo = 0;
        for (int c = 0; c < 7; c++)
        {
           
            if (Temp[0, c] < 30 && Temp[1, c] < 30)
            {
                conteo++;
            }
            
        }
        Console.WriteLine("HAY " + conteo + " DIAS CUYA TEMPERATURA ES MENOR A 30°C");
        Console.WriteLine("");

        //TEMPORADA CALUROSA
        double sumatoria = 0;
        for (int f = 0; f < 2; f++)
        {
            
            for (int c = 0; c < 7; c++)
            {
                sumatoria = sumatoria + Temp[f, c];
            }
         
        }

        double Promedio2 = sumatoria / 14;

        if (Promedio2 > 30)
        {
            Console.WriteLine("ES UNA TEMPORADA CALUROSA");
        }
        else
        {
            Console.WriteLine("NO ES UNA TEMPORADA CALUROSA");
        }
    }
}
