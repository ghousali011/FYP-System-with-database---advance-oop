using FYPManagementSystem.UI.Dashboard;
using FYPManagementSystem.DL;
using FYPManagementSystem.UI;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYPManagementSystem
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            DLFactory.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                LoginForm login = new LoginForm();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Dashboard dashboard = new Dashboard(login.Role, login.LoggedInStudent);
                    Application.Run(dashboard);
                    if (dashboard.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
