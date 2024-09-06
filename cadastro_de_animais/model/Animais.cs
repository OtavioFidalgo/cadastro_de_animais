using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_animais.model
{
    internal class Animais
    {
        private static int codigo;
        private static string nome;
        private static string raca;
        private static string porte;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Raca { get => raca; set => raca = value; }
        public static string Porte { get => porte; set => porte = value; }
    }
}
