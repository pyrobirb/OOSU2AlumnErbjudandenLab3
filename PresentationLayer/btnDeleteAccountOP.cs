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
    public partial class btnDeleteAccountOP : Button
    {
        public Subject subject { get; set; } = new Subject();

        public btnDeleteAccountOP()
        {
            InitializeComponent();

            MouseEnter += MouseEnterOrLeave;
            MouseLeave += MouseEnterOrLeave;

        }

        public void MouseEnterOrLeave(object sender, EventArgs e)
        {
            subject.notifyAll();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        
    }
}
