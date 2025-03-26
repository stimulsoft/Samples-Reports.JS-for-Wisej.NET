
using System;
using Wisej.Web;

namespace Editing_a_Report_in_the_Designer.NET8
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();

            AspNetPanel aspNetPanel = new AspNetPanel
            {
                PageSource = "WebDesigner.html",
                Dock = DockStyle.Fill
            };

            this.Controls.Add(aspNetPanel);
        }
    }
}
