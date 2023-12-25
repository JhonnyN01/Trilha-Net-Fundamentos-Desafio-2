using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "2233445566", modelo: "Modelo 1", imei: "0011551144", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "887711", modelo: "Modelo 2", imei: "99111001012", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");