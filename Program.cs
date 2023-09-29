using DesafioPOO.Models;



Nokia nokia = new Nokia("1","Tijolao","000123",5);

Iphone iphone = new Iphone("2","iphone 13 pro max","9997856",4);

iphone.InstalarAplicativo("Whatsapp");

nokia.InstalarAplicativo("subway surfers");

nokia.Ligar();
nokia.ReceberLigacao();

