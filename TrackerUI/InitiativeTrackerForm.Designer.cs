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
            this.initiativeEffectsLabel = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.healthAmount = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.Label();
            this.effects = new System.Windows.Forms.Label();
            this.addDamageButton = new System.Windows.Forms.Button();
            this.addEffectButton = new System.Windows.Forms.Button();
            this.removeCharacterButton = new System.Windows.Forms.Button();
            this.characterDropDown = new System.Windows.Forms.ComboBox();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.diceDropDown = new System.Windows.Forms.ComboBox();
            this.characterLabel = new System.Windows.Forms.Label();
            this.diceLabel = new System.Windows.Forms.Label();
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
            this.initiativeNoteLabel.Location = new System.Drawing.Point(12, 419);
            this.initiativeNoteLabel.Name = "initiativeNoteLabel";
            this.initiativeNoteLabel.Size = new System.Drawing.Size(59, 30);
            this.initiativeNoteLabel.TabIndex = 12;
            this.initiativeNoteLabel.Text = "Note";
            this.initiativeNoteLabel.Click += new System.EventHandler(this.noteLabel_Click);
            // 
            // initiativeHealthLabel
            // 
            this.initiativeHealthLabel.AutoSize = true;
            this.initiativeHealthLabel.Location = new System.Drawing.Point(12, 389);
            this.initiativeHealthLabel.Name = "initiativeHealthLabel";
            this.initiativeHealthLabel.Size = new System.Drawing.Size(74, 30);
            this.initiativeHealthLabel.TabIndex = 11;
            this.initiativeHealthLabel.Text = "Health";
            // 
            // initiativeNameLabel
            // 
            this.initiativeNameLabel.AutoSize = true;
            this.initiativeNameLabel.Location = new System.Drawing.Point(12, 359);
            this.initiativeNameLabel.Name = "initiativeNameLabel";
            this.initiativeNameLabel.Size = new System.Drawing.Size(69, 30);
            this.initiativeNameLabel.TabIndex = 10;
            this.initiativeNameLabel.Text = "Name";
            // 
            // initiativeEffectsLabel
            // 
            this.initiativeEffectsLabel.AutoSize = true;
            this.initiativeEffectsLabel.Location = new System.Drawing.Point(12, 449);
            this.initiativeEffectsLabel.Name = "initiativeEffectsLabel";
            this.initiativeEffectsLabel.Size = new System.Drawing.Size(75, 30);
            this.initiativeEffectsLabel.TabIndex = 13;
            this.initiativeEffectsLabel.Text = "Effects";
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Location = new System.Drawing.Point(87, 359);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(88, 30);
            this.characterName.TabIndex = 14;
            this.characterName.Text = "<none>";
            // 
            // healthAmount
            // 
            this.healthAmount.AutoSize = true;
            this.healthAmount.Location = new System.Drawing.Point(87, 389);
            this.healthAmount.Name = "healthAmount";
            this.healthAmount.Size = new System.Drawing.Size(88, 30);
            this.healthAmount.TabIndex = 15;
            this.healthAmount.Text = "<none>";
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(87, 419);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(88, 30);
            this.notes.TabIndex = 16;
            this.notes.Text = "<none>";
            // 
            // effects
            // 
            this.effects.AutoSize = true;
            this.effects.Location = new System.Drawing.Point(87, 449);
            this.effects.Name = "effects";
            this.effects.Size = new System.Drawing.Size(88, 30);
            this.effects.TabIndex = 17;
            this.effects.Text = "<none>";
            // 
            // addDamageButton
            // 
            this.addDamageButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.addDamageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addDamageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDamageButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDamageButton.Location = new System.Drawing.Point(248, 389);
            this.addDamageButton.Name = "addDamageButton";
            this.addDamageButton.Size = new System.Drawing.Size(181, 37);
            this.addDamageButton.TabIndex = 18;
            this.addDamageButton.Text = "Add Damage";
            this.addDamageButton.UseVisualStyleBackColor = true;
            // 
            // addEffectButton
            // 
            this.addEffectButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.addEffectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addEffectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.addEffectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEffectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEffectButton.Location = new System.Drawing.Point(248, 448);
            this.addEffectButton.Name = "addEffectButton";
            this.addEffectButton.Size = new System.Drawing.Size(181, 37);
            this.addEffectButton.TabIndex = 19;
            this.addEffectButton.Text = "Add Effect";
            this.addEffectButton.UseVisualStyleBackColor = true;
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
            // rollDiceButton
            // 
            this.rollDiceButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rollDiceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollDiceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.rollDiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollDiceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.Location = new System.Drawing.Point(248, 304);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(181, 43);
            this.rollDiceButton.TabIndex = 22;
            this.rollDiceButton.Text = "Roll Dice";
            this.rollDiceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rollDiceButton.UseVisualStyleBackColor = true;
            // 
            // diceDropDown
            // 
            this.diceDropDown.FormattingEnabled = true;
            this.diceDropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diceDropDown.Location = new System.Drawing.Point(248, 260);
            this.diceDropDown.Name = "diceDropDown";
            this.diceDropDown.Size = new System.Drawing.Size(181, 38);
            this.diceDropDown.TabIndex = 23;
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
            // diceLabel
            // 
            this.diceLabel.AutoSize = true;
            this.diceLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLabel.Location = new System.Drawing.Point(243, 232);
            this.diceLabel.Name = "diceLabel";
            this.diceLabel.Size = new System.Drawing.Size(50, 25);
            this.diceLabel.TabIndex = 25;
            this.diceLabel.Text = "Dice";
            // 
            // InitiativeTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(441, 530);
            this.Controls.Add(this.diceLabel);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.diceDropDown);
            this.Controls.Add(this.rollDiceButton);
            this.Controls.Add(this.characterDropDown);
            this.Controls.Add(this.removeCharacterButton);
            this.Controls.Add(this.addEffectButton);
            this.Controls.Add(this.addDamageButton);
            this.Controls.Add(this.effects);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.healthAmount);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.initiativeEffectsLabel);
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
        private System.Windows.Forms.Label initiativeEffectsLabel;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Label healthAmount;
        private System.Windows.Forms.Label notes;
        private System.Windows.Forms.Label effects;
        private System.Windows.Forms.Button addDamageButton;
        private System.Windows.Forms.Button addEffectButton;
        private System.Windows.Forms.Button removeCharacterButton;
        private System.Windows.Forms.ComboBox characterDropDown;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.ComboBox diceDropDown;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Label diceLabel;
    }
}