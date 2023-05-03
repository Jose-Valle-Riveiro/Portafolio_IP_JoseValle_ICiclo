class Partido
{
    //PARAMETROS//
    string[] Equipos = new string[8];
    int[] PartidosJ = new int[8];
    int[] PartidosG = new int[8];
    int[] PartidosP = new int[8];
    int[] PartidosE = new int[8];
    int[] GolesF = new int[8];
    int[] GolesC = new int[8];

    string EquipoMasG, EquipoMenosG, EquipoMasP, EquipoMasE;
    double promedio;
    int GolesAFavor, GolesEnContra;
    string EquiposEncima;
    public void PedirNombre()
    {
        bool NombreCorrecto = true;
        for (int i = 0; i < 8; i++)
        {
            do
            {
                Console.WriteLine("INGRRESE EL NOMBRE DEL EQUIPO: " + (i + 1));
                Equipos[i] = Console.ReadLine();

                for (int c = 0; c < i; ++c)
                {
                    if (Equipos[i] == Equipos[c])
                    {
                        Console.WriteLine("ERROR: ESTE NOMBRE ES IDENTICO AL EQUIPO " + (c + 1));
                        NombreCorrecto = false;
                    }
                    else if (Equipos[i] != Equipos[c])
                    {
                        NombreCorrecto = true;
                    }

                }

            } while (NombreCorrecto == false);
                
           
        }

    }
    public void GenerarDatos()
    {
        Random r = new Random();

        ////////////////////////////////////////////////////////////////////////////////////////
        /// GENERAR DATOS                                                                   ///
        ///////////////////////////////////////////////////////////////////////////////////////
        

        //PARTIDOS JUGADOS 
        for (int i = 0; i < 8; i++)
        {
            PartidosJ[i] = r.Next(1, 15);
        }

        //PARTIDOS GANADOS 
        for (int i = 0; i < 8; i++)
        {
            PartidosG[i] = r.Next(1, 15);
        }

        //PARTIDOS EMPATADOS
        for (int i = 0; i < 8; i++)
        {
            PartidosE[i] = r.Next(1, 15);
        }

        //PARTIDOS PERDIDOS
        for (int i = 0; i < 8; i++)
        {
            PartidosP[i] = r.Next(1, 15);
        }

        //GOLES A FAVOR
        for (int i = 0; i < 8; i++)
        {
            GolesF[i] = r.Next(1, 15);
        }

        //GOLES EN CONTRA
        for (int i = 0; i < 8; i++)
        {
            GolesC[i] = r.Next(1, 15);
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        ///                               GENERAR CALCULOS                                   ///
        ///////////////////////////////////////////////////////////////////////////////////////

        //EQUIPOS MAS GOLES
        int maximo = GolesF[0];
        for (int i = 0; i < 8; i++)
        {
            
            if (GolesF[i] > maximo)
            {
                maximo = GolesF[i];
            }
        }
        EquipoMasG = Equipos[maximo];

        //EQUIPO MENOS GOLES
        int minimo = GolesC[0];
        for (int i = 0; i < 8; i++)
        {

            if (GolesC[i] < minimo)
            {
                minimo = GolesC[i];
            }
        }
        EquipoMenosG = Equipos[minimo];

        //PROMEDIO DE PARTIDOS JUGADOS
        double promedio = 0;
        for (int i = 0; i < 8; i++)
        {
            promedio = promedio + PartidosJ[i];
            
        }
        double PromedioT = promedio / 8;

        //EQUIPOS MAS PARTIDOS GANADOS
        int maximo2 = PartidosG[0];
        for (int i = 0; i < 8; i++)
        {

            if (PartidosG[i] > maximo2)
            {
                maximo2 = PartidosG[i];
            }
        }
        EquipoMasP = Equipos[maximo2];

        //GOLES A FAVOR
        int SumaGF = 0;
        for (int i = 0; i < 8; i++)
        {
            SumaGF = SumaGF + GolesF[i];
        }

        //GOLES EN CONTRA
        int SumaGC = 0;
        for (int i = 0; i < 8; i++)
        {
            SumaGC = SumaGF + GolesC[i];
        }

        //EQUIPO CON MAS PARTIDOS GANADOS
        int maximo3 = PartidosE[0];
        for (int i = 0; i < 8; i++)
        {

            if (PartidosE[i] > maximo3)
            {
                maximo3 = PartidosE[i];
            }
        }
        EquipoMasE = Equipos[maximo3];

        //PROMEDIO DE GOLES
        double promedio2 = 0;
        for (int i = 0; i < 8; i++)
        {
            promedio2 = promedio2 + GolesF[i];

        }
        double PromedioT2 = promedio2 / 8;

        
    }
    public void EscribirTabla()
    {
        Console.WriteLine("\t" + "RESULTADOS FINALES" + "\t");

        Console.WriteLine("EQUIPO CON MAS GOLES A FAVOR: ");
        Console.WriteLine("EQUIPO CON MENOS GOLES EN CONTRA: ");
        Console.WriteLine("PROMEDIO DE PARTIDOS JUGADOS");
        Console.WriteLine("EQUIPO CON MÁS PARTIDOS GANADOS");
        Console.WriteLine("TOTAL DE GOLES A FAVOR");
        Console.WriteLine("TOTAL DE GOLES EN CONTRA");
        Console.WriteLine("EQUIPOS CON MÄS PARTIDOS EMPATADOS");
        Console.WriteLine("EQUIPOS CON MAS GOLES QUE LA MEDIA: ");

    }

    static void Main(string[] args)
    {
        Partido p = new Partido();

        p.PedirNombre();    
        //JOSE VALLE Y MARISA MARTINEZ



    }
}