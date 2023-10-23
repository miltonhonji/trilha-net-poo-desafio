using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "551199663388", modelo: "Tijolão", imei: "1555222", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Waze");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "551194451122", modelo: "Sonho de Consumo", imei: "12223", memoria:256);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Spotfy");