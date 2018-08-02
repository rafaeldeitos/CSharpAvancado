using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum Status
    {
        Ativo = 1,
        Inativo = 2
    }

    public struct Pessoa
    {
        public int Codigo;
        public String Nome;
        public DateTime DataNascimento;
    }

    public class Veiculo
    {
        private int _codigo;
        private string _marca;
        private string _modelo;
        private int _anoFabricacao;
        private int _anoModelo;

        public int Codigo
        {
            get => _codigo;
            set => _codigo = value;
        }

        public string Marca
        {
            get => _marca;
            set => _marca = value;
        }

        public string Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }

        public int AnoFabricacao
        {
            get => _anoFabricacao;
            set => _anoFabricacao = value;
        }

        public int AnoModelo
        {
            get => _anoModelo;
            set => _anoModelo = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            //string frase = "Hoje à noite, sem luz, decidi xeretar a quinta gaveta do vovô: achei linguiça, pão e fubá";

            //Console.WriteLine(frase.Length); Conta a quaantidade de caracteres

            //string[] partes = frase.Split(",");

            //for (int i = 0; i < partes.Length; i++)
            //{
            //    Console.WriteLine(partes[i].Trim());
            //}
            

            /*StringBuilder frase = new StringBuilder();
            frase.Append("Frase1");
            frase.Append("Frase2");
            frase.Append("Frase3");
            frase.Append("Frase4");


            Console.WriteLine(frase);
            */

            //Console.WriteLine($"Nome {DateTime.Now.AddDays(1)}");

            //Console.WriteLine(Status.Ativo);
            
            /*Pessoa Pes = new Pessoa();

            Pes.Codigo = 1;
            Pes.Nome = "Rafael Deitos";
            Pes.DataNascimento = DateTime.Parse("1989-06-13");

            Console.WriteLine($"Meu nome é {Pes.Codigo} {Pes.Nome} e minha data de nascimento é {Pes.DataNascimento}");*/
            /*
            ArrayList listaArray = new ArrayList();

            listaArray.Add(1);
            listaArray.Add("Rafael Deitos");
            listaArray.Add(DateTime.Parse("1989-06-13"));

            foreach (var elementos in listaArray)
            {
                Console.WriteLine(elementos);
                
            }

            List<String> lista = new List<string>();
            lista.Add("1");
            lista.Add("Rafael Deitos");
            lista.Add("Nascimento");

            foreach (string objetosDaLista in lista)
            {
                Console.WriteLine(objetosDaLista);
            }
            */

            List<Veiculo> veiculos = new List<Veiculo>();


            Veiculo carro1 = new Veiculo();
            carro1.Codigo = 1;
            carro1.AnoFabricacao = 2008;
            carro1.AnoModelo = 2009;
            carro1.Marca = "Peugeot";
            carro1.Modelo = "307 Sedan";

            Veiculo carro2 = new Veiculo();
            carro2.Codigo = 2;
            carro2.AnoFabricacao = 1996;
            carro2.AnoModelo = 1997;
            carro2.Marca = "GM";
            carro2.Modelo = "Corsa";

            Veiculo carro3 = new Veiculo();
            carro3.Codigo = 3;
            carro3.AnoFabricacao = 1997;
            carro3.AnoModelo = 1997;
            carro3.Marca = "Chevrolet";
            carro3.Modelo = "Vectra";
            
            veiculos.Add(carro1);
            veiculos.Add(carro2);
            veiculos.Add(carro3);

            foreach (Veiculo veic in veiculos)
            {
                Console.WriteLine(veic.Modelo);
            }

            {
                
            }




            Console.ReadLine();
        }
    }
}
