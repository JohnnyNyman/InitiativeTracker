namespace TrackerUI
{
    partial class CharacterCreationForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.healthTextBox = new System.Windows.Forms.TextBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.saveCharacterButton = new System.Windows.Forms.Button();
            this.iniModLabel = new System.Windows.Forms.Label();
            this.iniModTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(38, 30);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "ITr";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(64, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 30);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(155, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 28);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // healthTextBox
            // 
            this.healthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.healthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.healthTextBox.ForeColor = System.Drawing.Color.White;
            this.healthTextBox.Location = new System.Drawing.Point(155, 88);
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(46, 28);
            this.healthTextBox.TabIndex = 5;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(64, 88);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(74, 30);
            this.healthLabel.TabIndex = 4;
            this.healthLabel.Text = "Health";
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTextBox.ForeColor = System.Drawing.Color.White;
            this.noteTextBox.Location = new System.Drawing.Point(155, 156);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(224, 28);
            this.noteTextBox.TabIndex = 7;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(64, 149);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(59, 30);
            this.noteLabel.TabIndex = 6;
            this.noteLabel.Text = "Note";
            // 
            // saveCharacterButton
            // 
            this.saveCharacterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.saveCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.saveCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCharacterButton.Location = new System.Drawing.Point(154, 190);
            this.saveCharacterButton.Name = "saveCharacterButton";
            this.saveCharacterButton.Size = new System.Drawing.Size(225, 43);
            this.saveCharacterButton.TabIndex = 8;
            this.saveCharacterButton.Text = "Save Character";
            this.saveCharacterButton.UseVisualStyleBackColor = true;
            this.saveCharacterButton.Click += new System.EventHandler(this.saveCharacterButton_Click);
            // 
            // iniModLabel
            // 
            this.iniModLabel.AutoSize = true;
            this.iniModLabel.Location = new System.Drawing.Point(64, 119);
            this.iniModLabel.Name = "iniModLabel";
            this.iniModLabel.Size = new System.Drawing.Size(85, 30);
            this.iniModLabel.TabIndex = 9;
            this.iniModLabel.Text = "Ini Mod";
            // 
            // iniModTextBox
            // 
            this.iniModTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iniModTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iniModTextBox.ForeColor = System.Drawing.Color.White;
            this.iniModTextBox.Location = new System.Drawing.Point(155, 122);
            this.iniModTextBox.Name = "iniModTextBox";
            this.iniModTextBox.Size = new System.Drawing.Size(46, 28);
            this.iniModTextBox.TabIndex = 10;
            // 
            // CharacterCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(453, 513);
            this.Controls.Add(this.iniModTextBox);
            this.Controls.Add(this.iniModLabel);
            this.Controls.Add(this.saveCharacterButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CharacterCreationForm";
            this.Text = "Character Creation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox healthTextBox;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Button saveCharacterButton;
        private System.Windows.Forms.Label iniModLabel;
        private System.Windows.Forms.TextBox iniModTextBox;
    }
}