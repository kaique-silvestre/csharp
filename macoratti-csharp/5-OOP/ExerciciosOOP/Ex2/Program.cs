namespace Ex2;
/*

Crie um programa para gerenciar um álbum de fotos usando os coceitos da programação
orientada a objetos.

Para começar, crie uma classe chamada
LivroFotos com um atributo privado numPaginas do
tipo int. Defina também um método público GetNumeroPaginas que retornará o número de
páginas do álbum de fotos

O construtor padrão deverá criar um álbum com 16 páginas a classe deve possuir um
construtor adicional, com o qual podemos especificar o número de páginas que queremos
no álbum. Crie também uma classe SuperLivroFotos cujo construtor criará um álbum com
64 páginas.
Por fim, execute as seguintes ações:
-
Criar um álbum de fotos padrão e exibir o número de páginas
-
Criar um álbum de fotos com 24 páginas e exibir o número de páginas
-
Criar um álbum de fotos grande e exibir o número de páginas
*/


class Program
{
    public static void Main(string[] args)
    {
        var lf = new LivroFotos();
        Console.WriteLine(lf.GetNumeroPaginas());

        var nlf = new LivroFotos(50);
        Console.WriteLine(nlf.GetNumeroPaginas());

    }
}
public class LivroFotos
{
    // Construtor 
    public LivroFotos()
    {
        this.numPaginas = 16;
    }
    public LivroFotos(int PageNum)
    {
        this.numPaginas = PageNum;
    }
    // Propriedades 
    private int numPaginas { get; set; } = 0;

    // Métodos
    public int GetNumeroPaginas()
    {
        return this.numPaginas;
    }
}
