using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone*OK*
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "654321", modelo: "Modelo 10", imei: "5555555", memoria: 77);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4545", modelo: "Modelo 20", imei: "8888888", memoria: 130);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");