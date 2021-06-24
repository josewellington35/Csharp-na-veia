using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace mecânica
{
    class Produto1
    {
        string comando;
        ClnBancodados ObjBancoDados = new ClnBancodados();
        private string COD_Produto,_FORNECERDOR,_PRODUTO,_MODELO,_MARCA,_VALOR,Ano;

        public string COD_Produto1 { get => COD_Produto; set => COD_Produto = value; }
        public string FORNECERDOR { get => _FORNECERDOR; set => _FORNECERDOR = value; }
        public string PRODUTO { get => _PRODUTO; set => _PRODUTO = value; }
        public string MODELO { get => _MODELO; set => _MODELO = value; }
        public string MARCA { get => _MARCA; set => _MARCA = value; }
        public string VALOR { get => _VALOR; set => _VALOR = value; }
       
        public string Ano1 { get => Ano; set => Ano = value; }

        public DataTable LocalizarPorNome(string strDescicao)
        {
            comando = "select COD_Produto,PRODUTO,MODELO,VALOR from   PRODUTO Where PRODUTO like '%" + strDescicao + "%' and Ativo = '1' order by COD_Produto";
            return ObjBancoDados.RetornaTabela(comando);
        }
        public SqlDataReader LocalizarCodigo(string COD_Produto)
        {
            comando = "select * from  PRODUTO where  COD_Produto  ='" + COD_Produto + "'";
            return ObjBancoDados.RetornaLinha(comando);
        }
        public void Gravar()
        {
            
            comando = "INSERT INTO  PRODUTO ";
            comando += ("VALUES(");
            comando += ("'" + FORNECERDOR + "',");
            comando += ("'" + PRODUTO + "',");
            comando += ("'" + MODELO + "',");
            comando += ("'" + MARCA + "',");
            comando += ("'" + VALOR + "',");
            comando += ("'" + Ano + "',");
            comando += ("'1'");
            comando += (")");
            ObjBancoDados.ExecutaComando(comando);


        }
        //public void QuantDesc()
        //{
          
        //    comando = ("UPDATE   PRODUTO ");
        //    comando += ("SET ");
        //    comando += ("QUANTIDADE = '" + QUANTIDADE  + -1 + "',");
        //    comando += ("Ativo = '1'");
        //    comando += ("WHERE ");
        //    comando += ("COD_Produto = ' " + COD_Produto + "'");
        //      ObjBancoDados.ExecutaComando(comando);
        //}
        public void Alterar()
        {

            comando = ("UPDATE   PRODUTO ");
            comando += ("SET ");
            comando += ("FORNECERDOR = '" + FORNECERDOR + "',");
            comando += ("PRODUTO = '" + PRODUTO + "',");
            comando += ("MODELO = '" + MODELO + "',");
            comando += ("MARCA = '" + MARCA + "',");
            comando += ("VALOR = '" + VALOR + "',");
            comando += ("Ano = '" + Ano + "',");
            comando += ("Ativo = '1'");
            comando += ("WHERE ");
            comando += ("COD_Produto = ' " + COD_Produto + "'");
            ObjBancoDados.ExecutaComando(comando);


        }
        public void ExcluirLogicamente()
        {
            comando = ("UPDATE   PRODUTO ");
            comando += ("SET ");
            comando += ("Ativo = '" + 0 + "'");
            comando += ("WHERE ");
            comando += ("COD_Produto = '" + COD_Produto + "'");
            ObjBancoDados.ExecutaComando(comando);
        }


    }
}

