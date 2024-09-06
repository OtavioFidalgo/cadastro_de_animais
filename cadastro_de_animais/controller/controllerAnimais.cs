using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cadastro_de_animais.model;

namespace cadastro_de_animais.controller
{
    internal class controllerAnimais
    {
        //CRUD
        //C - create = inserir registros na tabela do banco
        //R - read = ler os registros da tabela do banco
        //U - update = alterar registros da tabela do banco
        //D - delete = apagar registros da tabela do banco

        //Método de inserir registros na tabela do banco
        public void EnviarBanco()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("PCadastroAnimais", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Animais.Nome);
                cmd.Parameters.AddWithValue("@raca", Animais.Raca);
                cmd.Parameters.AddWithValue("@porte", Animais.Porte);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso");

            }
            catch (Exception)
            {

                throw;
            }

        }

        }
    }
