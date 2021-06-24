using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace mecânica
{
    class Pservico
    {
        ClnBancodados ObjBancoDados = new ClnBancodados();
        string comando = "";
        public DataTable Preencherservico()
        {
            comando = "Select Hora from MaoObra";
            return ObjBancoDados.RetornaTabela(comando);
        }
    }
}
