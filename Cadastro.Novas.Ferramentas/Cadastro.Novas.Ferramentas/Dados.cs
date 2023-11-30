using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Novas.Ferramentas
{
    public class Dados
    {
        //String para conexão do bd 

        public static string StringConexao
        {
            get
            {
                return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\richard.gmartins\Documents\db_Projeto.mdf; Integrated Security = True; Connect Timeout = 30";
            }
        }
    }
}
