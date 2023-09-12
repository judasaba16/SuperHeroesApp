// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para poder volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var spiderman = new SuperHeroe();


spiderman.Id = 1;
spiderman.Name = "Spider Man";
spiderman.IdentidadSecreta = "piter Parker";
spiderman.Ciudad = "New york";
spiderman.Eshombre = true;

List<SuperPoder>  poderesSpiderman = new List<SuperPoder>();
poderesSpiderman.Add(poderVolar);
poderesSpiderman.Add(superFuerza);
spiderman.SuperPoderes = poderesSpiderman;  


class SuperHeroe
{
    public int Id;
    public string Name;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes; //array!!!
    public bool PuedeVolar;
    public bool Eshombre;
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
}

class SuperV
{

}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}
