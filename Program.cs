using System;
 
class Program 
{
  enum Menu {Soma =1, Subtração,Divisão, Multiplicação,Potencia,Raiz,Sair}

  static void Main(String[]args)
  {
    bool escolheuSair = false;
    while(!escolheuSair)//Enquanto o usuaro NÃO(!) escolher //sair exiba o menu
    {
      Console.WriteLine("Seja Bem Vindo ao CALC,Selecione uma das opções: ");
Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair ");
    Menu opcao = (Menu)int.Parse(Console.ReadLine());
      
    switch(opcao)
  
    {
      case Menu.Soma://ou seja, caso selecione a soma 
        Soma();//execute soma
        break;
      case Menu.Subtração:
        Sub();
        break;
      case Menu.Divisão:
        div();
        break;
      case Menu.Multiplicação:
        Mult();
        break;
        case Menu.Potencia:
        Pot();
        break;
        case Menu.Raiz:
        Raiz();
        break;
        case Menu.Sair:
      escolheuSair = true;
      break;
    }
      
          Console.Clear();  //Limpar

    }
    static void Soma()
    {
      Console.WriteLine("Soma de dois números: ");
      Console.WriteLine("Digite o primeiro número: ");
      int a = int.Parse(Console.ReadLine());//converter para inteiro
      Console.WriteLine("Digite o segundo número: ");
      int b = int.Parse(Console.ReadLine());
      int resultado = a + b;
      Console.WriteLine($"O resultado é: {resultado}");
      Console.WriteLine("Aperte ENTER para voltar ao menu");
      Console.ReadLine();//esperando apertar a tecla
      
    }
        static void Sub()
    {
      Console.WriteLine("Subtração de dois números: ");
      Console.WriteLine("Digite o primeiro número: ");
      int a = int.Parse(Console.ReadLine());//converter para inteiro
      Console.WriteLine("Digite o segundo número: ");
      int b = int.Parse(Console.ReadLine());
      int resultado = a - b;
      Console.WriteLine($"O resultado é: {resultado}");
      Console.WriteLine("Aperte ENTER para voltar ao menu");
      Console.ReadLine();//esperando apertar a tecla
      
    }
     static void div()
    {
      Console.WriteLine("Divisão de dois números: ");
      Console.WriteLine("Digite o primeiro número: ");
      int a = int.Parse(Console.ReadLine());//converter para inteiro
      Console.WriteLine("Digite o segundo número: ");
      int b = int.Parse(Console.ReadLine());
      float resultado =(float)a/(float)b;
      Console.WriteLine($"O resultado é: {resultado}");
      Console.WriteLine("Aperte ENTER para voltar ao menu");
       Console.ReadLine();

  }
      static void Mult()
    {
      Console.WriteLine("Multiplicação de dois números: ");
      Console.WriteLine("Digite o primeiro número: ");
      int a = int.Parse(Console.ReadLine());//converter para inteiro
      Console.WriteLine("Digite o segundo número: ");
      int b = int.Parse(Console.ReadLine());
      int resultado = a * b;
      Console.WriteLine($"O resultado é: {resultado}");
      Console.WriteLine("Aperte ENTER para voltar ao menu");
      Console.ReadLine();//esperando apertar a tecla
      
    }
     static void Pot()
       //2^4= 2**2*2*2*=16
    {
      Console.WriteLine("Potência de um número: ");
      Console.WriteLine("Digite a base: ");
      int basenum = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o expoente: ");
      int expo = int.Parse(Console.ReadLine());
      int resultado = (int)Math.Pow(basenum,expo);
      Console.WriteLine($"O resultado é: {resultado}");
      Console.WriteLine("Aperte ENTER para voltar ao menu");
      Console.ReadLine();
      
    }
       static void Raiz()
    {
      Console.WriteLine("Raiz de números: ");
      Console.WriteLine("Digite o número: ");
      int a = int.Parse(Console.ReadLine());
      double resultado = Math.Sqrt(a);
      Console.WriteLine($"O resultado é: {resultado}");
      Console.WriteLine("Aperte ENTER para voltar ao menu");
      Console.ReadLine();
      
    }
}
}