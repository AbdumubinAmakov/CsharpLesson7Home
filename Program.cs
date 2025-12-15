// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Мисоли истифода
class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(4, 6, "Кабуд");

        Console.WriteLine("Ранг: " + rect.Color);
        Console.WriteLine("Масоҳат: " + rect.GetArea());
        Console.WriteLine("Периметр: " + rect.GetPerimeter());
    }
}