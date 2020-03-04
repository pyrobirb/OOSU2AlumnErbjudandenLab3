using PresentationLayer.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class WarningLabel : Label, IObserver
    {
        public WarningLabel()
        {
            InitializeComponent();
            
        }

        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void update()
        {
            if (this.Visible == false)
            {
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
