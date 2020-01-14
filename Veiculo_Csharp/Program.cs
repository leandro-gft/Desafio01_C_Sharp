using System;

namespace Veiculo_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Veiculo v = new Veiculo("","","","",0,false,0,0,0);
			v.desligar();
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
