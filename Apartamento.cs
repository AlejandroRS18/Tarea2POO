namespace Tarea2POO;

public class Apartamento : Casa
{
    // Constructor por defecto que llama al constructor de su clase padre con un valor de área de 50
    public Apartamento() : base(50)
    {
    }

    // Método para mostrar los datos del apartamento
    public new void MostrarDatos()
    {
        Console.WriteLine($"Soy un Apartamento, mi área es {area} m2.");
    }
}
