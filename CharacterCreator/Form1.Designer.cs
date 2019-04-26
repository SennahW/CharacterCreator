namespace CharacterCreator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rdoBtnFemale = new System.Windows.Forms.RadioButton();
            this.rdoBtnMale = new System.Windows.Forms.RadioButton();
            this.btnPowerDown = new System.Windows.Forms.Button();
            this.btnPowerUp = new System.Windows.Forms.Button();
            this.btnAgilityDown = new System.Windows.Forms.Button();
            this.btnAgilityUp = new System.Windows.Forms.Button();
            this.btnInteligensDown = new System.Windows.Forms.Button();
            this.btnInteligensUp = new System.Windows.Forms.Button();
            this.lblCharacteristicsPoints = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblAgility = new System.Windows.Forms.Label();
            this.lblInteligens = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.picBoxPortrait = new System.Windows.Forms.PictureBox();
            this.btnPortraitPrev = new System.Windows.Forms.Button();
            this.btnPortraitNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(144, 34);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(132, 22);
            this.txtBoxName.TabIndex = 1;
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rdoBtnFemale);
            this.grpBoxGender.Controls.Add(this.rdoBtnMale);
            this.grpBoxGender.Location = new System.Drawing.Point(44, 94);
            this.grpBoxGender.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxGender.Size = new System.Drawing.Size(267, 123);
            this.grpBoxGender.TabIndex = 2;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            this.grpBoxGender.Enter += new System.EventHandler(this.grpBoxGender_Enter);
            // 
            // rdoBtnFemale
            // 
            this.rdoBtnFemale.AutoSize = true;
            this.rdoBtnFemale.Location = new System.Drawing.Point(132, 57);
            this.rdoBtnFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBtnFemale.Name = "rdoBtnFemale";
            this.rdoBtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rdoBtnFemale.TabIndex = 1;
            this.rdoBtnFemale.TabStop = true;
            this.rdoBtnFemale.Text = "Female";
            this.rdoBtnFemale.UseVisualStyleBackColor = true;
            this.rdoBtnFemale.CheckedChanged += new System.EventHandler(this.rdoBtnFemale_CheckedChanged);
            // 
            // rdoBtnMale
            // 
            this.rdoBtnMale.AutoSize = true;
            this.rdoBtnMale.Location = new System.Drawing.Point(9, 57);
            this.rdoBtnMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoBtnMale.Name = "rdoBtnMale";
            this.rdoBtnMale.Size = new System.Drawing.Size(59, 21);
            this.rdoBtnMale.TabIndex = 0;
            this.rdoBtnMale.TabStop = true;
            this.rdoBtnMale.Text = "Male";
            this.rdoBtnMale.UseVisualStyleBackColor = true;
            this.rdoBtnMale.CheckedChanged += new System.EventHandler(this.rdoBtnMale_CheckedChanged);
            // 
            // btnPowerDown
            // 
            this.btnPowerDown.Location = new System.Drawing.Point(640, 126);
            this.btnPowerDown.Name = "btnPowerDown";
            this.btnPowerDown.Size = new System.Drawing.Size(75, 23);
            this.btnPowerDown.TabIndex = 3;
            this.btnPowerDown.Text = "-";
            this.btnPowerDown.UseVisualStyleBackColor = true;
            this.btnPowerDown.Click += new System.EventHandler(this.btnPowerDown_Click);
            // 
            // btnPowerUp
            // 
            this.btnPowerUp.Location = new System.Drawing.Point(925, 126);
            this.btnPowerUp.Name = "btnPowerUp";
            this.btnPowerUp.Size = new System.Drawing.Size(75, 23);
            this.btnPowerUp.TabIndex = 4;
            this.btnPowerUp.Text = "+";
            this.btnPowerUp.UseVisualStyleBackColor = true;
            this.btnPowerUp.Click += new System.EventHandler(this.btnPowerUp_Click);
            // 
            // btnAgilityDown
            // 
            this.btnAgilityDown.Location = new System.Drawing.Point(640, 193);
            this.btnAgilityDown.Name = "btnAgilityDown";
            this.btnAgilityDown.Size = new System.Drawing.Size(75, 23);
            this.btnAgilityDown.TabIndex = 5;
            this.btnAgilityDown.Text = "-";
            this.btnAgilityDown.UseVisualStyleBackColor = true;
            this.btnAgilityDown.Click += new System.EventHandler(this.btnAgilityDown_Click);
            // 
            // btnAgilityUp
            // 
            this.btnAgilityUp.Location = new System.Drawing.Point(925, 193);
            this.btnAgilityUp.Name = "btnAgilityUp";
            this.btnAgilityUp.Size = new System.Drawing.Size(75, 23);
            this.btnAgilityUp.TabIndex = 6;
            this.btnAgilityUp.Text = "+";
            this.btnAgilityUp.UseVisualStyleBackColor = true;
            this.btnAgilityUp.Click += new System.EventHandler(this.btnAgilityUp_Click);
            // 
            // btnInteligensDown
            // 
            this.btnInteligensDown.Location = new System.Drawing.Point(640, 259);
            this.btnInteligensDown.Name = "btnInteligensDown";
            this.btnInteligensDown.Size = new System.Drawing.Size(75, 23);
            this.btnInteligensDown.TabIndex = 7;
            this.btnInteligensDown.Text = "-";
            this.btnInteligensDown.UseVisualStyleBackColor = true;
            this.btnInteligensDown.Click += new System.EventHandler(this.btnInteligensDown_Click);
            // 
            // btnInteligensUp
            // 
            this.btnInteligensUp.Location = new System.Drawing.Point(925, 259);
            this.btnInteligensUp.Name = "btnInteligensUp";
            this.btnInteligensUp.Size = new System.Drawing.Size(75, 23);
            this.btnInteligensUp.TabIndex = 8;
            this.btnInteligensUp.Text = "+";
            this.btnInteligensUp.UseVisualStyleBackColor = true;
            this.btnInteligensUp.Click += new System.EventHandler(this.btnInteligensUp_Click);
            // 
            // lblCharacteristicsPoints
            // 
            this.lblCharacteristicsPoints.AutoSize = true;
            this.lblCharacteristicsPoints.Location = new System.Drawing.Point(821, 34);
            this.lblCharacteristicsPoints.Name = "lblCharacteristicsPoints";
            this.lblCharacteristicsPoints.Size = new System.Drawing.Size(106, 17);
            this.lblCharacteristicsPoints.TabIndex = 9;
            this.lblCharacteristicsPoints.Text = "Points to spend";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(793, 126);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(47, 17);
            this.lblPower.TabIndex = 10;
            this.lblPower.Text = "Power";
            // 
            // lblAgility
            // 
            this.lblAgility.AutoSize = true;
            this.lblAgility.Location = new System.Drawing.Point(796, 193);
            this.lblAgility.Name = "lblAgility";
            this.lblAgility.Size = new System.Drawing.Size(45, 17);
            this.lblAgility.TabIndex = 11;
            this.lblAgility.Text = "Agility";
            // 
            // lblInteligens
            // 
            this.lblInteligens.AutoSize = true;
            this.lblInteligens.Location = new System.Drawing.Point(796, 264);
            this.lblInteligens.Name = "lblInteligens";
            this.lblInteligens.Size = new System.Drawing.Size(68, 17);
            this.lblInteligens.TabIndex = 12;
            this.lblInteligens.Text = "Inteligens";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(925, 374);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(116, 23);
            this.btnSaveFile.TabIndex = 13;
            this.btnSaveFile.Text = "Save file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(765, 374);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(116, 23);
            this.btnOpenFile.TabIndex = 14;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "STREAMWRITER";
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // picBoxPortrait
            // 
            this.picBoxPortrait.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPortrait.Image")));
            this.picBoxPortrait.Location = new System.Drawing.Point(43, 240);
            this.picBoxPortrait.Name = "picBoxPortrait";
            this.picBoxPortrait.Size = new System.Drawing.Size(220, 220);
            this.picBoxPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPortrait.TabIndex = 16;
            this.picBoxPortrait.TabStop = false;
            this.picBoxPortrait.Click += new System.EventHandler(this.picBoxPortrait_Click);
            // 
            // btnPortraitPrev
            // 
            this.btnPortraitPrev.Location = new System.Drawing.Point(339, 240);
            this.btnPortraitPrev.Name = "btnPortraitPrev";
            this.btnPortraitPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPortraitPrev.TabIndex = 17;
            this.btnPortraitPrev.Text = "Previous";
            this.btnPortraitPrev.UseVisualStyleBackColor = true;
            this.btnPortraitPrev.Click += new System.EventHandler(this.btnPortraitPrev_Click);
            // 
            // btnPortraitNext
            // 
            this.btnPortraitNext.Location = new System.Drawing.Point(467, 240);
            this.btnPortraitNext.Name = "btnPortraitNext";
            this.btnPortraitNext.Size = new System.Drawing.Size(75, 23);
            this.btnPortraitNext.TabIndex = 18;
            this.btnPortraitNext.Text = "Next";
            this.btnPortraitNext.UseVisualStyleBackColor = true;
            this.btnPortraitNext.Click += new System.EventHandler(this.btnPortraitNext_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPortraitNext);
            this.Controls.Add(this.btnPortraitPrev);
            this.Controls.Add(this.picBoxPortrait);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lblInteligens);
            this.Controls.Add(this.lblAgility);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblCharacteristicsPoints);
            this.Controls.Add(this.btnInteligensUp);
            this.Controls.Add(this.btnInteligensDown);
            this.Controls.Add(this.btnAgilityUp);
            this.Controls.Add(this.btnAgilityDown);
            this.Controls.Add(this.btnPowerUp);
            this.Controls.Add(this.btnPowerDown);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPortrait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton rdoBtnFemale;
        private System.Windows.Forms.RadioButton rdoBtnMale;
        private System.Windows.Forms.Button btnPowerDown;
        private System.Windows.Forms.Button btnPowerUp;
        private System.Windows.Forms.Button btnAgilityDown;
        private System.Windows.Forms.Button btnAgilityUp;
        private System.Windows.Forms.Button btnInteligensDown;
        private System.Windows.Forms.Button btnInteligensUp;
        private System.Windows.Forms.Label lblCharacteristicsPoints;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblAgility;
        private System.Windows.Forms.Label lblInteligens;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.PictureBox picBoxPortrait;
        private System.Windows.Forms.Button btnPortraitPrev;
        private System.Windows.Forms.Button btnPortraitNext;
    }
}

