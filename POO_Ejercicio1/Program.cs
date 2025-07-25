using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

/*¿Qué es la abstracción?
*Es el proceso de modelar objetos del mundo real en clases, mostrando solo lo necesario y ocultando lo irrelevante.
*
*
*ESTRUCTURA ABSTRACCION :
public class NombreClase
{
    // Atributos públicos
    public TipoDato atributo1;
    public TipoDato atributo2;

    // Métodos públicos (acciones)
    public void Metodo1()
    {
        // Instrucciones
    }

    public void Metodo2()
    {
        // Instrucciones
    }
}

 *ESTRUCTURA ABSTRACCION EN EL PROGRAM:
class Program
{
    static void Main(string[] args)
    {
        // Crear objeto
        NombreClase objeto = new NombreClase();

        // Asignar valores a atributos
        objeto.atributo1 = valor1;
        objeto.atributo2 = valor2;

        // Llamar métodos
        objeto.Metodo1();
        objeto.Metodo2();

        Console.ReadLine();
    }
}
-------------------------¿Qué es el encapsulamiento?
*Es el principio de proteger los datos de una clase haciendo sus atributos private y controlando su acceso a través de 
   métodos públicos (getters/setters o métodos de acción).

ESTRUCTURA ENCAPSULAMIENTO:
public class NombreClase
{
    // Atributos privados
    private TipoDato atributo1;
    private TipoDato atributo2;

    // Constructor
    public NombreClase(TipoDato parametro1, TipoDato parametro2)
    {
        this.atributo1 = parametro1;
        this.atributo2 = parametro2;
    }

    // Métodos públicos
    public void Metodo1()
    {
        // Instrucciones que usan atributo1 o atributo2
    }

    public void Metodo2()
    {
        // Instrucciones que usan atributo1 o atributo2
    }
}  

ESTRUCTURA ENCAPSULAMIENTO EN EL PROGRAM:
class Program
{
    static void Main(string[] args)
    {
        // Crear objeto con constructor
        NombreClase objeto = new NombreClase(valor1, valor2);

        // Llamar métodos públicos
        objeto.Metodo1();
        objeto.Metodo2();

        Console.ReadLine();
    }
}
-------------------¿QUÉ ES LA HERENCIA?
Herencia es un mecanismo que permite crear una clase nueva (hija) a partir de una clase existente (padre), heredando sus atributos y métodos.

ESTRUCTURA HERENCIA
// Clase Padre o Base
public class ClasePadre
{
    // Atributos protected (accesibles desde clases hijas)
    protected TipoDato atributo1;
    protected TipoDato atributo2;

    // Constructor de la clase padre
    public ClasePadre(TipoDato parametro1, TipoDato parametro2)
    {
        this.atributo1 = parametro1;
        this.atributo2 = parametro2;
    }

    // Método común
    public void MetodoComun()
    {
        // Instrucciones
    }

    // Método que puede ser sobrescrito (polimorfismo)
    public virtual void MetodoSobrescribible()
    {
        // Instrucciones base
    }
}

// Clase Hija que hereda
public class ClaseHija : ClasePadre
{
    // Constructor de la clase hija
    public ClaseHija(TipoDato parametro1, TipoDato parametro2) : base(parametro1, parametro2)
    {
        // Inicialización adicional (opcional)
    }

    // Método propio de la hija
    public void MetodoPropio()
    {
        // Instrucciones específicas
    }

    // Sobrescritura de método heredado (polimorfismo)
    public override void MetodoSobrescribible()
    {
        // Instrucciones personalizadas
    }
}

ESTRUCTURA HERENCIA EN EL PROGRAM
class Program
{
    static void Main(string[] args)
    {
        // Crear objeto de la clase hija
        ClaseHija objeto = new ClaseHija(valor1, valor2);

        // Llamar métodos
        objeto.MetodoComun();         // Método heredado
        objeto.MetodoPropio();        // Método propio
        objeto.MetodoSobrescribible();// Método sobrescrito

        Console.ReadLine();           // Pausar consola
    }
}
-----------¿QUÉ ES EL POLIMORFISMO?
Polimorfismo significa “muchas formas”.
En programación, permite que una misma acción (método) se comporte de diferentes maneras dependiendo del objeto que la utilice.

Es decir: un mismo método tiene diferentes comportamientos, dependiendo de la clase que lo implemente.

Esto se logra usando:

La palabra clave virtual en la clase base.

La palabra clave override en la clase hija.

//STRUCTURA POLIMORFISMO (ARCHIVO .cs)
csharp
Copiar
Editar
// Clase base o padre
public class ClasePadre
{
    protected string nombre;

    public ClasePadre(string nombre)
    {
        this.nombre = nombre;
    }

    // Método común
    public void MostrarNombre()
    {
        Console.WriteLine($"Nombre: {nombre}");
    }

    // Método polimórfico
    public virtual void Describir()
    {
        Console.WriteLine("Descripción desde la clase padre.");
    }
}

// Clase hija A
public class ClaseHijaA : ClasePadre
{
    public ClaseHijaA(string nombre) : base(nombre) { }

    public override void Describir()
    {
        Console.WriteLine("Descripción personalizada de ClaseHijaA.");
    }
}

// Clase hija B
public class ClaseHijaB : ClasePadre
{
    public ClaseHijaB(string nombre) : base(nombre) { }

    public override void Describir()
    {
        Console.WriteLine("Descripción personalizada de ClaseHijaB.");
    }
}

//ESTRUCTURA EN EL Program.cs
csharp
Copiar
Editar
class Program
{
    static void Main(string[] args)
    {
        // Creamos objetos de clases hijas, pero usando tipo de la clase padre
        ClasePadre objeto1 = new ClaseHijaA("Objeto A");
        ClasePadre objeto2 = new ClaseHijaB("Objeto B");

        // Llamamos método común (heredado)
        objeto1.MostrarNombre(); // Nombre: Objeto A
        objeto2.MostrarNombre(); // Nombre: Objeto B

        // Llamamos método polimórfico (sobrescrito)
        objeto1.Describir(); // ClaseHijaA: comportamiento distinto
        objeto2.Describir(); // ClaseHijaB: comportamiento distinto

        Console.ReadLine();
    }
}


*/
//EJERCICIOS POLIMORFISMO   

