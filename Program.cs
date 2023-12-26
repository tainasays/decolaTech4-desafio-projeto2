using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\t Smartphone iPhone");
Iphone iphone = new Iphone(numero: "11966875521", modelo: "A22", imei: "758415414", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.Write("\n");

Console.WriteLine("\t Smartphone Nokia");
Nokia nokia = new Nokia(numero: "81977462212", modelo: "1110", imei: "747548254", memoria: 1);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");