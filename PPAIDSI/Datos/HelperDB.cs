using DocumentFormat.OpenXml.CustomProperties;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPAIDSI.Datos
{
    class HelperDB
    {
        private static HelperDB instance;
        private SqlConnection cnn;

        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public static HelperDB GetInstance()
        {
            if (instance == null)
                instance = new HelperDB();
            return instance;
        }

        public DataTable ConsultaSQL(string strSql, List<Parametro> lst = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            if (lst != null && lst.Count > 0)
            {
                foreach (Parametro p in lst)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
            }

            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
