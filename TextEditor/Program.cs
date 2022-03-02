// See https://aka.ms/new-console-template for more information
using System;
// Utilizando escrita de código do .NET 6 sem classes
Console.WriteLine("Hello, World!");

menu();

static void menu() 
{
    Console.Clear();
    Console.WriteLine("--------------------------");
    Console.WriteLine(" O que você deseja fazer? ");
    Console.WriteLine(" 1 - Abrir arquivo        ");
    Console.WriteLine(" 2 - Criar novo arquivo   ");
    Console.WriteLine(" 0 - Sair                 ");
    Console.WriteLine("--------------------------");

    var option = int.Parse(Console.ReadLine());

    switch(option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: openFile(); break;
        case 2: createFile(); break;
    }
}

static void openFile() 
{
    Console.Clear();
    Console.WriteLine("----------------------------");
    Console.WriteLine(" Qual o caminho do arquivo? ");
    Console.WriteLine("----------------------------");
    string path = Console.ReadLine();

    using(var file = new StreamReader(path)) 
    {

        Console.WriteLine("-----------------------");
        string text = file.ReadToEnd();
        Console.WriteLine(text);
        Console.WriteLine("-----------------------");
    }

    Console.WriteLine("=");
    Console.ReadLine();
    menu();
}

static void createFile() 
{
    Console.Clear();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
    Console.WriteLine("---------------------------------------");

    string text = "";

    do {
        text += Console.ReadLine();
    } while(Console.ReadKey().Key != ConsoleKey.Escape);

    saveFile(text);
}

static void saveFile(string text) 
{
    Console.Clear();
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(" Qual caminho para salvar o arquivo? ");
    Console.WriteLine("-------------------------------------");
    var path = Console.ReadLine();

    using(var file = new StreamWriter(path)) 
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo salvo com sucesso!");
    Console.WriteLine($"No local {path}");
    Console.WriteLine("------------------------------------");
    Console.ReadLine();
    
    menu();
}