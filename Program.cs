using DesafioPOO.Models;

System.Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia( numero: "123456", modelo:"Modelo 1",imei : "111111111",memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("SmartPhone Iphone:");
Smartphone iphone = new Iphone( numero: "4787", modelo:"Modelo 2",imei : "22222222",memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");