using ClosedXML.Excel;
using DocumentFormat.OpenXml.Presentation;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using PPAIDSI.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace PPAIDSI
{
    public partial class InterfazExcel : Form
    {
        public List<List<object>> _listaListas;
        public InterfazExcel()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void exportarExcel(List<List<object>> datosVinos)
        {
            _listaListas = datosVinos;
        }

        private void InterfazExcel_Load(object sender, EventArgs e)
        {
            var filePath = "RankingVinos.xlsx";

            List<object> lista1 = new List<object> { 1, "veinte", 3, 4, "lol", 6, 7};  
            List<object> lista2 = new List<object> { 1, 2, "dfer", 4, "lolds", 6, 7};  
            List<object> lista3 = new List<object> { 1, "gte", 3, 4, "lolete", 6, 7};  
            _listaListas.Add(lista1);
            _listaListas.Add(lista2);
            _listaListas.Add(lista3);

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Ranking de Vinos");
                worksheet.Cells[1, 1].Value = "Nombre";
                worksheet.Cells[1, 2].Value = "Calificación";
                worksheet.Cells[1, 3].Value = "Precio";
                worksheet.Cells[1, 4].Value = "Bodega";
                worksheet.Cells[1, 5].Value = "Varietal";
                worksheet.Cells[1, 6].Value = "Región";
                worksheet.Cells[1, 7].Value = "País";

                using (var range = worksheet.Cells[1, 1, 1, 7])
                {
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                }

                for (int i = 0; i < _listaListas.Count; i++)
                {
                    var l = _listaListas[i];
                    worksheet.Cells[i + 2, 1].Value = l[0];
                    worksheet.Cells[i + 2, 2].Value = l[1];
                    worksheet.Cells[i + 2, 3].Value = l[2];
                    worksheet.Cells[i + 2, 4].Value = l[3];
                    worksheet.Cells[i + 2, 5].Value = l[4];
                    worksheet.Cells[i + 2, 6].Value = l[5];
                    worksheet.Cells[i + 2, 7].Value = l[6];
                }
 
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                var fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }

            var process = Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

            if (process != null)
            {
                process.WaitForExit();
            }

            Environment.Exit(0);
        }
    }
}
