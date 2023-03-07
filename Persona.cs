namespace Tarea2POO;

public class Persona
{
    public string nombre { get; set; }
    public Casa casa { get; set; }
    public Persona()
    {
        nombre = "Juan";
        casa = new Casa(150);
    }

    public Persona(string nombre, Casa casa)
    {
        this.nombre = nombre;
        this.casa = casa;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetCasa(Casa casa)
    {
        this.casa = casa;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Mi nombre es {nombre}.");
        casa.MostrarDatos();
        casa.puerta.MostrarDatos();
    }
}
