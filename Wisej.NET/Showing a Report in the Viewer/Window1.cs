
using System;
using Wisej.Web;

namespace Showing_a_Report_in_the_Viewer.NET8
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();

            AspNetPanel aspNetPanel = new AspNetPanel
            {
                PageSource = "WebViewer.html",
                Dock = DockStyle.Fill
            };

            this.Controls.Add(aspNetPanel);
        }
    }
}
