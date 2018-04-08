using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraBars;
using DTO;

namespace GUI
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();

         
            



            //Dictionary<string,PhongDTO> a = DAL.PhongDAL.LayTatCaPhong();


           

        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.quanLyPhong1 = new GUI.QuanLyPhong();
            this.SuspendLayout();
            // 
            // quanLyPhong1
            // 
            this.quanLyPhong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanLyPhong1.Location = new System.Drawing.Point(0, 0);
            this.quanLyPhong1.Name = "quanLyPhong1";
            this.quanLyPhong1.Size = new System.Drawing.Size(1311, 692);
            this.quanLyPhong1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1311, 692);
            this.Controls.Add(this.quanLyPhong1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
