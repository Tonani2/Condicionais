// Crie  uma variável chamada "idade" e atribua o valor 18 a ela

// Crie uma  variável chamada "valorIngresso" e atribua o valor 30.00 a ela

int idade = 17;

double valorIngresso = 30.00;

// Crie uma variável chamada "ehEstudante"
bool ehEstudante = true;

// Criar uma variável chamada "clienteVIP" e atribua um valor que possibilita entender que o usuário é um cliente VIP
bool clienteVIP = true;

// Criar um bloco de condição testando se a idade é menor ou igual á?



if (clienteVIP)
{
    valorIngresso *= 0.4;
}
else if(idade <= 7 || idade >= 60 || ehEstudante)
{
    valorIngresso = valorIngresso * 0.5;
}

Console.WriteLine($"O valor do ingresso a pagar é R${valorIngresso}");

// Dentro do bloco da condição, você terá que calcular a metade do valor do ingresso e atribuia-la novamente a variável "valorIntresso"
// valorIngresso = valorIngresso
// Exiba a informação abaixo:
// "O valor do ingresso a pagar é R$ ?? (do lado de fora do bloco do if)"