/*EJERCIO ESTACIONES
{
    static void Main(string[] args)
    {
        List<Estacion> estaciones = new List<Estacion>();

        estaciones.Add(new Tropical());
        estaciones.Add(new Templada());
        estaciones.Add(new Desertica());

        foreach(Estacion estacion in estaciones)
        {
            Console.WriteLine(estacion.ClimaActual());
        }
    }
}
EJERCICIO PLANETA
{
    static void Main(string[] args)
    {
        List<Planeta> planetas = new List<Planeta>();

        planetas.Add(new Mercurio());
        planetas.Add(new Saturno());
        planetas.Add(new Neptuno());

        foreach(Planeta planeta in planetas)
        {
            Console.WriteLine(planeta.ObtenerDescripcion());
        }
    }
}
EJERCICIO MAS DIFICIL, SISTEMJUEGOS.CS
                                       class Program
                                       {
                                           static void Main(string[] args)
                                           {
                                               List<JuegoMesa> partidas = new List<JuegoMesa>();

                                               Console.WriteLine("¿Cuantas partidas quieres registrar?");
                                               int cantidad = int.Parse(Console.ReadLine());

                                               for (int i = 0; i < cantidad; i++)
                                               {
                                                   Console.WriteLine($"\nPartida #{i + 1}");
                                                   Console.Write("Tipo de juego(ajedrez / uno / pictionary): ");
                                                   string tipo = Console.ReadLine().ToLower();

                                                   Console.Write("Nombre de la partida: ");
                                                   string nombre = Console.ReadLine();

                                                   Console.Write("Número de jugadores: ");
                                                   int jugadores = int.Parse(Console.ReadLine());

                                                   if (tipo == "ajedrez")
                                                   {
                                                       partidas.Add(new Ajedrez(nombre, jugadores));
                                                   }
                                                   else if (tipo == "uno")
                                                   {
                                                       partidas.Add(new Uno(nombre, jugadores));
                                                   }
                                                   else if (tipo == "pictionary")
                                                   {
                                                       partidas.Add(new Pictionary(nombre, jugadores));
                                                   }
                                                   else
                                                       Console.WriteLine("Tipo de juego no valido. Se omite esta partida");
                                               }

                                               Console.WriteLine("\n Lista de partidas registradas:\n");

                                               foreach(JuegoMesa juego in partidas)
                                               {
                                                   juego.MostrarInfo();
                                                   juego.Instrucciones();
                                                   Console.WriteLine("---------------------");
                                               }

                                               Console.ReadLine();
                                           }
                                       }
EJERCICIO TRABAJADOR
{
    static void Main(string[] args)
    {
        Trabajador dev = new Desarrollador("Carlos");
        Trabajador ui = new Diseñador("Laura");

        dev.Trabajar();
        ui.Trabajar();
    }
}
*/

