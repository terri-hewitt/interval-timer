using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTimer
{
    public class MainForm
    {
        [STAThread]
        public static void Main()
        {
            var iface = new Interface();
            Application.Run(iface);
        }
    }
}
