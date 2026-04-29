using DesafioPOO.Models;

Smartphone nokia = new Nokia("11999999999", "Tijolão", "111111111111111", 128);
Smartphone iphone = new Iphone("11888888888", "iPhone 15", "222222222222222", 256);

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