//TRES PILARES

/*EJERCICIO GESTION PRODUCTOS
                            class Program
                            {

                            }
                      /*
                            {
                                static void Main(string[] args)
                                {
                                    Importado aduana = new Importado("Reloj ROLEX PearlMaster", "Suiza", 80.000, 8.000);
                                    aduana.MostrarDetalle();
                                    aduana.Aduanas();
                                }
                            }

EJERCICIO DIFICIL TRESPILARES/USUARIO.CS
{
    static void Main(string[] args)
    {
        ReservaHotel hotel = new ReservaHotel("Sebastian López", "sebasgal608@gmail.com", 3, 120.000, 0.19);
        hotel.DatosPersonales();
        hotel.Reserva();
    }
}

EJERCICIO PLATAFORMA
{
    static void Main(string[] args)
    {
        Streaming stream = new Streaming("CFK_WOLF14", "Betty la fea");
        stream.Estado();
        stream.reproducir();
    }
}
EJERCICIO ARCHIVO
{
    static void Main(string[] args)
    {
        ArchivoPDF pdf = new ArchivoPDF(3.5);
        pdf.apertura();
        pdf.Buscar();
    }
}
EJERCICIO DOCTOR
{
    static void Main(string[] args)
    {
        Paciente paciente = new Paciente("Juan Camilo Yarce", 47);
        paciente.Presentarse();
        paciente.Atender();
    }

}
EJERCICIO SMARTWATCH
{
    static void Main(string[] args)
    {
        Smartwatch reloj = new Smartwatch("Apple", "Watch");
        reloj.Datos();
        reloj.Pasos();
    }
}
EJERCICIO JUEGO.CS
{
    static void Main(string[] args)
    {
        JuegoCartas poker = new JuegoCartas("Poker");
        poker.Jugando();
        poker.Poker();
    }
}
EJERCICIO PULPO
{
    static void Main(string[] args)
    {
        Pulpo pulpo = new Pulpo("pulpo");
        pulpo.Nadar();
        pulpo.Camuflarse();
    }
}
 EJERCICIO MEDIOTRANSPORTE
{
    static void Main(string[] args)
    {
        Tren tren1 = new Tren(250, "Alta velocidad");
        tren1.MostrarInfo();
        tren1.IniciarRecorrido();
    }
}
*/

