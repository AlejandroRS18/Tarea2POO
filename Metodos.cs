namespace Tarea2POO;
public class Puerta
{
    public string color { get; set; }

    public Puerta()
    {
        color = "Café";
    }

    public void SetColor(string nuevoColor)
    {
        color = nuevoColor;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Soy una Puerta, mi color es {color}.");
    }
}

public class Casa
{
    public int area { get; set; }
    public Puerta puerta { get; set; }

    public Casa(int area)
    {
        this.area = area;
        this.puerta = new Puerta();
    }

    public void SetArea(int nuevaArea)
    {
        area = nuevaArea;
    }

    public void SetPuerta(Puerta nuevaPuerta)
    {
        puerta = nuevaPuerta;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Soy una Casa, mi área es {area} m2.");
    }
}
