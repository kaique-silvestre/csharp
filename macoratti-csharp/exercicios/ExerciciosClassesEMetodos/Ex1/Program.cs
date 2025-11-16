using Ex1;
/*
 1 - Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e potencia com os tipos de dados string, string, string, int e int. Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”
 
  a - Crie um objeto  chevrolet e atribua os seguintes valores aos atributos :  Sedan, Chevrolet , Onix, 2016, 110
  
  b - Crie outro objeto ford e atribua os seguintes valores aos atributos:  SUV, Ford, EcoSport, 2018, 120 

  c - Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar para cada objeto

 d - Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a mensagem para exibir o texto “Acelerando o meu  {marca}“, seguido da marca do carro

 e - Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos: modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)

 f - Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o método Acelerar passando o valor do argumento para o parâmetro no método Acelerar

 g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não use a palavra-chave this)

 h - Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro
    
>>> agora usando a paalvra reservada "new()" o construtor usado dependerá da quantidade de argumentos utilizados para satisfazer o ocnstrutor adequado.

 i - Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que 
vai retornar um double representando a velocidade máxima do carro
 ( Para calcular a velocidade multiplique a potencia por 1.75)

  j - Explique o comportamento da palavra return

>>> A palavra retorna para fora algum dado que foi processado internamente no método

 l - Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 3 ao parâmetro recebido)

 m - 
    1) Invocar o método criado e passar o valor do argumento por valor e exibir os valores. 

    2) Explique o comportamento da passagem do argumento por valor

>>> Passando o argumento por valor uma cópia do parâmetro é enviada para dentro do argumento, assim os valores modificados dentro do método não afetam os valores originais fora

 n - Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência chamado potencia e retorna um int representando o aumento de potencia. (para aumentar a potência incremente 5 ao parâmetro recebido)

 o - Explique a sobrecarga de métodos

>>> Métodos de mesmo nome, porém com assinaturas diferentes, sendo por exemplo nesse exercício o método AumentarPotencia com duas variações que se diferem na forma de parâmetros recebidos.

 p - Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o comportamento da passagem do argumento por referência.

>>> A passagem or refêrencia faz com que os dados inseridos na parâmetros sejam diretamente modificados pelo processamento do método. Assim sendo a refêrencia na mémoria do dado inserido é diretamente alterada  

  r - Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e  retorna um int como valor da nova potência. Neste método use parâmetro out  e passe a variável velocidade e que vai retornar a nova velocidade como um double. (incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)


 s - Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o comportamento do parâmetro out.

 t - Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora, Marca, Potencia e Ano e que exiba as informações destes atributos no console.

 w - Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.

 w1 - Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se for informado maior que 2022 seja atribuído 2022 ao valor do ano.
  
  w2- Explicar a diferença entre campo e propriedade.

*/


using System.Runtime.ConstrainedExecution;

Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Carro carro2 = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"{carro1.Modelo}, {carro1.Montadora}, {carro1.Marca}, {carro1.Ano}, {carro1.Potencia}");
Console.WriteLine(carro1.Acelerar("Chevrolet"));
Console.WriteLine(carro1.VelocidadeMaxima(carro1.Potencia));

Console.WriteLine($"{carro2.Modelo}, {carro2.Montadora}, {carro2.Marca}, {carro2.Ano}, {carro2.Potencia}");
Console.WriteLine(carro2.Acelerar("Ford"));
Console.WriteLine(carro1.VelocidadeMaxima(carro2.Potencia));


Console.WriteLine(carro1.AumentarPotencia(carro1.Potencia));
Console.WriteLine(carro2.AumentarPotencia(carro2.Potencia));


Carro.MenuDeOpcoes();


public class Carro
{
    public string Modelo;
    public string Montadora;
    public string Marca;
    public int Cor;
    private int ano;
    public int Ano 
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;

        }
    }
    public int Potencia;
 
    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.Modelo = modelo;
        this.Montadora = montadora;
        this.Marca = marca;
        this.Ano = ano;
        this.Potencia = potencia;
    }

    public Carro(string modelo, string montadora, int cor)
    {
        Modelo = modelo;
        Montadora = montadora;
        this.Cor = cor;
    }

    public string Acelerar(string marca)
    {
        return $"Acelerando o meu {marca}";
    }

    public string VelocidadeMaxima(int potencia)
    {
        return $" A velocidade Máxima do {this.Modelo} é {potencia * 1.75}";
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia *= 3;
    }

    public int AumentarPotencia(ref int potencia)
    {
        return potencia *= 5;
    }
    public void AumentarPotenciaVelocidade(out int potencia)
    {
        potencia = 7;
        potencia *= 7;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, string potencia, int ano = 0000)
    {
        Console.WriteLine($"{modelo}, {montadora}, {marca}, {potencia}, {ano}");
    }

    public static void MenuDeOpcoes()
    {
        Console.WriteLine($"{Ex1.Cores.Azul} = {(int)Ex1.Cores.Azul}");
        Console.WriteLine(Ex1.Cores.Vermelho);
        Console.WriteLine(Ex1.Cores.Cinza);
        Console.WriteLine(Ex1.Cores.Preto);
        Console.WriteLine(Ex1.Cores.Prata);
        Console.WriteLine(Ex1.Cores.Branco);

    }
}

