
namespace Class_Project
{
    partial class FormDiceRoller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiceRoller));
            this.pictureD4 = new System.Windows.Forms.PictureBox();
            this.pictureD6 = new System.Windows.Forms.PictureBox();
            this.pictureD8 = new System.Windows.Forms.PictureBox();
            this.pictureD10 = new System.Windows.Forms.PictureBox();
            this.pictureD12 = new System.Windows.Forms.PictureBox();
            this.pictureD20 = new System.Windows.Forms.PictureBox();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonAdvantage = new System.Windows.Forms.Button();
            this.buttonDisadvantage = new System.Windows.Forms.Button();
            this.textBoxd20Result = new System.Windows.Forms.TextBox();
            this.textBoxRollNumber = new System.Windows.Forms.TextBox();
            this.labelRoll20Result = new System.Windows.Forms.Label();
            this.buttonD4 = new System.Windows.Forms.Button();
            this.buttonD6 = new System.Windows.Forms.Button();
            this.buttonD10 = new System.Windows.Forms.Button();
            this.buttonD12 = new System.Windows.Forms.Button();
            this.buttonD8 = new System.Windows.Forms.Button();
            this.buttonTotals = new System.Windows.Forms.Button();
            this.listBoxTotal = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD20)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureD4
            // 
            this.pictureD4.Image = ((System.Drawing.Image)(resources.GetObject("pictureD4.Image")));
            this.pictureD4.Location = new System.Drawing.Point(319, 12);
            this.pictureD4.Name = "pictureD4";
            this.pictureD4.Size = new System.Drawing.Size(111, 103);
            this.pictureD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureD4.TabIndex = 2;
            this.pictureD4.TabStop = false;
            // 
            // pictureD6
            // 
            this.pictureD6.Image = ((System.Drawing.Image)(resources.GetObject("pictureD6.Image")));
            this.pictureD6.Location = new System.Drawing.Point(436, 12);
            this.pictureD6.Name = "pictureD6";
            this.pictureD6.Size = new System.Drawing.Size(110, 103);
            this.pictureD6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureD6.TabIndex = 3;
            this.pictureD6.TabStop = false;
            // 
            // pictureD8
            // 
            this.pictureD8.Image = ((System.Drawing.Image)(resources.GetObject("pictureD8.Image")));
            this.pictureD8.Location = new System.Drawing.Point(553, 12);
            this.pictureD8.Name = "pictureD8";
            this.pictureD8.Size = new System.Drawing.Size(110, 103);
            this.pictureD8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureD8.TabIndex = 4;
            this.pictureD8.TabStop = false;
            // 
            // pictureD10
            // 
            this.pictureD10.Image = ((System.Drawing.Image)(resources.GetObject("pictureD10.Image")));
            this.pictureD10.Location = new System.Drawing.Point(321, 150);
            this.pictureD10.Name = "pictureD10";
            this.pictureD10.Size = new System.Drawing.Size(110, 103);
            this.pictureD10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureD10.TabIndex = 6;
            this.pictureD10.TabStop = false;
            // 
            // pictureD12
            // 
            this.pictureD12.Image = ((System.Drawing.Image)(resources.GetObject("pictureD12.Image")));
            this.pictureD12.Location = new System.Drawing.Point(436, 150);
            this.pictureD12.Name = "pictureD12";
            this.pictureD12.Size = new System.Drawing.Size(110, 103);
            this.pictureD12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureD12.TabIndex = 7;
            this.pictureD12.TabStop = false;
            // 
            // pictureD20
            // 
            this.pictureD20.Image = ((System.Drawing.Image)(resources.GetObject("pictureD20.Image")));
            this.pictureD20.Location = new System.Drawing.Point(86, 62);
            this.pictureD20.Name = "pictureD20";
            this.pictureD20.Size = new System.Drawing.Size(145, 144);
            this.pictureD20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureD20.TabIndex = 10;
            this.pictureD20.TabStop = false;
            // 
            // buttonNormal
            // 
            this.buttonNormal.Location = new System.Drawing.Point(12, 12);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(93, 44);
            this.buttonNormal.TabIndex = 11;
            this.buttonNormal.Text = "Normal Roll";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonAdvantage
            // 
            this.buttonAdvantage.Location = new System.Drawing.Point(111, 12);
            this.buttonAdvantage.Name = "buttonAdvantage";
            this.buttonAdvantage.Size = new System.Drawing.Size(93, 44);
            this.buttonAdvantage.TabIndex = 12;
            this.buttonAdvantage.Text = "Advantage Roll";
            this.buttonAdvantage.UseVisualStyleBackColor = true;
            this.buttonAdvantage.Click += new System.EventHandler(this.buttonAdvantage_Click);
            // 
            // buttonDisadvantage
            // 
            this.buttonDisadvantage.Location = new System.Drawing.Point(210, 12);
            this.buttonDisadvantage.Name = "buttonDisadvantage";
            this.buttonDisadvantage.Size = new System.Drawing.Size(93, 44);
            this.buttonDisadvantage.TabIndex = 13;
            this.buttonDisadvantage.Text = "Disadvantage Roll";
            this.buttonDisadvantage.UseVisualStyleBackColor = true;
            this.buttonDisadvantage.Click += new System.EventHandler(this.buttonDisadvantage_Click);
            // 
            // textBoxd20Result
            // 
            this.textBoxd20Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxd20Result.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxd20Result.Location = new System.Drawing.Point(12, 253);
            this.textBoxd20Result.Name = "textBoxd20Result";
            this.textBoxd20Result.ReadOnly = true;
            this.textBoxd20Result.Size = new System.Drawing.Size(291, 29);
            this.textBoxd20Result.TabIndex = 14;
            this.textBoxd20Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRollNumber
            // 
            this.textBoxRollNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRollNumber.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxRollNumber.Location = new System.Drawing.Point(138, 212);
            this.textBoxRollNumber.Name = "textBoxRollNumber";
            this.textBoxRollNumber.ReadOnly = true;
            this.textBoxRollNumber.Size = new System.Drawing.Size(32, 35);
            this.textBoxRollNumber.TabIndex = 15;
            // 
            // labelRoll20Result
            // 
            this.labelRoll20Result.AutoSize = true;
            this.labelRoll20Result.Location = new System.Drawing.Point(57, 218);
            this.labelRoll20Result.Name = "labelRoll20Result";
            this.labelRoll20Result.Size = new System.Drawing.Size(65, 15);
            this.labelRoll20Result.TabIndex = 16;
            this.labelRoll20Result.Text = "Roll Result:";
            // 
            // buttonD4
            // 
            this.buttonD4.Location = new System.Drawing.Point(319, 121);
            this.buttonD4.Name = "buttonD4";
            this.buttonD4.Size = new System.Drawing.Size(111, 23);
            this.buttonD4.TabIndex = 17;
            this.buttonD4.Text = "Roll D4";
            this.buttonD4.UseVisualStyleBackColor = true;
            this.buttonD4.Click += new System.EventHandler(this.buttonD4_Click);
            // 
            // buttonD6
            // 
            this.buttonD6.Location = new System.Drawing.Point(436, 121);
            this.buttonD6.Name = "buttonD6";
            this.buttonD6.Size = new System.Drawing.Size(110, 23);
            this.buttonD6.TabIndex = 18;
            this.buttonD6.Text = "Roll D6";
            this.buttonD6.UseVisualStyleBackColor = true;
            this.buttonD6.Click += new System.EventHandler(this.buttonD6_Click);
            // 
            // buttonD10
            // 
            this.buttonD10.Location = new System.Drawing.Point(321, 259);
            this.buttonD10.Name = "buttonD10";
            this.buttonD10.Size = new System.Drawing.Size(109, 23);
            this.buttonD10.TabIndex = 19;
            this.buttonD10.Text = "Roll D10";
            this.buttonD10.UseVisualStyleBackColor = true;
            this.buttonD10.Click += new System.EventHandler(this.buttonD10_Click);
            // 
            // buttonD12
            // 
            this.buttonD12.Location = new System.Drawing.Point(437, 259);
            this.buttonD12.Name = "buttonD12";
            this.buttonD12.Size = new System.Drawing.Size(109, 23);
            this.buttonD12.TabIndex = 20;
            this.buttonD12.Text = "Roll D12";
            this.buttonD12.UseVisualStyleBackColor = true;
            this.buttonD12.Click += new System.EventHandler(this.buttonD12_Click);
            // 
            // buttonD8
            // 
            this.buttonD8.Location = new System.Drawing.Point(553, 121);
            this.buttonD8.Name = "buttonD8";
            this.buttonD8.Size = new System.Drawing.Size(109, 23);
            this.buttonD8.TabIndex = 21;
            this.buttonD8.Text = "Roll D8";
            this.buttonD8.UseVisualStyleBackColor = true;
            this.buttonD8.Click += new System.EventHandler(this.buttonD8_Click);
            // 
            // buttonTotals
            // 
            this.buttonTotals.Location = new System.Drawing.Point(668, 150);
            this.buttonTotals.Name = "buttonTotals";
            this.buttonTotals.Size = new System.Drawing.Size(109, 23);
            this.buttonTotals.TabIndex = 22;
            this.buttonTotals.Text = "Total rolls";
            this.buttonTotals.UseVisualStyleBackColor = true;
            this.buttonTotals.Click += new System.EventHandler(this.buttonTotals_Click);
            // 
            // listBoxTotal
            // 
            this.listBoxTotal.FormattingEnabled = true;
            this.listBoxTotal.ItemHeight = 15;
            this.listBoxTotal.Location = new System.Drawing.Point(553, 150);
            this.listBoxTotal.Name = "listBoxTotal";
            this.listBoxTotal.Size = new System.Drawing.Size(109, 124);
            this.listBoxTotal.TabIndex = 23;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(784, 150);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear rolls";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTotal.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTotal.Location = new System.Drawing.Point(726, 93);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 51);
            this.textBoxTotal.TabIndex = 25;
            // 
            // FormDiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 300);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxTotal);
            this.Controls.Add(this.buttonTotals);
            this.Controls.Add(this.buttonD8);
            this.Controls.Add(this.buttonD12);
            this.Controls.Add(this.buttonD10);
            this.Controls.Add(this.buttonD6);
            this.Controls.Add(this.buttonD4);
            this.Controls.Add(this.labelRoll20Result);
            this.Controls.Add(this.textBoxRollNumber);
            this.Controls.Add(this.textBoxd20Result);
            this.Controls.Add(this.buttonDisadvantage);
            this.Controls.Add(this.buttonAdvantage);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.pictureD20);
            this.Controls.Add(this.pictureD12);
            this.Controls.Add(this.pictureD10);
            this.Controls.Add(this.pictureD8);
            this.Controls.Add(this.pictureD6);
            this.Controls.Add(this.pictureD4);
            this.Name = "FormDiceRoller";
            this.Text = "D&D Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureD20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureD4;
        private System.Windows.Forms.PictureBox pictureD6;
        private System.Windows.Forms.PictureBox pictureD8;
        private System.Windows.Forms.PictureBox pictureD10;
        private System.Windows.Forms.PictureBox pictureD12;
        private System.Windows.Forms.PictureBox pictureD20;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonAdvantage;
        private System.Windows.Forms.Button buttonDisadvantage;
        private System.Windows.Forms.TextBox textBoxd20Result;
        private System.Windows.Forms.TextBox textBoxRollNumber;
        private System.Windows.Forms.Label labelRoll20Result;
        private System.Windows.Forms.Button buttonD4;
        private System.Windows.Forms.Button buttonD6;
        private System.Windows.Forms.Button buttonD10;
        private System.Windows.Forms.Button buttonD12;
        private System.Windows.Forms.Button buttonD8;
        private System.Windows.Forms.Button buttonTotals;
        private System.Windows.Forms.ListBox listBoxTotal;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxTotal;
    }
}

