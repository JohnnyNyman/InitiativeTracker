namespace TrackerUI
{
    partial class CharacterListForm
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
            this.createCharacterButton = new System.Windows.Forms.Button();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.deleteCharacterButton = new System.Windows.Forms.Button();
            this.startInitiativeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(38, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "ITr";
            this.headerLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // createCharacterButton
            // 
            this.createCharacterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.createCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.createCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCharacterButton.Location = new System.Drawing.Point(119, 46);
            this.createCharacterButton.Name = "createCharacterButton";
            this.createCharacterButton.Size = new System.Drawing.Size(225, 43);
            this.createCharacterButton.TabIndex = 1;
            this.createCharacterButton.Text = "Create Character";
            this.createCharacterButton.UseVisualStyleBackColor = true;
            // 
            // characterListBox
            // 
            this.characterListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.characterListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.characterListBox.ForeColor = System.Drawing.Color.White;
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.ItemHeight = 30;
            this.characterListBox.Location = new System.Drawing.Point(119, 95);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(225, 240);
            this.characterListBox.TabIndex = 2;
            this.characterListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // deleteCharacterButton
            // 
            this.deleteCharacterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.deleteCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.deleteCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCharacterButton.Location = new System.Drawing.Point(119, 341);
            this.deleteCharacterButton.Name = "deleteCharacterButton";
            this.deleteCharacterButton.Size = new System.Drawing.Size(225, 43);
            this.deleteCharacterButton.TabIndex = 3;
            this.deleteCharacterButton.Text = "Delete Character";
            this.deleteCharacterButton.UseVisualStyleBackColor = true;
            // 
            // startInitiativeButton
            // 
            this.startInitiativeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.startInitiativeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startInitiativeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.startInitiativeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startInitiativeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startInitiativeButton.Location = new System.Drawing.Point(119, 390);
            this.startInitiativeButton.Name = "startInitiativeButton";
            this.startInitiativeButton.Size = new System.Drawing.Size(225, 43);
            this.startInitiativeButton.TabIndex = 4;
            this.startInitiativeButton.Text = "Start Initiative";
            this.startInitiativeButton.UseVisualStyleBackColor = true;
            // 
            // CharacterListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(466, 535);
            this.Controls.Add(this.startInitiativeButton);
            this.Controls.Add(this.deleteCharacterButton);
            this.Controls.Add(this.characterListBox);
            this.Controls.Add(this.createCharacterButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CharacterListForm";
            this.Text = "Initiative Tracker Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createCharacterButton;
        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.Button deleteCharacterButton;
        private System.Windows.Forms.Button startInitiativeButton;
    }
}

