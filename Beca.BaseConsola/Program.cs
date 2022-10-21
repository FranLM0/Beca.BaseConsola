
class Program
{
    /// <summary>
    /// Método principal a ejecutar
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    static void Main(string[] args)
    {

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Hello World! - " + i);
        }

        var suma = 1000 + 200;
        suma = suma + 200;
        Console.WriteLine("El resultado de sumar 1000 + 200 es " + suma);

        List<string> list = new List<string>();
        list.Add("Paquito");
        list.Add("Fulanito");
        list.Add("Menganito");
        list.Add("Yoli");

        list.Add("Pepito");

        foreach (string cad in list)
        {
            Console.WriteLine(cad);
        }

    }

}
