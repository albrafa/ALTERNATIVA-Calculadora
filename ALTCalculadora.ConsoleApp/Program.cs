/*
>> OBJETIVOS <<

1. Nossa calculadora deve ter a possibilidade de somar dois números
2. Nossa calculadora deve ter a possibilidade de subtrair dois números
3. Nossa calculadora deve ter a possibilidade de multiplicar dois números
4. Nossa calculadora deve ter a possibilidade de dividir dois números
5. Nossa calculadora deve permitir que o usuário continue utilizando o sistema até decidir sair

v. 2
1. Nossa calculadora deve ter a possibilidade de somar dois números
2. Nossa calculadora deve ter a possibilidade de subtrair dois números
*/

bool deveContinuarExecutando = true;

string[] historicoOperacoes = new string[1000];
int totalOperacoes = 0;

while (deveContinuarExecutando == true)
{

  // >> MENU <<
  Console.WriteLine("----------------------");
  Console.WriteLine("CALCULADORA 2026");
  Console.WriteLine("----------------------");
  Console.WriteLine();

  Console.WriteLine("Selecione uma opção:");
  Console.WriteLine("1 - Somar");
  Console.WriteLine("2 - Subtrair");
  Console.WriteLine("3 - Multiplicar");
  Console.WriteLine("4 - Dividir");
  Console.WriteLine("5 - Tabuada");
  Console.WriteLine("H - Histórico de operações");
  Console.WriteLine("S - Sair");

  // >> ENCERRAR OPERAÇÃO/QUEBRA DE LOOP <<

  string opcao = Console.ReadLine();

  if (opcao == "S" || opcao == "s")
  {
    break;
  }

  // >> VALIDAÇÃO DA OPÇÃO SELECIONADA <<

  if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" &&
      opcao != "5")
  {
    Console.WriteLine("Opção inválida.");
    Console.WriteLine("Pressione ENTER para voltar...");
    Console.ReadLine();
    continue;
  }

  // >> HISTÓRICO <<

  if (opcao == "H")
  {
    Console.WriteLine("-------------------------");
    Console.WriteLine("HISTÓRICO DE OPERAÇÕES...");
    Console.WriteLine("-------------------------");
    Console.WriteLine();

    if (totalOperacoes == 0)
    {
      Console.WriteLine("Nenhuma operação realizada no momento.");
      continue;
    }

    else
    {
      for (int i = 0; i < historicoOperacoes.Length; i++)
      {
        if (historicoOperacoes[i] != null)
        {
          Console.WriteLine(historicoOperacoes[i]);
        }
        continue;
      }
    }
    Console.ReadLine();
  }

  // >> TABUADA <<

  if (opcao == "5")
  {
    Console.WriteLine("----------------------");
    Console.WriteLine("TABUADA...");
    Console.WriteLine("----------------------");
    Console.WriteLine();

    Console.Write("Digite um número inteiro: ");
    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
      string linhaTabuada = $"{numeroTabuada} x {i} = {numeroTabuada * i}";
      Console.WriteLine(linhaTabuada);

    }
    continue;
  }

  // >> USUÁRIO DIGITA UM NÚMERO <<

  Console.Write("Digite o primeiro número: ");
  int primeiroNumero = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine();
  Console.Write("Digite o segundo número: ");
  int segundoNumero = Convert.ToInt32(Console.ReadLine());

  int resultado = 0;

  if (opcao == "1")
  {
    resultado = primeiroNumero + segundoNumero;
    Console.WriteLine("O resultado da operação é: " + resultado);
  }

  else if (opcao == "2")
  {
    resultado = primeiroNumero - segundoNumero;
    Console.WriteLine("O resultado da operação é: " + resultado);
  }

  else if (opcao == "3")
  {
    resultado = primeiroNumero * segundoNumero;
    Console.WriteLine("O resultado da operação é: " + resultado);
  }

  else
  {
    if (segundoNumero == 0)
    {
      Console.WriteLine("Divisão por zero.");
    }
    else
    {
      resultado = primeiroNumero / segundoNumero;
      Console.WriteLine("O resultado da operação é: " + resultado);
    }

  }

}



Console.ReadLine();