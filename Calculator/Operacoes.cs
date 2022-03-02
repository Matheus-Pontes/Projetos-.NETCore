public class Operacoes 
{
    static public void somaValores() 
    {
        Console.Write("Digite o primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"A soma dos dois valores é {valor1 + valor2}");
        Console.WriteLine("-----------------------------------");
    }

    static public void subtraiValores() 
    {
        Console.Write("Digite o primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"A subtração dos dois valores é {valor1 - valor2}");
        Console.WriteLine("----------------------------------------");
    }

    static public void divideValores() 
    {
        Console.Write("Digite o primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        if(valor2 != 0) 
        {
            Console.WriteLine($"A divisão dos dois valores é {valor1 / valor2}");
            Console.WriteLine("--------------------------------------");
        } 
        else 
        {
            Console.WriteLine("Impossível dividir por ZERO (0) !!!");
            Console.WriteLine("-----------------------------------");
        }
    }

    static public void multiplicaValores() 
    {
        Console.Write("Digite o primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"A multiplicação dos dois valores é {valor1 * valor2}");
        Console.WriteLine("--------------------------------------------");
    }
}