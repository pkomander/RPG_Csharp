using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Personagem
{
    public class Personagens
    {
        //atributo da classe Estatus
        public virtual Estatus GetEstatus { get; set; }
        
        //definindo o nome, profissao e altura do personagem com a prop (propriedade)
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public string Arma { get; set; }
        public string Altura { get; set; }
        

        //instanciando o constructor da classe Personagens com referencia a class status
        /*public Personagens(Estatus status)
        {
            Console.WriteLine("Estatus do Personagem:");
            
            this._status = status;
        }*/



        //criando o constructor do personagem
        //prop recebera os valores do constructor que vira da classe program preenchido pelo usuario
        public Personagens(string nome, string profissao, string altura)
        {
            Console.WriteLine("Criando Personagem");
            Nome = nome;
            Profissao = profissao;
            Altura = altura;
            
        }

    }
}
