using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnTotNghiep.View
{
    public partial class fXemAnh : Form
    {
        private Image anh;

        public Image Anh { get => anh; set => anh = value; }

        public fXemAnh()
        {
            InitializeComponent();
        }

        public fXemAnh(Image Anh)
        {
            InitializeComponent();
            this.Anh = Anh;
        }


        private void fXemAnh_Load(object sender, EventArgs e)
        {
            pbAnh.Image = Anh;
        }
    }
}
