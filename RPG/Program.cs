using RPG.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Criando Personagem");

            //Passando os valores atraves do constructor = Nome, Profissao, Altura
            Personagens personagemDoPaulo = new Personagens("Aragorn","Guerreiro","1.70");
            /*personagemDoPaulo.Nome = "Aragorn";
            personagemDoPaulo.Profissao = "Guerreiro";
            personagemDoPaulo.Arma = "Espada Narsil";
            personagemDoPaulo.Altura = "1.70";*/
            personagemDoPaulo.Arma = "Espada Narsil";

            //chamando os atributos da classe Estatus e atribuindo ao personagem
            personagemDoPaulo.GetEstatus = new Estatus();
            personagemDoPaulo.GetEstatus.Forca = 15;
            personagemDoPaulo.GetEstatus.Mobilidade = 20;
            personagemDoPaulo.GetEstatus.Velocidade = 10;
            personagemDoPaulo.GetEstatus.Habilidade = 20;

            Console.WriteLine("Nome do Personagem: " + personagemDoPaulo.Nome);
            Console.WriteLine("Profissão do Personagem: " + personagemDoPaulo.Profissao);
            Console.WriteLine("Arma do Personagem: " + personagemDoPaulo.Arma);
            Console.WriteLine("Altura do Personagem: " + personagemDoPaulo.Altura);

            Console.WriteLine("Força: " + personagemDoPaulo.GetEstatus.Forca);
            Console.WriteLine("Mobilidade: " + personagemDoPaulo.GetEstatus.Mobilidade);
            Console.WriteLine("Velocidade: " + personagemDoPaulo.GetEstatus.Velocidade);
            Console.WriteLine("Habilidade: " + personagemDoPaulo.GetEstatus.Habilidade);




            Console.ReadLine();
        }
    }
}
