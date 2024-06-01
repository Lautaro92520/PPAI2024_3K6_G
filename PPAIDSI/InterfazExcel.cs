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
            var filePath = "RankingVinos.xlsx";

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Ranking de Vinos");
                worksheet.Cells[1, 1].Value = "Puesto";
                worksheet.Cells[1, 2].Value = "Nombre";
                worksheet.Cells[1, 3].Value = "Calificación";
                worksheet.Cells[1, 4].Value = "Precio";
                worksheet.Cells[1, 5].Value = "Bodega";
                worksheet.Cells[1, 6].Value = "Region";
                worksheet.Cells[1, 7].Value = "Pais";
                worksheet.Cells[1, 8].Value = "Varietal";

                var range1 = worksheet.Cells[1, 1, 11, 8];
                range1.Style.Font.Name = "Trebuchet MS";
                range1.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                range1.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                range1.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                range1.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                var range2 = worksheet.Cells[1, 1, 1, 8];
                range2.Style.Font.Bold = true;
                range2.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                range2.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range2.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                range2.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
 
                var range3 = worksheet.Cells[11, 1, 11, 8];
                range3.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;

                var range4 = worksheet.Cells[1, 8, 11, 8];
                range4.Style.Border.Right.Style = ExcelBorderStyle.Thick;

                for (int i = 0; i < 10; i++)
                {
                    var l = _listaListas[i];
                    worksheet.Cells[i + 2, 1].Value = i + 1;
                    worksheet.Cells[i + 2, 2].Value = l[0];
                    worksheet.Cells[i + 2, 3].Value = l[1];
                    worksheet.Cells[i + 2, 4].Value = l[2];
                    worksheet.Cells[i + 2, 5].Value = l[3];
                    worksheet.Cells[i + 2, 6].Value = l[4];
                    worksheet.Cells[i + 2, 7].Value = l[5];
                    worksheet.Cells[i + 2, 8].Value = l[6];
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
