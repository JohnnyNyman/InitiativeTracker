namespace TrackerUI
{
    partial class InitiativeTrackerForm
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
            this.initiativeListBox = new System.Windows.Forms.ListBox();
            this.initiativeList = new System.Windows.Forms.Label();
            this.addCharacterButton = new System.Windows.Forms.Button();
            this.initiativeNoteLabel = new System.Windows.Forms.Label();
            this.initiativeHealthLabel = new System.Windows.Forms.Label();
            this.initiativeNameLabel = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.healthAmount = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.addDamageButton = new System.Windows.Forms.Button();
            this.removeCharacterButton = new System.Windows.Forms.Button();
            this.characterDropDown = new System.Windows.Forms.ComboBox();
            this.rollInitiativeButton = new System.Windows.Forms.Button();
            this.characterLabel = new System.Windows.Forms.Label();
            this.damageTextBox = new System.Windows.Forms.TextBox();
            this.iniModLabel = new System.Windows.Forms.Label();
            this.iniMod = new System.Windows.Forms.Label();
            this.sortByIniModButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(38, 30);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "ITr";
            // 
            // initiativeListBox
            // 
            this.initiativeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.initiativeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.initiativeListBox.ForeColor = System.Drawing.Color.White;
            this.initiativeListBox.FormattingEnabled = true;
            this.initiativeListBox.ItemHeight = 30;
            this.initiativeListBox.Location = new System.Drawing.Point(17, 89);
            this.initiativeListBox.Name = "initiativeListBox";
            this.initiativeListBox.Size = new System.Drawing.Size(225, 240);
            this.initiativeListBox.TabIndex = 3;
            this.initiativeListBox.SelectedIndexChanged += new System.EventHandler(this.initiativeListBox_SelectedIndexChanged);
            // 
            // initiativeList
            // 
            this.initiativeList.AutoSize = true;
            this.initiativeList.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeList.Location = new System.Drawing.Point(12, 56);
            this.initiativeList.Name = "initiativeList";
            this.initiativeList.Size = new System.Drawing.Size(133, 30);
            this.initiativeList.TabIndex = 4;
            this.initiativeList.Text = "Initiative List";
            // 
            // addCharacterButton
            // 
            this.addCharacterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.addCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCharacterButton.Location = new System.Drawing.Point(248, 133);
            this.addCharacterButton.Name = "addCharacterButton";
            this.addCharacterButton.Size = new System.Drawing.Size(181, 43);
            this.addCharacterButton.TabIndex = 9;
            this.addCharacterButton.Text = "Add Character";
            this.addCharacterButton.UseVisualStyleBackColor = true;
            this.addCharacterButton.Click += new System.EventHandler(this.addCharacterButton_Click);
            // 
            // initiativeNoteLabel
            // 
            this.initiativeNoteLabel.AutoSize = true;
            this.initiativeNoteLabel.Location = new System.Drawing.Point(12, 431);
            this.initiativeNoteLabel.Name = "initiativeNoteLabel";
            this.initiativeNoteLabel.Size = new System.Drawing.Size(59, 30);
            this.initiativeNoteLabel.TabIndex = 12;
            this.initiativeNoteLabel.Text = "Note";
            this.initiativeNoteLabel.Click += new System.EventHandler(this.noteLabel_Click);
            // 
            // initiativeHealthLabel
            // 
            this.initiativeHealthLabel.AutoSize = true;
            this.initiativeHealthLabel.Location = new System.Drawing.Point(12, 372);
            this.initiativeHealthLabel.Name = "initiativeHealthLabel";
            this.initiativeHealthLabel.Size = new System.Drawing.Size(74, 30);
            this.initiativeHealthLabel.TabIndex = 11;
            this.initiativeHealthLabel.Text = "Health";
            // 
            // initiativeNameLabel
            // 
            this.initiativeNameLabel.AutoSize = true;
            this.initiativeNameLabel.Location = new System.Drawing.Point(12, 342);
            this.initiativeNameLabel.Name = "initiativeNameLabel";
            this.initiativeNameLabel.Size = new System.Drawing.Size(69, 30);
            this.initiativeNameLabel.TabIndex = 10;
            this.initiativeNameLabel.Text = "Name";
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Location = new System.Drawing.Point(87, 342);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(88, 30);
            this.characterName.TabIndex = 14;
            this.characterName.Text = "<none>";
            // 
            // healthAmount
            // 
            this.healthAmount.AutoSize = true;
            this.healthAmount.Location = new System.Drawing.Point(87, 372);
            this.healthAmount.Name = "healthAmount";
            this.healthAmount.Size = new System.Drawing.Size(88, 30);
            this.healthAmount.TabIndex = 15;
            this.healthAmount.Text = "<none>";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(87, 431);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(88, 30);
            this.notes.TabIndex = 16;
            this.notes.Text = "<none>";
            // 
            // addDamageButton
            // 
            this.addDamageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.addDamageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addDamageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDamageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDamageButton.Location = new System.Drawing.Point(248, 394);
            this.addDamageButton.Name = "addDamageButton";
            this.addDamageButton.Size = new System.Drawing.Size(181, 37);
            this.addDamageButton.TabIndex = 18;
            this.addDamageButton.Text = "Add Damage";
            this.addDamageButton.UseVisualStyleBackColor = true;
            this.addDamageButton.Click += new System.EventHandler(this.addDamageButton_Click);
            // 
            // removeCharacterButton
            // 
            this.removeCharacterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.removeCharacterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeCharacterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.removeCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeCharacterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCharacterButton.Location = new System.Drawing.Point(248, 182);
            this.removeCharacterButton.Name = "removeCharacterButton";
            this.removeCharacterButton.Size = new System.Drawing.Size(181, 43);
            this.removeCharacterButton.TabIndex = 20;
            this.removeCharacterButton.Text = "Remove";
            this.removeCharacterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeCharacterButton.UseVisualStyleBackColor = true;
            this.removeCharacterButton.Click += new System.EventHandler(this.removeCharacterButton_Click);
            // 
            // characterDropDown
            // 
            this.characterDropDown.FormattingEnabled = true;
            this.characterDropDown.Location = new System.Drawing.Point(248, 89);
            this.characterDropDown.Name = "characterDropDown";
            this.characterDropDown.Size = new System.Drawing.Size(181, 38);
            this.characterDropDown.TabIndex = 21;
            // 
            // rollInitiativeButton
            // 
            this.rollInitiativeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rollInitiativeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollInitiativeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rollInitiativeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollInitiativeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollInitiativeButton.Location = new System.Drawing.Point(248, 286);
            this.rollInitiativeButton.Name = "rollInitiativeButton";
            this.rollInitiativeButton.Size = new System.Drawing.Size(181, 43);
            this.rollInitiativeButton.TabIndex = 22;
            this.rollInitiativeButton.Text = "Roll Initiative";
            this.rollInitiativeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rollInitiativeButton.UseVisualStyleBackColor = true;
            this.rollInitiativeButton.Click += new System.EventHandler(this.rollInitiativeButton_Click);
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(243, 61);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(105, 25);
            this.characterLabel.TabIndex = 24;
            this.characterLabel.Text = "Characters";
            // 
            // damageTextBox
            // 
            this.damageTextBox.Location = new System.Drawing.Point(248, 353);
            this.damageTextBox.Name = "damageTextBox";
            this.damageTextBox.Size = new System.Drawing.Size(45, 35);
            this.damageTextBox.TabIndex = 26;
            // 
            // iniModLabel
            // 
            this.iniModLabel.AutoSize = true;
            this.iniModLabel.Location = new System.Drawing.Point(12, 401);
            this.iniModLabel.Name = "iniModLabel";
            this.iniModLabel.Size = new System.Drawing.Size(79, 30);
            this.iniModLabel.TabIndex = 27;
            this.iniModLabel.Text = "IniMod";
            // 
            // iniMod
            // 
            this.iniMod.AutoSize = true;
            this.iniMod.Location = new System.Drawing.Point(87, 402);
            this.iniMod.Name = "iniMod";
            this.iniMod.Size = new System.Drawing.Size(88, 30);
            this.iniMod.TabIndex = 28;
            this.iniMod.Text = "<none>";
            // 
            // sortByIniModButton
            // 
            this.sortByIniModButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.sortByIniModButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortByIniModButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.sortByIniModButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortByIniModButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByIniModButton.Location = new System.Drawing.Point(248, 237);
            this.sortByIniModButton.Name = "sortByIniModButton";
            this.sortByIniModButton.Size = new System.Drawing.Size(181, 43);
            this.sortByIniModButton.TabIndex = 29;
            this.sortByIniModButton.Text = "Sort By IniMod";
            this.sortByIniModButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortByIniModButton.UseVisualStyleBackColor = true;
            this.sortByIniModButton.Click += new System.EventHandler(this.sortByIniModButton_Click);
            // 
            // InitiativeTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(441, 481);
            this.Controls.Add(this.sortByIniModButton);
            this.Controls.Add(this.iniMod);
            this.Controls.Add(this.iniModLabel);
            this.Controls.Add(this.damageTextBox);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.rollInitiativeButton);
            this.Controls.Add(this.characterDropDown);
            this.Controls.Add(this.removeCharacterButton);
            this.Controls.Add(this.addDamageButton);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.healthAmount);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.initiativeNoteLabel);
            this.Controls.Add(this.initiativeHealthLabel);
            this.Controls.Add(this.initiativeNameLabel);
            this.Controls.Add(this.addCharacterButton);
            this.Controls.Add(this.initiativeList);
            this.Controls.Add(this.initiativeListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "InitiativeTrackerForm";
            this.Text = "InitiativeTrackerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox initiativeListBox;
        private System.Windows.Forms.Label initiativeList;
        private System.Windows.Forms.Button addCharacterButton;
        private System.Windows.Forms.Label initiativeNoteLabel;
        private System.Windows.Forms.Label initiativeHealthLabel;
        private System.Windows.Forms.Label initiativeNameLabel;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Label healthAmount;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Button addDamageButton;
        private System.Windows.Forms.Button removeCharacterButton;
        private System.Windows.Forms.ComboBox characterDropDown;
        private System.Windows.Forms.Button rollInitiativeButton;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TextBox damageTextBox;
        private System.Windows.Forms.Label iniModLabel;
        private System.Windows.Forms.Label iniMod;
        private System.Windows.Forms.Button sortByIniModButton;
    }
}