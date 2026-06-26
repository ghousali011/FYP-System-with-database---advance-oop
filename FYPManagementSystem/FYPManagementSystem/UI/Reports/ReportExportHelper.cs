using Microsoft.Reporting.WinForms;
using System.IO;

namespace FYPManagementSystem.UI.Reports
{
    internal static class ReportExportHelper
    {
        public static void ExportReportToPdf(LocalReport report, string outputPath)
        {
            string mimeType, encoding, fileNameExtension;
            string[] streams;
            Warning[] warnings;
            var bytes = report.Render("PDF", null, out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            File.WriteAllBytes(outputPath, bytes);
        }
    }
}
