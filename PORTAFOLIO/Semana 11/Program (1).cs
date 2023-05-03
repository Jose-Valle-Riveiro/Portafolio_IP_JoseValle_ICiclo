class Libro
{

    //ATRIBUTOS
    int codigo, NoPaginas, PaginasLeidas = 0;
    string nombre;
    double porcentaje;
    bool leido;

    //METODOS

    public int leer(int PagsLeer)
    {
        int pags;
        pags = NoPaginas - PagsLeer;
        PaginasLeidas = PaginasLeidas + PagsLeer;

        if(PaginasLeidas > NoPaginas)
        {
            Console.WriteLine("ERROR: NO SE PUEDEN LEER MAS PAGINAS");
        }
        else if (PaginasLeidas == NoPaginas)
        {
            leido = true;
        }
        else if (PaginasLeidas < 0)
        {
            leido = false;
        }


         return pags;

        

    }

    public double ObtenerPorcenaje()
    {
        double porciento;

        porciento = 100 - ((((double)NoPaginas - (double)PaginasLeidas) / (double)NoPaginas) * 100);
        porcentaje = porciento;
        return porciento;

    }

    public int ObtenerNoPag()
    {
        int pag;
        pag = NoPaginas - (NoPaginas - PaginasLeidas) ;

        return pag;
    }

    public void MostrarLibro()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("LIBRO: ");
        Console.WriteLine("");

        Console.WriteLine("CODIGO: " +codigo);
        Console.WriteLine("NOMBRE: " + nombre);
        Console.WriteLine("PAGINAS: " + NoPaginas);
        Console.WriteLine("PORCENTAJE DE LECTURA: " + ObtenerPorcenaje() + "%");
        Console.WriteLine("PAGINAS LEIDAS: " + PaginasLeidas);


        Console.WriteLine("");
        Console.WriteLine("-----------------------");


    }

    public void EstadoLibro()
    {
        if(leido == true)
        {
            Console.WriteLine("ESTADO: LEIDO");

        }
        else
        {
            if(PaginasLeidas > 0 && PaginasLeidas < NoPaginas)
            {
                Console.WriteLine("ESTADO: EN PROCESO");
            }
            else if (PaginasLeidas == 0)
            {
                Console.WriteLine("ESTADO: NO LEIDO");
            }
            
        }
        

    }

    public void PedirLibro()
    {
        Console.WriteLine("INGRESE EL NOMBRE DEL LIBRO: ");
        nombre = Console.ReadLine();

        Console.WriteLine("INGRESE EL CODIGO DEL LIBRO: ");
        codigo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("INGRESE EL NUMERO DE PAGINAS DEL LIBRO: ");
        NoPaginas = Convert.ToInt32(Console.ReadLine());







    }
    //MAIN
    static void Main(string[] args)
    {
        
        
        Libro l = new Libro();
        //PEDIR LIBRO
        l.PedirLibro();

        Console.WriteLine("INGRESE LA CANTIDAD DE PAGINAS A LEER: ");
        int pags = Convert.ToInt32(Console.ReadLine());

        //PROCESO
        l.leer(pags);
        Console.WriteLine("NUMERO DE PAGINA: " + l.ObtenerNoPag());
        l.MostrarLibro();
        l.EstadoLibro();

    }

}//CLASE
