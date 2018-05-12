using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWSecurityServices
{
    public partial class GUIVeiwer : Form
    {
        public GUIVeiwer(List<string> logs)
        {
            InitializeComponent();
            ConsoleText.Text = "CurrentLog" + "\r\n";
            for(int i = 0; i < logs.Count(); i++)
            {
                ConsoleText.Text += logs[i] + "\r\n";
            }
        }
    }
}
