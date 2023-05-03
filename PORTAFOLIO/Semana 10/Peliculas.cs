
class Pelicula
{
    //PARAMETROS
    string nombre;
    string genero;
    double duracion;
    double calificacion;
    int año;
    string director;

    //METODOS
    public void imprimir(string name, double dura, string gen, double califi, int Año, string dic)//IMPRIMIR
    {
        nombre = name;
        genero = gen;
        duracion = dura;
        calificacion = califi;
        año = Año;
        director = dic;

        Console.WriteLine("---------------------------------");
        Console.WriteLine("NOMBRE: "+nombre);
        Console.WriteLine("DURACION "+duracion + "h");
        Console.WriteLine("GENERO: "+genero);
        Console.WriteLine("CALIFICACION: "+calificacion);
        Console.WriteLine("AÑO: "+año); 
        Console.WriteLine("DIRECTOR: "+director);
        Console.WriteLine("---------------------------------");

    }

    public bool EsPeliculaEpica(double dura)//PELICULA EPICA
    {
        duracion = dura;
        if(duracion > 3)
        {
            return true;
        }
        else 
        {
            return false;
        }

    }

    public void esSimilar(double cali, string gen)
    {
        cali = calificacion;
        gen = genero;
        //PELICULA PARAMETRO
        double califi2 = 8.5;
        string genero2 = "TERROR";

        if (calificacion == califi2 && genero == genero2)    
        {
            Console.WriteLine("ESTA PELICULA SE PARECE AL CONJURO");

        }
        else
        {

        }
    }

    public string Calificacion(double calificacionDada) //CALIFICACION
    {
        calificacion = calificacionDada;
        string cali;
        if(calificacion >= 0 && calificacion <= 2)
        {
            cali = "Muy Mala";
            return cali;
        }
        else if(calificacion > 2 && calificacion <= 5)
        {
            cali = "Mala";
            return cali;
        }
        else if(calificacion > 5 && calificacion <= 7)
        {
            cali = "Regular";
            return cali;
        }
        else if (calificacion > 7 && calificacion <= 8)
        {
            cali = "Buena";
            return cali;
        }
        else if (calificacion > 8 && calificacion <= 10)
        {
            cali = "Excelente";
            return cali;
        }
        else
        {
            return "invalido";
        }
    }
    static void Main(String[] args)
    {

        //PEDIR DATOS




        Console.WriteLine("INGRESE EL NOMBRE DE LA PELICULA: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("INGRESE EL GENERO DE LA PELICULA: ");
        string genero = Console.ReadLine();

        Console.WriteLine("INGRESE LA DURACION DE LA PELICULA: ");
        double duracion = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE LA CALIFICACION DE LA PELICULA: ");
        double califi = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("INGRESE EL AÑO DE LA PELICULA: ");
        int año = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("INGRESE EL DIRECTOR DE LA PELICULA: ");
        string dic = Console.ReadLine();

        //PROCEDIMIENTO

        Pelicula p = new Pelicula();

        p.imprimir(nombre, duracion, genero, califi, año, dic);

        Console.WriteLine(p.Calificacion(califi));

        bool solicitud = p.EsPeliculaEpica(duracion);
        if (solicitud == true)
        {
            Console.WriteLine("ES EPICA");
        }
        else
        {
            Console.WriteLine("NO ES EPICA");
        }

        p.esSimilar(califi, genero);
    }



}
