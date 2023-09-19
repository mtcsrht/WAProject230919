using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAProject230919.Properties;

namespace WAProject230919
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        private int clickCounter = 0;

        static Image[] sadcats =
        {
            Resources.cat1,
            Resources.cat2,
            Resources.cat3,
            Resources.cat4,
            Resources.cat5
        };
        public FrmMain()
        {
            InitializeComponent();
            btnRandom.Click += BtnRandomClick;
            btnTorles.Click += BtnTorlesClick;
        }

        private void BtnTorlesClick(object sender, EventArgs e)
        {
            
            pbSadCat.Image = null;
        }

        private void BtnRandomClick(object sender, EventArgs e)
        {
            clickCounter++;
            pbSadCat.Image = sadcats[rnd.Next(sadcats.Length)];
            if (clickCounter == 10)
            {
                DialogResult result = MessageBox.Show(
                    caption: "FIGYELMEZTETÉS!!44!!!44!!!",
                    text: "Elég lesz mára b+\nAbbahagyod???",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.YesNo
                    );

                if (result == DialogResult.Yes)
                    Application.Exit();
            }

        }
    }
}
