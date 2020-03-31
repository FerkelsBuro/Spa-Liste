namespace UI
{
    partial class Form1
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
            this.SpassListe = new System.Windows.Forms.ListBox();
            this.EintragBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnlegenButton = new System.Windows.Forms.Button();
            this.AuswahlButton = new System.Windows.Forms.Button();
            this.LöschenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpassListe
            // 
            this.SpassListe.FormattingEnabled = true;
            this.SpassListe.Location = new System.Drawing.Point(13, 13);
            this.SpassListe.Name = "SpassListe";
            this.SpassListe.Size = new System.Drawing.Size(328, 160);
            this.SpassListe.TabIndex = 0;
            // 
            // EintragBox
            // 
            this.EintragBox.Location = new System.Drawing.Point(500, 13);
            this.EintragBox.Name = "EintragBox";
            this.EintragBox.Size = new System.Drawing.Size(185, 20);
            this.EintragBox.TabIndex = 1;
            this.EintragBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EintragBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Neuer Eintrag:";
            // 
            // AnlegenButton
            // 
            this.AnlegenButton.Location = new System.Drawing.Point(609, 40);
            this.AnlegenButton.Name = "AnlegenButton";
            this.AnlegenButton.Size = new System.Drawing.Size(75, 23);
            this.AnlegenButton.TabIndex = 3;
            this.AnlegenButton.Text = "Anlegen";
            this.AnlegenButton.UseVisualStyleBackColor = true;
            this.AnlegenButton.Click += new System.EventHandler(this.AnlegenButton_Click);
            // 
            // AuswahlButton
            // 
            this.AuswahlButton.Location = new System.Drawing.Point(237, 179);
            this.AuswahlButton.Name = "AuswahlButton";
            this.AuswahlButton.Size = new System.Drawing.Size(104, 23);
            this.AuswahlButton.TabIndex = 4;
            this.AuswahlButton.Text = "Zufällige Auswahl";
            this.AuswahlButton.UseVisualStyleBackColor = true;
            this.AuswahlButton.Click += new System.EventHandler(this.AuswahlButton_Click);
            // 
            // LöschenButton
            // 
            this.LöschenButton.Location = new System.Drawing.Point(156, 179);
            this.LöschenButton.Name = "LöschenButton";
            this.LöschenButton.Size = new System.Drawing.Size(75, 23);
            this.LöschenButton.TabIndex = 5;
            this.LöschenButton.Text = "Löschen";
            this.LöschenButton.UseVisualStyleBackColor = true;
            this.LöschenButton.Click += new System.EventHandler(this.LöschenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LöschenButton);
            this.Controls.Add(this.AuswahlButton);
            this.Controls.Add(this.AnlegenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EintragBox);
            this.Controls.Add(this.SpassListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SpassListe;
        private System.Windows.Forms.TextBox EintragBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnlegenButton;
        private System.Windows.Forms.Button AuswahlButton;
        private System.Windows.Forms.Button LöschenButton;
    }
}

