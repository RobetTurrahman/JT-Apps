using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inap
{
    internal class inapitem
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        Panel panelkmr = new();
        Label labelkmr = new();
        Inap inap;

        public inapitem(Inap inap)
        {
            this.inap = inap;
            labelkmr.AutoSize = true;
            labelkmr.Font = new Font("Poppins Black", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelkmr.ForeColor = Color.White;
            labelkmr.Location = new Point(6, 34);
            labelkmr.Name = "label2";
            labelkmr.Size = new Size(99, 42);
            labelkmr.TabIndex = 1;
            labelkmr.Text = inap.nama_jenis_kamar;

            //panelkmr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelkmr.BackColor = Color.Transparent;
            panelkmr.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panelkmr.BackgroundImageLayout = ImageLayout.Stretch;
            panelkmr.Location = new Point(36, 150);
            panelkmr.Name = "panel4";
            panelkmr.Size = new Size(727, 100);
            panelkmr.Controls.Add(labelkmr);
            panelkmr.Click += Panel_Click;
        }
        public Panel CreateItem()
        {
            return panelkmr;
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Edit_detail_penginapan edit = new Edit_detail_penginapan();
            edit.SetInap(this.inap);
            edit.ShowDialog();
        }
    }

}

