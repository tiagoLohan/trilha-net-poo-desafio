using DesafioPOO.Models;

// Implementado !!!!!!!!!!!!!!

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("219689-7855", "modelo01", "N1111111111", 65);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("2194517-2311", "modelo02", "N2222222222", 250);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

