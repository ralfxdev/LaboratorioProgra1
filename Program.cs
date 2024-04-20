using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.ChildClasses;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

//Laboratorio();
//VideoJuego.listaDeJuegos();


JuegoAccion warzone = new JuegoAccion();
warzone.Titulo = "Call of Duty: Warzone";
warzone.Desarrolladora = "Infinity Ward";
warzone.Calificacion = 9.5;
warzone.AnioLanzamiento = 2020;
warzone.ArmaInicial = "1911";
warzone.ArmaduraInicial = "Chaleco Ligero";
warzone.IncluyeDLC = true;
warzone.MostrarInformacion();
warzone.Disparar();
warzone.Correr();
warzone.Curarse();

JuegoAventura zelda = new JuegoAventura();
zelda.Titulo = "The Legend of Zelda: Breath of the Wild";
zelda.Desarrolladora = "Nintendo";
zelda.Calificacion = 10;
zelda.AnioLanzamiento = 2017;
zelda.Regiones = new string[] { "Hyrule", "Gerudo", "Zora", "Goron" };
zelda.CantidadDeMisiones = 120;
zelda.MundoAbierto = true;
zelda.MostrarInformacion();
zelda.Luchar();
zelda.Saltar();
zelda.abrirCofre();

JuegoDeporte fifa = new JuegoDeporte();
fifa.Titulo = "FIFA 22";
fifa.Desarrolladora = "EA Sports";
fifa.Calificacion = 8.5;
fifa.AnioLanzamiento = 2021;
fifa.TipoDeporte = "Fútbol";
fifa.Equipos = new string[] { "Real Madrid", "Barcelona", "Manchester City", "Juventus" };
fifa.DuracionPartida = 90;
fifa.MostrarInformacion();
fifa.PersonalizarCamiseta();
fifa.Celebrar();
fifa.seleccionarEquipo();
