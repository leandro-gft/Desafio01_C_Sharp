using System;

namespace Veiculo_Csharp
{
    class main
    {
        static void Main(string[] args)
        {
			Veiculo v = new Veiculo("Fiat","Uno","GFT-2020","Azul",0,false,0,0,20000);
			v.mostrarCarro();
			v.ligar();
			v.abastecer(50);
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.acelerar();
			v.abastecer(5);
			v.acelerar();
			v.frear();
			v.pintar("vermelho");
			v.desligar();
			Console.ReadKey();

		}
    }
}
