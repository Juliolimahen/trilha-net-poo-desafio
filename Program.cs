using DesafioPOO.Models;

Iphone iphone = new Iphone("12349900", "11x", "154524334ffsfr3", 6);

Nokia nokia = new Nokia("12309489", "Tijolão", "46764gh5r4f4", 1);

Console.WriteLine();

iphone.ExibirCaracteristicas();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("WhatsApp");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine();

nokia.ExibirCaracteristicas();
nokia.InstalarAplicativo("Telegram");
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Linkedin");
nokia.Ligar();
nokia.ReceberLigacao();
