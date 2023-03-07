public class Puerta
{
    public string color { get; set; }

    // Constructor por defecto
    public Puerta()
    {
        color = "Café";
    }

    // Método para establecer el color de la puerta
    public void SetColor(string nuevoColor)
    {
        color = nuevoColor;
    }

    // Método para mostrar los datos de la puerta
    public void MostrarDatos()
    {
        Console.WriteLine($"Soy una Puerta, mi color es {color}.");
    }
}

public class Casa
{
    public int area { get; set; }
    public Puerta puerta { get; set; }

    // Constructor que recibe un parámetro de tipo int
    public Casa(int area)
    {
        this.area = area;
        this.puerta = new Puerta();
    }

    // Método para establecer el área de la casa
    public void SetArea(int nuevaArea)
    {
        area = nuevaArea;
    }

    // Método para establecer la puerta de la casa
    public void SetPuerta(Puerta nuevaPuerta)
    {
        puerta = nuevaPuerta;
    }

    // Método para mostrar los datos de la casa
    public void MostrarDatos()
    {
        Console.WriteLine($"Soy una Casa, mi área es {area} m2.");
    }
}
