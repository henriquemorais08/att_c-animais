//atividade//
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE ANIMAIS ===");
        
        Cachorro rex = new Cachorro();
        rex.Nome = "Rex";
        rex.Idade = 3;
        Console.WriteLine($"Animal: {rex.Nome}");
        Console.WriteLine($"Idade: {rex.Idade} anos");
        Console.Write("Som: ");
        rex.EmitirSom();
        Console.WriteLine(); // Linha em branco para separar
        
        Gato mimi = new Gato();
        mimi.Nome = "Mimi";
        mimi.Idade = 2;
        Console.WriteLine($"Animal: {mimi.Nome}");
        Console.WriteLine($"Idade: {mimi.Idade} anos");
        Console.Write("Som: ");
        mimi.EmitirSom();
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine("Timbre Vocal.");
    }
}
class Cachorro : Animal
{  
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo: Au au!");
    }
}
class Gato : Animal
{  
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}