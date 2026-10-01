// Exiba a segunda informação:

//----JOKENPÔ------
// Escolha sua jogada:
// 1 -Pedra
// 2 -Papel
// 3 -Tesoura

// Sua opção

Console.WriteLine("""
                  ---JOKENPÔ---
                  Escolha a sua jogada
                  1- Pedra
                  2- Papel
                  3- Tesoura
                  
                  Sua opção
                  """);

// Ler a opção da pessoa, converter para inteiro e salva em algum lugar
// Read the user's option, conver in to an integer, and store it
// 1- Crie uma variável  | 2- Atribuir valor > Converter para inteiro > Ler a próxima linha do console
int OpcaoUsuario; 
bool converteuOpcao = int.TryParse(Console.ReadLine(), out OpcaoUsuario);

while (OpcaoUsuario < 1 || OpcaoUsuario > 3 || !converteuOpcao)
{
    
    Console.WriteLine("Escolha novamente entre o número 1 á 3.");
   converteuOpcao = int.TryParse(Console.ReadLine(), out OpcaoUsuario);
}

var aleatorio = new Random();
int OpcaoComputador = aleatorio.Next(1, 4);

// Estrutura Switch-case 
string escolhaUsuarioTexto;
string escolhaComputadorTexto;

switch (OpcaoUsuario)
{
    case 1:
    // Aqui vem os comando dos casos 1
      escolhaUsuarioTexto = "pedra";
        break;
    
    case 2:
        escolhaUsuarioTexto = "papel";
        break;
    
    case 3:
        escolhaUsuarioTexto = "tesoura";
        break;
    
    default:
        escolhaUsuarioTexto = "nenhum";
        break;
}

switch (OpcaoComputador)
{
    case 1:
        // Aqui vem os comando dos casos 1
        escolhaComputadorTexto = "pedra";
        break;
    
    case 2:
        escolhaComputadorTexto = "papel";
        break;
    
    case 3:
        escolhaComputadorTexto = "tesoura";
        break;
    
    default:
        escolhaComputadorTexto = "nenhum";
        break;
}


Console.WriteLine($"O usuário escolheu {escolhaUsuarioTexto} e o computador escolheu {escolhaComputadorTexto}");    

