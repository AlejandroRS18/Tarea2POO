namespace Tarea2POO;

public class Persona
{
    // Propiedades públicas
    public string nombre { get; set; }
    public Casa casa { get; set; }

    // Constructor por defecto que inicializa la propiedad nombre y la propiedad casa
    public Persona()
    {
        nombre = "Juan";
        casa = new Casa(150);
    }

    // Constructor que recibe dos parámetros para inicializar las propiedades nombre y casa
    public Persona(string nombre, Casa casa)
    {
        this.nombre = nombre;
        this.casa = casa;
    }

    // Método para cambiar el nombre de la persona
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    // Método para cambiar la casa de la persona
    public void SetCasa(Casa casa)
    {
        this.casa = casa;
    }

    // Método para mostrar los datos de la persona y su casa
    public void MostrarDatos()
    {
        Console.WriteLine($"Mi nombre es {nombre}.");
        casa.MostrarDatos();
        casa.puerta.MostrarDatos();
    }
}
