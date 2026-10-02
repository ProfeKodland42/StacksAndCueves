using Backend;

var stack1 = new StackUsingArray<string>(10);

var option = string.Empty;
do
{
    
    option = Menu();
    try
    {
        switch (option)
        {
            case "1":
                // Apilar
                Console.WriteLine("Digite el elemento.");
                stack1.Push(Console.ReadLine()!);
                break;
            case "2":
                // Desapilar
                Console.WriteLine($"Elemento desapilado.: {stack1.Pop()}");
                break;
            case "3":
                // Ver tope
                Console.WriteLine($"Elemento de tope de pila: {stack1.Peek()}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}while (option != "0");

string Menu()
{
    Console.WriteLine("1. Apilar");
    Console.WriteLine("2. Desapilar");
    Console.WriteLine("3. Ver tope");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    return Console.ReadLine()!;
}
    































