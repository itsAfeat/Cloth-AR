using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clother
{
    public partial class menuForm: Form
    {
        readonly List<PictureBox> shirts = new List<PictureBox>();
        readonly List<PictureBox> tanks = new List<PictureBox>();
        readonly List<PictureBox> imported = new List<PictureBox>();
        readonly List<PictureBox> jackets = new List<PictureBox>();

        List<ImpCloth> cloths = new List<ImpCloth>();
        List<int> addedCloth = new List<int>();

        string remImg = null;
        int currCloth = 0;

        int lastLocY = 4;
        int lastLocX = 4;

        internal Img Img { get; set; } = new Img("bomb.png", new Bitmap("bomb.png"));

        public menuForm()
        {
            InitializeComponent();
        }

        public void Start()
        {
            remImg = Img.filepath;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            foreach (Control c in ClothPanel.Controls)
            {
                if (c.Tag.ToString() == "shirt")
                {
                    shirts.Add(c as PictureBox);
                }
                else if (c.Tag.ToString() == "tank")
                {
                    tanks.Add(c as PictureBox);
                }
                else if (c.Tag.ToString() == "jacket")
                {
                    jackets.Add(c as PictureBox);
                }
                else
                {
                    MessageBox.Show(c.Name, "Unknown type");
                }
            }

            ShrtBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;
            tankBtn.FlatAppearance.BorderColor = Color.Black;
            impBtn.FlatAppearance.BorderColor = Color.Black;

            foreach (PictureBox tankC in tanks)
            {
                tankC.Visible = false;
            }
            foreach (PictureBox shirtC in shirts)
            {
                shirtC.Visible = true;
            }

            BarbieShirt_Click(this, null);
        }

        private void BarbieShirt_Click(object sender, EventArgs e)
        {
            remImg = "bomb.png";
            Deselect_All();
            BarbieShirt.BorderStyle = BorderStyle.Fixed3D;
        }

        private void FortniteShirt_Click(object sender, EventArgs e)
        {
            remImg = "Fonte.png";
            Deselect_All();
            FortniteShirt.BorderStyle = BorderStyle.Fixed3D;
        }

        private void XShirt_Click(object sender, EventArgs e)
        {
            remImg = "xxx.png";
            Deselect_All();
            xShirt.BorderStyle = BorderStyle.Fixed3D;
        }

        private void KuroShirt_Click(object sender, EventArgs e)
        {
            remImg = "Kuro.png";
            Deselect_All();
            KuroShirt.BorderStyle = BorderStyle.Fixed3D;
        }
        private void SlotJacket_Click(object sender, EventArgs e)
        {
            remImg = "slot.png";
            Deselect_All();
            slotJacket.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Deselect_All()
        {
            BarbieShirt.BorderStyle = BorderStyle.FixedSingle;
            FortniteShirt.BorderStyle = BorderStyle.FixedSingle;
            xShirt.BorderStyle = BorderStyle.FixedSingle;
            KuroShirt.BorderStyle = BorderStyle.FixedSingle;
            slotJacket.BorderStyle = BorderStyle.FixedSingle;

            foreach (PictureBox box in imported)
            {
                box.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private new void Close()
        {
            Parent = null;
            Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Close();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            Img.Update(remImg);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            Deselect_All();

            switch (remImg)
            {
                case "bombe.png":
                    BarbieShirt.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case "Fonte.png":
                    FortniteShirt.BorderStyle = BorderStyle.Fixed3D;
                    break;
                case "xxx.png":
                    xShirt.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PNG Image|*.png",
                Title = "Import clothes"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImpCloth cloth = new ImpCloth("impPic" + currCloth, openFileDialog.FileName, currCloth);
                cloths.Add(cloth);
                currCloth++;
            }
        }

        private void ShrtBtn_Click(object sender, EventArgs e)
        {
            ShrtBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;
            tankBtn.FlatAppearance.BorderColor = Color.Black;
            impBtn.FlatAppearance.BorderColor = Color.Black;
            jacketBtn.FlatAppearance.BorderColor = Color.Black;

            foreach (PictureBox tankC in tanks)
            {
                tankC.Visible = false;
            }
            foreach (PictureBox shirtC in shirts)
            {
                shirtC.Visible = true;
            }
            foreach (PictureBox imp in imported)
            {
                imp.Visible = false;
            }
            foreach (PictureBox jackC in jackets)
            {
                jackC.Visible = false;
            }
        }

        private void TankBtn_Click(object sender, EventArgs e)
        {
            ShrtBtn.FlatAppearance.BorderColor = Color.Black;
            tankBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;
            impBtn.FlatAppearance.BorderColor = Color.Black;
            jacketBtn.FlatAppearance.BorderColor = Color.Black;

            foreach (PictureBox tankC in tanks)
            {
                tankC.Visible = true;
            }
            foreach (PictureBox shirtC in shirts)
            {
                shirtC.Visible = false;
            }
            foreach (PictureBox imp in imported)
            {
                imp.Visible = false;
            }
            foreach (PictureBox jackC in jackets)
            {
                jackC.Visible = false;
            }
        }

        private void JacketBtn_Click(object sender, EventArgs e)
        {
            ShrtBtn.FlatAppearance.BorderColor = Color.Black;
            tankBtn.FlatAppearance.BorderColor = Color.Black;
            impBtn.FlatAppearance.BorderColor = Color.Black;
            jacketBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;

            foreach (PictureBox jackC in jackets)
            {
                jackC.Visible = true;
            }
            foreach (PictureBox tankC in tanks)
            {
                tankC.Visible = false;
            }
            foreach (PictureBox shirtC in shirts)
            {
                shirtC.Visible = false;
            }
            foreach (PictureBox imp in imported)
            {
                imp.Visible = false;
            }
        }

        private void ImpBtn_Click(object sender, EventArgs e)
        {
            ShrtBtn.FlatAppearance.BorderColor = Color.Black;
            tankBtn.FlatAppearance.BorderColor = Color.Black;
            impBtn.FlatAppearance.BorderColor = Color.PaleTurquoise;
            jacketBtn.FlatAppearance.BorderColor = Color.Black;

            foreach (PictureBox tankC in tanks)
            {
                tankC.Visible = false;
            }
            foreach (PictureBox shirtC in shirts)
            {
                shirtC.Visible = false;
            }
            foreach (PictureBox jackC in jackets)
            {
                jackC.Visible = false;
            }

            // Show imported clothes

            foreach (ImpCloth cloth in cloths)
            {
                if (!addedCloth.Contains(cloth.num))
                {
                    addedCloth.Add(cloth.num);

                    PictureBox picBox = new PictureBox
                    {
                        Name = "impBox" + cloth.num,
                        Size = new Size(159, 159),
                        Tag = "import-" + cloth.num,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle,
                        Image = new Bitmap(cloth.path)
                    };

                    if (cloth.num == 0)
                    {
                        picBox.Location = new Point(4, 4);
                    }
                    else if (lastLocX + 165 > 334)
                    {
                        lastLocX = 4;
                        lastLocY += 165;
                        picBox.Location = new Point(lastLocX, lastLocY);
                    }
                    else if (lastLocY != 4)
                    {
                        lastLocX += 165;
                        picBox.Location = new Point(lastLocX, lastLocY);
                    }
                    else if (lastLocY == 4)
                    {
                        lastLocX += 165;
                        picBox.Location = new Point(lastLocX, 4);
                    }

                    ClothPanel.Controls.Add(picBox);

                    picBox.Click += (object s, EventArgs ea) =>
                    {
                        remImg = cloth.path;
                        Deselect_All();
                        picBox.BorderStyle = BorderStyle.Fixed3D;
                    };

                    imported.Add(picBox);
                }
            }

            foreach (PictureBox imp in imported)
            {
                imp.Visible = true;
            }
        }
    }

    public class ImpCloth
    {
        public string name;
        public string path;
        public int num;

        public ImpCloth(string name, string path, int num)
        {
            this.name = name;
            this.path = path;
            this.num = num;
        }
    }
}
