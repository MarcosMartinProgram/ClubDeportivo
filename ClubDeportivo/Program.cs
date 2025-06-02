using System;
using System.Windows.Forms;

namespace ClubDeportivo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin()); // Aquí indicas que se cargue el Form1
        }
    }
}