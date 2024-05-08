using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123456","nokia234","123456",521);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsApp");


Iphone iphone = new Iphone ("1234567","iphone 15","09382201910",234);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");