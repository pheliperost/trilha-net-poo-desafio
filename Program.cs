using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Nokia nokia = new Nokia("111","modelo 1 nokia", "imei1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("app 1");

Console.WriteLine("-----------");


Console.WriteLine("Iphone: ");
Iphone iphone = new Iphone("222","modelo 2 iphone", "imei2", 32);
iphone.Ligar();
iphone.InstalarAplicativo("app 2");