/*EJERCICIOS HERENCIA*/
/*
class Program
{
EJERCICIO CONTAR DIGITOS
    static void Main(string[] args)
    {
        Digitos dig = new Digitos(250823);
        Console.WriteLine($"Cantidad de digitos: {dig.Contar()}");
    }
}
EJERCICIO CONTARVOCALES
{
    static void Main(string[] args)
    {
        Vocales vocales = new Vocales("Hola, esto es CIIIIIISHARPPP");
        Console.WriteLine($"Frase original: {vocales.ObtenerFrase()}");
        Console.WriteLine($"Cantidad de vocales: {vocales.Contar()}");
    }
}

 * EJERCICIO MULTIPLOS
{
    static void Main(string[] args)
    {
        Multiplo multi = new Multiplo(20);
        Console.WriteLine($"Número: {multi.ObtenerNumero()}");
        Console.WriteLine(multi.Revisar());
    }
}
EJERCICIOPUNTUACION
{ 
    static void Main(string[] args)
    {
        EvaluateScore evaluar = new EvaluateScore(27);
        Console.WriteLine($"Puntaje: {evaluar.Points()}");
        Console.WriteLine(evaluar.range());
    }
}
EJERCICIO VALIDAR CONTRASEÑA
{
    static void Main(string[] args)
    {
        ClaveSegura validar = new ClaveSegura("1033489199Sebas");
        Console.WriteLine(validar.ObtenerClave());
        Console.WriteLine(validar.validarClave());

    }
}
EJERCICIO TERMOMETRO
{
    static void Main(string[] args)
    {
        Temperatura temp = new Temperatura(38.8);
        Console.WriteLine(temp.TemperaturaActual());
        Console.WriteLine(temp.rango());
    }
}
EJERCICIO RECETA
{
    static void Main(string[] args)
    {
        RecetaVegetariana vegetariana = new RecetaVegetariana("Ensalada Cesar", 25, "Lechuga");
        Console.WriteLine(vegetariana.ObtenerResumen());
        Console.WriteLine(vegetariana.ObtenerIngredientes());

    }
}

EJERCICIO DISPOSITIVE.CS
                        {
                            static void Main(string[] args)
                            {
                                Tablet tablet = new Tablet("Apple");
                                tablet.Encender();
                                tablet.VerVideo();
                            }
                        }

      EJERCICIO ANIMAL MARINO
            {
                static void Main(string[] args)
                {
                    Delfin delfin = new Delfin("delfin");
                    delfin.Nadar();
                    delfin.HacerSonido();
                }
            }
           EJERCICIO VIDEOGAME
            {
                static void Main(string[] args)
                {
                    VideoGame videoGame = new VideoGame("Sebas");
                    videoGame.Play();
                    videoGame.SaveGame();
                }
            }
            EJERCICIO BICYCLE
            {
                static void Main(string[] args)
                {
                    Bicycle bicy = new Bicycle("Green");
                    bicy.Advance();
                    bicy.Pedalear();
                    Console.ReadLine();
                }

            }
            EJERCICIO CUENTA BANCO
            {
                static void Main(string[] args)
                {
                    SavingsAccount account = new SavingsAccount(120.000);
                    account.CheckBalance();
                    account.Interest();

                    Console.ReadLine();
                }
            }
            EJERCICIO INSTRUMENTO
            {
                static void Main(string[] args)
                {
                    Guitar guitar = new Guitar("acoustic");
                    guitar.Tune();
                    guitar.Play();
                    Console.ReadLine();
                }
            }
            EJERCICIO LIBRO/COMIC
            {
                static void Main(string[] args)
                {
                    Comic comic = new Comic("Boulevard", "Romance");
                    comic.ShowTitle();
                    comic.ShowGender();
                    Console.ReadLine();
                }
            }
            EJERCICIO PROGRAMADOR
            {
                static void Main(string[] args)
                {
                    Programmer programmer = new Programmer("Sebastian");
                    programmer.Work();
                    programmer.CodeWrite();
                    Console.ReadLine();
                }
            }
             EJERCICIO DISPOSITIVO
            {
                static void Main(string[] args)
                {
                    Celu cel = new Celu("iPhone", "16 e");
                    cel.Encender();
                    cel.Llamar();
                    Console.ReadLine();
                }
            }
            EJERCICIO ELECTRODOMESTICOS
            {
                static void Main(string[] args)
                {
                    Lavadora lav = new Lavadora("Lg");
                    lav.Encender();
                    lav.LavarRopa();
                    Refrigerador refri = new Refrigerador("Samsung");
                    refri.Encender();
                    refri.Enfriar();
                }
            }
            */



//EJERCICIOS NIVEL 2

