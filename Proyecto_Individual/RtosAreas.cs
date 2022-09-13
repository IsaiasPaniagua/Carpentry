using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Individual
{
    public partial class RtosAreas : Form
    {
        private RAreas RAreas1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public RtosAreas()
        {
            InitializeComponent();
        }

        private void RtosAreas_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RAreas1 = new Proyecto_Individual.RAreas();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.RAreas1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1150, 430);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // RtosAreas
            // 
            this.ClientSize = new System.Drawing.Size(1150, 430);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "RtosAreas";
            this.Text = "Reportes de Areas";
            this.ResumeLayout(false);

        }
    }
}
