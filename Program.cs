using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - IMPLEMENTADO

Console.WriteLine($"Smatphone Nokia");
Smartphone nokia = new Nokia(numero: "71-999990000", modelo: "7320", imei:"56748390254", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Genshin Impact");

Console.WriteLine("\n");

Console.WriteLine($"Smatphone IPhone");
Smartphone iphone = new Iphone(numero: "71-993939495", modelo: "14 Pro Max", imei:"10293847839", memoria:256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Fifa");

Console.WriteLine("\n");

Console.WriteLine($"Smatphone Samsung");
Smartphone samsung = new Samsung(numero: "71-987766554", modelo: "Galaxy S23 Ultra", imei:"01928374659", memoria:256);
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Call of Duty");

