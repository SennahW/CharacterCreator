using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class frmMain : Form
    {
        float CharateristisPoints = 40;
        float PowerPoints = 0;
        float InteligensPoints = 0;
        float AgilityPoints = 0;
        

        public frmMain()
        {
            InitializeComponent();
            UpdateValues();
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

        private void UpdateValues()
        {
            lblPower.Text = "Power: " + PowerPoints.ToString();
            lblAgility.Text = "Agility: " + AgilityPoints.ToString();
            lblInteligens.Text = "Inteligens: " + InteligensPoints.ToString();
            lblCharacteristicsPoints.Text = "Points to spend: " + CharateristisPoints.ToString();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
           
        }
        /*
        // Öppna open file dialog så att användaren för välja en fil att läsa ifrån
        openFileDialog1.ShowDialog();
        // Skriv innehållet från den valda filen till en textbox
        textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
        Exemplet ovan visar hur man med hjälp av en openFileDialog kan få användaren att öppna
        en fil (exempelvis textfil) och sedan skriva innehållet av den in i en textbox.
        // Öppna save file dialog så att användaren för välja en fil att spara till
        saveFileDialog1.ShowDialog();
        // Skriv innehållet från en textbox till den valda filen
        File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        I detta exempel får användaren välja en fil via en saveFileDialog som en text ska sparas till.
        Därefter sparas innehållet i en textbox till denna fil. Observera att eventuellt innehåll som
        fanns i filen tidigare kommer att skrivas över.
        */

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }
    }
}
