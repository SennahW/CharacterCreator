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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rdoBtnMale = new System.Windows.Forms.RadioButton();
            this.rdoBtnFemale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(108, 28);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 1;
            this.txtBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rdoBtnFemale);
            this.grpBoxGender.Controls.Add(this.rdoBtnMale);
            this.grpBoxGender.Location = new System.Drawing.Point(33, 76);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(200, 100);
            this.grpBoxGender.TabIndex = 2;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // rdoBtnMale
            // 
            this.rdoBtnMale.AutoSize = true;
            this.rdoBtnMale.Location = new System.Drawing.Point(7, 46);
            this.rdoBtnMale.Name = "rdoBtnMale";
            this.rdoBtnMale.Size = new System.Drawing.Size(48, 17);
            this.rdoBtnMale.TabIndex = 0;
            this.rdoBtnMale.TabStop = true;
            this.rdoBtnMale.Text = "Male";
            this.rdoBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdoBtnFemale
            // 
            this.rdoBtnFemale.AutoSize = true;
            this.rdoBtnFemale.Location = new System.Drawing.Point(99, 46);
            this.rdoBtnFemale.Name = "rdoBtnFemale";
            this.rdoBtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoBtnFemale.TabIndex = 1;
            this.rdoBtnFemale.TabStop = true;
            this.rdoBtnFemale.Text = "Female";
            this.rdoBtnFemale.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Name = "frmMain";
            this.Text = "Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
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
    }
}

