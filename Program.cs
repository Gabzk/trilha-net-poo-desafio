using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iphone:");
Iphone iphone = new Iphone("85-996157289", "Iphone 13 Pro Max", "1234567890", 256);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("Nokia:");
Nokia nokia = new Nokia("85-996157285", "Nokia 3310", "1234567890", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

