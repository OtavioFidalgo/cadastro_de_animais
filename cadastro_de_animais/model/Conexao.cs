using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_de_animais.model
{
    internal class Conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\otavio.fidalgo\source\repos\cadastro_de_animais\cadastro_de_animais\dados\bdanimais.mdf;Integrated Security=True";
        }
    }
}
