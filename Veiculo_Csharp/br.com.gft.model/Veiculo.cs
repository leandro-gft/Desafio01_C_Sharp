using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo_Csharp
{
	class Veiculo
	{
		private string marca;
		private string modelo;
		private string placa;
		private string cor;
		private float km;
		private bool isLigado;
		private int litrosCombustivel;
		private int velocidade;
		private double preco;

		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Placa { get; set; }
		public string Cor { get; set; }
		public float Km { get; set; }
		public bool IsLigado { get; set; }
		public int LitrosCombustivel { get; set; }
		public int Velocidade { get; set; }
		public double Preco { get; set; }

		public Veiculo(String _marca, String _modelo, String _placa, String _cor, float _km, bool _isLigado, int _litrosCombustivel, int _velocidade, double _preco)
		{
			this.Marca = _marca;
			this.Modelo = _modelo;
			this.Placa = _placa;
			this.Cor = _cor;
			this.Km = _km;
			this.IsLigado = _isLigado;
			this.LitrosCombustivel = _litrosCombustivel;
			this.Velocidade = _velocidade;
			this.Preco = _preco;
		}
		
		public void acelerar()
		{
			if (this.isLigado == true)
			{
				this.velocidade += 20;
				this.litrosCombustivel -= 1;
				Console.WriteLine("Você acelerou. A velocidade atual é de " + this.velocidade + " quilometros por hora");
				Console.WriteLine("O carro tem " + this.litrosCombustivel + " litros de combustível");
			}
			else
			{
				Console.WriteLine("Não é possivel acelerar com o carro desligado");
			}
		}

		public void abastecer(int qtdLitros)
		{
			if (this.litrosCombustivel >= 100)
			{
				this.litrosCombustivel = 100;
			}
			else
			{
				this.litrosCombustivel += qtdLitros;
				if (this.litrosCombustivel >= 100)
				{
					this.litrosCombustivel = 100;
				}
			}
			Console.WriteLine("Você abasteceu. O carro agora tem " + this.litrosCombustivel + " litros de combustível");
		}

		public void frear()
		{
			if (this.isLigado == true)
			{
				if (this.velocidade > 10)
				{
					this.velocidade -= 10;
				}
				else
				{
					if (this.velocidade <= 10)
					{
						Console.WriteLine("Carro parado");
					}
				}
			}
			else
			{
				Console.WriteLine("Carro desligado");
			}
			Console.WriteLine("Você freou. A velocidade atual é de " + this.velocidade + " quilometros por hora");
		}

		public void pintar(String cor)
		{
			Console.WriteLine("Você pintou seu carro de " + cor);
		}

		public void ligar()
		{
			if (this.isLigado == true)
			{
				Console.WriteLine("O carro já está ligado");
			}
			else
			{
				this.isLigado = true;
				Console.WriteLine("Você ligou o carro.");
			}
		}

		public void desligar()
		{
			if (this.isLigado == false)
			{
				Console.WriteLine("O carro está desligado");
			}
			else
			{
				this.isLigado = false;
				Console.WriteLine("Você desligou o carro");
			}
		}
		public void mostrarCarro()
		{
			Console.WriteLine("----------------------------------------------------------------------");
			Console.WriteLine("	Seu carro:");
			Console.WriteLine("	Modelo: " +this.Modelo);
			Console.WriteLine("	Marca: " + this.Marca);
			Console.WriteLine("	Placa: " + this.Placa);
			Console.WriteLine("	Cor: " + this.Cor);
			Console.WriteLine("	Quilômetros rodados: " + this.Km);
			Console.WriteLine("	Preço: " + this.Preco);
			Console.WriteLine("---------------------------------------------------------------------");
		}
	}
}
