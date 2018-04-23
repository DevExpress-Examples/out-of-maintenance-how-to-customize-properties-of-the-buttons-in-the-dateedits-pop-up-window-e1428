using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            dateEdit1.Properties.AppearanceCalendar.Button.Options.UseTextOptions = true;
           dateEdit1.Properties.AppearanceCalendar.Button.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            dateEdit1.Properties.AppearanceCalendar.ButtonHighlighted.Options.UseTextOptions = true;
            dateEdit1.Properties.AppearanceCalendar.ButtonHighlighted.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            dateEdit1.Properties.AppearanceCalendar.ButtonPressed.Options.UseTextOptions = true;
            dateEdit1.Properties.AppearanceCalendar.ButtonPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }
}
