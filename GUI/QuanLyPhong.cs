using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;

namespace GUI
{
    public partial class QuanLyPhong : FilterCollectionViewBase
    {
        public QuanLyPhong()
        {
            InitializeComponent();

            InitSplitterSkinElement();

            try
            {
                gridControl.DataSource = DAL.DataProvider.ExecuseQuery("SELECT * FROM quanlykaraoke.phong, quanlykaraoke.tinhtrangphong where quanlykaraoke.phong.MaTinhTrangPhong = quanlykaraoke.tinhtrangphong.MaTinhTrangPhong;");
            }
            catch(Exception e)
            {

            }

            return;
        }

        private void InitSplitterSkinElement()
        {
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.Common, DevExpress.LookAndFeel.UserLookAndFeel.Default, "Splitter");
            System.Drawing.Image img = GetImage();
            element.Glyph.Image = new Bitmap(img, new Size(img.Width * 2, element.Glyph.Image.Height*2));
        }
        private System.Drawing.Image GetImage()
        {
            return GUI.Properties.Resources.splitter_glyphInit;
        }
    }
}
