using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CharacterCreator
{
    public partial class frmMain : Form
    {
        //Declaring basic variables for character stats
        int CharateristisPoints = 40;
        int PowerPoints = 0;
        int InteligensPoints = 0;
        int AgilityPoints = 0;

        // 0 = female; 1 = male
        int Gender;
        //Which portrait in the array
        int CurrentPortrait;
        //Arrays of male and female portraits.
        Image[] PortraitsFemale = new Image[10];
        Image[] PortraitsMale = new Image[10];



        public frmMain()
        {
            InitializeComponent();
            //Fills the image arrays with pictures.
            SetImageArray();
            //Updates all the visible stats in creator.
            UpdateValues();
        }
        private void SetImageArray()
        {
            //Adds portraits to arrays.
            PortraitsFemale[0] = Image.FromFile(@"..\..\Images\F_portrait01.jpg");
            PortraitsFemale[1] = Image.FromFile(@"..\..\Images\F_portrait02.jpg");
            PortraitsFemale[2] = Image.FromFile(@"..\..\Images\F_portrait03.jpg");
            PortraitsFemale[3] = Image.FromFile(@"..\..\Images\F_portrait04.jpg");
            PortraitsFemale[4] = Image.FromFile(@"..\..\Images\F_portrait05.jpg");
            PortraitsFemale[5] = Image.FromFile(@"..\..\Images\F_portrait06.jpg");
            PortraitsFemale[6] = Image.FromFile(@"..\..\Images\F_portrait07.jpg");
            PortraitsFemale[7] = Image.FromFile(@"..\..\Images\F_portrait08.jpg");
            PortraitsFemale[8] = Image.FromFile(@"..\..\Images\F_portrait09.jpg");
            PortraitsFemale[9] = Image.FromFile(@"..\..\Images\F_portrait10.jpg");
            PortraitsMale[0] = Image.FromFile(@"..\..\Images\M_portrait01.jpg");
            PortraitsMale[1] = Image.FromFile(@"..\..\Images\M_portrait02.jpg");
            PortraitsMale[2] = Image.FromFile(@"..\..\Images\M_portrait03.jpg");
            PortraitsMale[3] = Image.FromFile(@"..\..\Images\M_portrait04.jpg");
            PortraitsMale[4] = Image.FromFile(@"..\..\Images\M_portrait05.jpg");
            PortraitsMale[5] = Image.FromFile(@"..\..\Images\M_portrait06.jpg");
            PortraitsMale[6] = Image.FromFile(@"..\..\Images\M_portrait07.jpg");
            PortraitsMale[7] = Image.FromFile(@"..\..\Images\M_portrait08.jpg");
            PortraitsMale[8] = Image.FromFile(@"..\..\Images\M_portrait09.jpg");
            PortraitsMale[9] = Image.FromFile(@"..\..\Images\M_portrait10.jpg");
        }

        private void btnPowerDown_Click(object sender, EventArgs e)
        {
            if (PowerPoints > 0)
            {
                PowerPoints--;
                CharateristisPoints++;
                UpdateValues();
            }
        }

        private void btnPowerUp_Click(object sender, EventArgs e)
        {
            if (CharateristisPoints > 0)
            {
                PowerPoints++;
                CharateristisPoints--;
                UpdateValues();
            }
        }

        private void btnAgilityUp_Click(object sender, EventArgs e)
        {
            if (CharateristisPoints > 0)
            {
                AgilityPoints++;
                CharateristisPoints--;
                UpdateValues();
            }
        }

        private void btnAgilityDown_Click(object sender, EventArgs e)
        {
            if (AgilityPoints > 0)
            {
                AgilityPoints--;
                CharateristisPoints++;
                UpdateValues();
            }
        }

        private void btnInteligensDown_Click(object sender, EventArgs e)
        {
            if (InteligensPoints > 0)
            {
                InteligensPoints--;
                CharateristisPoints++;
                UpdateValues();
            }
        }

        private void btnInteligensUp_Click(object sender, EventArgs e)
        {
            if (CharateristisPoints > 0)
            {
                InteligensPoints++;
                CharateristisPoints--;
                UpdateValues();
            }
        }

        //Method for updating all UI stats and portrait
        private void UpdateValues()
        {
            lblPower.Text = "Power: " + PowerPoints.ToString();
            lblAgility.Text = "Agility: " + AgilityPoints.ToString();
            lblInteligens.Text = "Inteligens: " + InteligensPoints.ToString();
            lblCharacteristicsPoints.Text = "Points to spend: " + CharateristisPoints.ToString();
            if (Gender == 0)
            {
                rdoBtnFemale.Checked = true;
                rdoBtnMale.Checked = false;
                picBoxPortrait.Image = PortraitsFemale[CurrentPortrait];
            }
            else if (Gender == 1)
            {
                rdoBtnFemale.Checked = false;
                rdoBtnMale.Checked = true;
                picBoxPortrait.Image = PortraitsMale[CurrentPortrait];

            }
        }
        
        //Method for updating portrait
        private void UpdatePicBox()
        {
            if (Gender == 0)
            {
                picBoxPortrait.Image = PortraitsFemale[CurrentPortrait];
            }
            else if (Gender == 1)
            {
                picBoxPortrait.Image = PortraitsMale[CurrentPortrait];
            }
        }

        //Method for saving a character
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            sfdSave.ShowDialog();
            if (sfdSave.FileName != null)
            {
                StreamWriter sw = new StreamWriter(sfdSave.FileName);
                sw.WriteLine(CharateristisPoints);
                sw.WriteLine(AgilityPoints);
                sw.WriteLine(InteligensPoints);
                sw.WriteLine(PowerPoints);
                sw.WriteLine(txtBoxName.Text);
                sw.WriteLine(Gender);
                sw.Close();
            }
        }

        //Method for opening existing character .txt file
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdOpen.ShowDialog();
            
            if (ofdOpen.FileName != null)
            {
                StreamReader sr = new StreamReader(ofdOpen.FileName);
                CharateristisPoints = Convert.ToInt32(sr.ReadLine());
                AgilityPoints = Convert.ToInt32(sr.ReadLine());
                InteligensPoints = Convert.ToInt32(sr.ReadLine());
                PowerPoints = Convert.ToInt32(sr.ReadLine());
                txtBoxName.Text = sr.ReadLine();
                Gender = Convert.ToInt32(sr.ReadLine());
                sr.Close();
                UpdateValues();

            }
        }

        private void rdoBtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = 0;
            UpdatePicBox();
        }

        private void rdoBtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = 1;
            UpdatePicBox();
        }

        //Method for next portrait
        private void btnPortraitNext_Click(object sender, EventArgs e)
        {
            if (rdoBtnFemale.Checked)
            {
                if (CurrentPortrait >= PortraitsFemale.Length - 1)
                {
                    CurrentPortrait = 0;
                }
                else
                {
                    CurrentPortrait++;
                }
            }
            else if (rdoBtnMale.Checked)
            {
                if (CurrentPortrait >= PortraitsMale.Length - 1)
                {
                    CurrentPortrait = 0;
                }
                else
                {
                    CurrentPortrait++;
                }
            }
            UpdateValues();

        }

        //Method for previous portrait
        private void btnPortraitPrev_Click(object sender, EventArgs e)
        {
            if (rdoBtnFemale.Checked)
            {
                if (CurrentPortrait <= 0)
                {
                    CurrentPortrait = PortraitsFemale.Length - 1;
                }
                else
                {
                    CurrentPortrait--;
                }
            }
            else if (rdoBtnMale.Checked)
            {
                if (CurrentPortrait <= 0)
                {
                    CurrentPortrait = PortraitsMale.Length - 1;
                }
                else
                {
                    CurrentPortrait--;
                }
            }
            UpdateValues();


        }
    }
}
