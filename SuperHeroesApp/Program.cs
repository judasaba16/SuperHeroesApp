using static System.Runtime.InteropServices.JavaScript.JSType;


var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para poder volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var inmortal = new SuperPoder();
inmortal.Nombre = "Inmortal";
inmortal.Descripcion = "No pueden matarlo";
inmortal.Nivel = NivelPoder.NivelTres;

var superRegeneracion = new SuperPoder();
superRegeneracion.Nombre = "Regeneracion";
superRegeneracion.Descripcion = "Regenera cualquier parte de sus cuerpo";
superRegeneracion.Nivel = NivelPoder.NivelTres;

var spiderman = new SuperHeroe();
var aironman = new SuperHeroe();
var hulk = new SuperHeroe();


spiderman.Id = 1;
spiderman.Name = "Spider Man";
spiderman.IdentidadSecreta = "piter Parker";
spiderman.Ciudad = "New york";
spiderman.Eshombre = true;

List<SuperPoder>  poderesSpiderman = new List<SuperPoder>();
poderesSpiderman.Add(poderVolar);
poderesSpiderman.Add(superFuerza);
spiderman.SuperPoderes = poderesSpiderman;
spiderman.UsarSuperPoderes();

aironman.Id = 2;
aironman.Name = "Airon Man";
aironman.IdentidadSecreta = "Tony Stark";
aironman.Ciudad = "New york";
aironman.Eshombre = true;

List<SuperPoder> poderesAironman = new List<SuperPoder>();
poderesAironman.Add(poderVolar);
poderesAironman.Add(superFuerza);
aironman.SuperPoderes = poderesAironman;
aironman.UsarSuperPoderes();

hulk.Id = 3;
hulk.Name = "Hulk";
hulk.IdentidadSecreta = "Bruce Banner";
hulk.Ciudad = "Daytona";
hulk.Eshombre = true;

List<SuperPoder> poderesHulk = new List<SuperPoder>();
poderesHulk.Add(poderVolar);
poderesHulk.Add(superFuerza);
hulk.SuperPoderes = poderesHulk;
hulk.UsarSuperPoderes();

class SuperHeroe
{
    public int Id;
    public string Name;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes; //array!!!
    public bool PuedeVolar;
    public bool Eshombre;

    public SuperHeroe()
    {
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }

    public void UsarSuperPoderes()
    {
        foreach (var item in SuperPoderes)
        {
            Console.WriteLine($"{Name} esta usando el super poder {item.Nombre}!!");
        }
    }
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}

enum NivelPoder
{
    NivelUno,NivelDos,NivelTres,
}