/* EJERCICIO TELAR
class Program
{

}
{
    static void Main(string[] args)
    {
        Telar proceso = new Telar(6);
        proceso.EjecutarProceso();
    }
}
EJERCICIO NOTAS MUSICALES
{
    static void Main(string[] args)
    {
        Nota[] notas = new Nota[3];
        notas[0] = new Nota("Do", 4.3);
        notas[1] = new Nota("Sol#", 2.5);
        notas[2] = new Nota("Mi", 3.5);

        foreach(Nota n in notas)
        {
            n.TocarNota();
        }
    }
}
EJERCICIO TAREA
{
    static void Main(string[] args)
    {
        Tarea[] tareas = new Tarea[3];

        tareas[0] = new Tarea("Estudiar C#", true);
        tareas[1] = new Tarea("Sacar la basura", false);
        tareas[2] = new Tarea("Hacer ejercicio", true);

        foreach (Tarea t in tareas)
        {
            t.MostrarEstado();
        }

    }
}
 EJERCICIO IVA
{
    static void Main(string[] args)
    {
        Iva[] iva = new Iva[2];
        iva[0] = new Iva("Paquete de 6 Yogurt", 7.800);
        iva[1] = new Iva("Bolsa de Leche", 4.500);

        foreach(Iva i in iva)
        {
            i.MostrarPrecioIva();
        }
    }
}
EJERCICIO PERSON
{
    static void Main(string[] args)
    {
        Person[] persons = new Person[3];
        persons[0] = new Person("Stiven", 25);
        persons[1] = new Person("Goliat", 14);
        persons[2] = new Person("Victor", 16);


        foreach(Person p in persons)
        {
            p.EvaluarEdad();
        }
    }
}
EJERCICIO CURSOS
{
    static void Main(string[] args)
    {
        Curso[] cursos = new Curso[2];
        cursos[0] = new Curso("Algebra Lineal", "Fermin Valencia", 4);
        cursos[1] = new Curso("Bases de Datos", "Harold Marin", 5);

        foreach(Curso c in cursos)
        {
            c.MostrarCurso();
        }
    }
}
EJERCICIO VEHICULO
{
    static void Main(string[] args)
    {
        Vehiculo[] vehiculos = new Vehiculo[3];
        vehiculos[0] = new Vehiculo("Raptor", "Ford", 2025);
        vehiculos[1] = new Vehiculo("Onix", "Chevrolet", 2023);
        vehiculos[2] = new Vehiculo("Sandero", "Renault", 2024);

        foreach(Vehiculo v in vehiculos)
        {
            v.MostrarVehiculo();
        }
    }
}
EJERCICIO EMPLEADO
{
    static void Main(string[] args)
    {
        Empleado[] empleados = new Empleado[3];
        empleados[0] = new Empleado("Juan", "Practicante", 1750000);
        empleados[1] = new Empleado("Sofia", "Jefe de Costos", 3500000);
        empleados[2] = new Empleado("Sebastian", "Ingeniero de Software", 6500000);

        foreach(Empleado e in empleados)
        {
            e.MostrarEmpleado();
        }
    }
}
EJERCICIO PRODUCTO
{
    static void Main(string[] args)
    {
        Producto[] productos = new Producto[2];

        productos[0] = new Producto("Jabon", 6.000, "Limpieza");
        productos[1] = new Producto("Comida de Perro", 17.000, "Mascotas");

        foreach(Producto p in productos)
        {
            p.MostrarDatos();
        }
    }
}
 EJERCICIO ESTUDIANTE
{
    static void Main(string[] args)
    {
        // Crear estudiantes
        Estudiante[] estudiantes = new Estudiante[2];

        estudiantes[0] = new Estudiante(
            "María",
            "Ingeniería",
            new double[] { 4.5, 4.7, 4.9 }
        );

        estudiantes[1] = new Estudiante(
            "Carlos",
            "Diseño Gráfico",
            new double[] { 3.8, 4.0, 4.2 }
        );

        // Mostrar información con foreach
        foreach (Estudiante e in estudiantes)
        {
            e.MostrarPromedio();
        }

        Console.ReadLine(); // Pausa al final
    }
}
EJERCICIO PERSONA
{
    static void Main(string[] args)
    {
        Persona[] personas = new Persona[2];
        personas[0] = new Persona("Sofia", 25);
        personas[1] = new Persona("Sebastian", 30);

        foreach (Persona p in personas)
        {
            p.Mostrar();
        }

        Console.ReadLine();
    }
}
*/

