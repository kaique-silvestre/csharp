Console.WriteLine("Tipos de Referência Anuláveis");
/*
string nome = null;
Console.WriteLine(nome.ToUpper());
*/
Console.WriteLine("A forma que está comentada acima no código irá disparar uma exceção. Já que o valor da variável é nulo e o método não pode ser aplicdo nele.");

Console.ReadKey();  

Console.WriteLine("Vamos fazer da forma que não disparar exceção.");
string? nome2 = null;
Console.WriteLine(nome2?.ToUpper());
Console.WriteLine("Dessa forma se a variável for nula o método não é aplicado, assim se dispara exceção");

Console.WriteLine("A forma correta mesmo é apenas criar uma string vazia");

Console.ReadKey();
