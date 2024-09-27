using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado
    Iphone i1 = new Iphone("I101");
    Console.WriteLine("Testando classe Iphone");
    i1.Ligar();
    i1.ReceberLigacao();
    i1.InstalarAplicativo("Futebolapp");

    Console.WriteLine("---------------------------------");

    Nokia n1 = new Nokia("N101");
    Console.WriteLine("Testando Classe Nokia");
    n1.Ligar();
    n1.ReceberLigacao();
    n1.InstalarAplicativo("futebolapp");