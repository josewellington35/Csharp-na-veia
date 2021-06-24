using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace mecânica
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {  // comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from USUARIO where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
               dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Todos os campos são obrigatorios!";
            }

            return tem;

        }
        public  String cadastrar(String email,String senha,String confSenha)
        {
            tem = false; 
            if (senha.Equals(confSenha))
            {

                cmd.CommandText = "insert into USUARIO values(@e,@s)";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@S", senha);
                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Todos os campos são obrigatorios!";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            
            return mensagem;

        }
    }
}