//EJERCICIOS NIVEL 1
/*EJERCICIO RESTAURANTE
{
    static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante();
        restaurante.nombre = "Mistica Sanuaire du Fego";
        restaurante.tipoComida = "Europea";
        restaurante.ciudad = "El Peñol";

        restaurante.Info();
    }
}
PELICULA
{
    static void Main(string[] args)
    {
        Pelicula pelicula = new Pelicula();
        pelicula.titulo = "Las grandes aventuras de Diomedes en Medellin";
        pelicula.genero = "Violencia, Aventura, Drogras y Sexo";
        pelicula.duracion = 169;

        pelicula.MostrarPelicula();
    }
}
EJERCICIO PERSONA
{ 
    static void Main(string[] args)
    {
        People pipol1 = new People();
        pipol1.nombre = "Juan Andres";
        pipol1.edad = 25;
        pipol1.ciudad = "Medallo pa";

        pipol1.Presentarse();
    }
}
 EJERCICIO CELULAR
{
    static void Main(string[] args)
    {
        Celular celular1 = new Celular();
        celular1.marca = "iPhone";
        celular1.modelo = "Xs";

        celular1.Llamar();
    }
}
 EJERCICIO CANCION
{
    static void Main(string[] args)
    {
        Cancion cancion1 = new Cancion();
        cancion1.titulo = "FANTASMA | AVC";
        cancion1.artista = "Tainy";

        Cancion cancion2 = new Cancion();
        cancion2.titulo = "La Suerte Está Echada";
        cancion2.artista = "Diomedes Díaz el Cacique de la Junta";

        cancion1.Reproducir();
        cancion2.Reproducir();
    }
}
*EJERCICIO MASCOTA
{
    static void Main(string[] args)
    {
        Mascota mascota1 = new Mascota();
        mascota1.nombre = "Teddy";
        mascota1.tipo = "Perro";

        Mascota mascota2 = new Mascota();
        mascota2.nombre = "Oliver";
        mascota2.tipo = "Cangrejo";

        mascota1.Presentarse();
        mascota2.Presentarse();
    }
}
EJERCICIO CARRO
{
   static void Main(string[] args)
    {
        Carro carro1 = new Carro();
        carro1.marca = "Renault";
        carro1.modelo = "9";

        Carro carro2 = new Carro();
        carro2.marca = "Toyota";
        carro2.modelo = "TXL";

        carro1.Arrancar();
        carro2.Arrancar();
    }
}
EJERCICIO LIBRO
{ 
    static void Main(string[] args)
    {
        Libro libro = new Libro();
        libro.Titulo = "Deshojando Margaritas";
        libro.Autor = "Walter Riso";
        libro.yearPublic = 2017;

        libro.InfoLibro();
    }
^}
*/




//EJERCICIOS NIVEL 1
/*EJERCICIO RESTAURANTE
{
    static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante();
        restaurante.nombre = "Mistica Sanuaire du Fego";
        restaurante.tipoComida = "Europea";
        restaurante.ciudad = "El Peñol";

        restaurante.Info();
    }
}
PELICULA
{
    static void Main(string[] args)
    {
        Pelicula pelicula = new Pelicula();
        pelicula.titulo = "Las grandes aventuras de Diomedes en Medellin";
        pelicula.genero = "Violencia, Aventura, Drogras y Sexo";
        pelicula.duracion = 169;

        pelicula.MostrarPelicula();
    }
}
EJERCICIO PERSONA
{ 
    static void Main(string[] args)
    {
        People pipol1 = new People();
        pipol1.nombre = "Juan Andres";
        pipol1.edad = 25;
        pipol1.ciudad = "Medallo pa";

        pipol1.Presentarse();
    }
}
 EJERCICIO CELULAR
{
    static void Main(string[] args)
    {
        Celular celular1 = new Celular();
        celular1.marca = "iPhone";
        celular1.modelo = "Xs";

        celular1.Llamar();
    }
}
 EJERCICIO CANCION
{
    static void Main(string[] args)
    {
        Cancion cancion1 = new Cancion();
        cancion1.titulo = "FANTASMA | AVC";
        cancion1.artista = "Tainy";

        Cancion cancion2 = new Cancion();
        cancion2.titulo = "La Suerte Está Echada";
        cancion2.artista = "Diomedes Díaz el Cacique de la Junta";

        cancion1.Reproducir();
        cancion2.Reproducir();
    }
}
*EJERCICIO MASCOTA
{
    static void Main(string[] args)
    {
        Mascota mascota1 = new Mascota();
        mascota1.nombre = "Teddy";
        mascota1.tipo = "Perro";

        Mascota mascota2 = new Mascota();
        mascota2.nombre = "Oliver";
        mascota2.tipo = "Cangrejo";

        mascota1.Presentarse();
        mascota2.Presentarse();
    }
}
EJERCICIO CARRO
{
   static void Main(string[] args)
    {
        Carro carro1 = new Carro();
        carro1.marca = "Renault";
        carro1.modelo = "9";

        Carro carro2 = new Carro();
        carro2.marca = "Toyota";
        carro2.modelo = "TXL";

        carro1.Arrancar();
        carro2.Arrancar();
    }
}
EJERCICIO LIBRO
{ 
    static void Main(string[] args)
    {
        Libro libro = new Libro();
        libro.Titulo = "Deshojando Margaritas";
        libro.Autor = "Walter Riso";
        libro.yearPublic = 2017;

        libro.InfoLibro();
    }
^}
*/

