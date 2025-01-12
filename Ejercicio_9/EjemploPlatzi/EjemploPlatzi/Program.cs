// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Mouse mouse = new Mouse();

mouse.material = "Plastico";
mouse.color = "Gris";

class Mouse
{
    //Propiedades
    public string color;
    public string material;
    public string marca;
    public double tamanio;
    public int botones;

}