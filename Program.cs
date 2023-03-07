namespace Tarea2POO;
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.MostrarDatos();
        persona.SetNombre("Carlos");
        Apartamento apartamento = new Apartamento();
        Casa casa = new Casa(50);
        persona.SetCasa(casa);
        persona.MostrarDatos();
        //persona.casa.SetPuerta("Verde");

    }
}
