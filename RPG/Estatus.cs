using RPG.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    //public: chamando a classe publica para ser possivel instancia-lá por meio de atributo na classe Personagens
    public class Estatus
    {
        public int Forca { get; set; }
        public int Mobilidade { get; set; }
        public int Velocidade { get; set; }
        public int Habilidade { get; set; }

        /*public bool Erro(bool true)
        {

        }*/
    }
}
