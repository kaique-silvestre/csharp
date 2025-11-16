using records;

// Criando o obejto 
var usuario = new Usuario();
usuario.Name = "Roberto";
usuario.Email = "Roberto@email.com";

// "Copiando" o objeto
var usuariocopia = usuario;

// Modificando a cópia
usuariocopia.Name = "Marina";
usuariocopia.Email = "Marina@email.com";

//Exibindo os dois obejtos
Console.WriteLine(usuario.ToString());
Console.WriteLine(usuariocopia.ToString());

/*
 * Ambos os objetos foram modificados, 
 * mesmo que na prática apenas tenhamos mexido
 * no objeto que é a cópia.
 * Isso ocorre porquê a cópia feita da forma que fizemos
 * copia a referência do objeto e não os valores
 */

// fazendo da forma correta

// Criando usuário original
var UsuarioImutavel = new UsuarioRecord("Mateus", "mateus@email.com");

// Fazendo a cópia corretamente

var UsuarioImutavelCopia = UsuarioImutavel with { Name = "José", Email = "jose@email.com" };


Console.WriteLine(UsuarioImutavel.Name +  "," + UsuarioImutavel.Email);
Console.WriteLine(UsuarioImutavelCopia.Name + "," + UsuarioImutavelCopia.Email);