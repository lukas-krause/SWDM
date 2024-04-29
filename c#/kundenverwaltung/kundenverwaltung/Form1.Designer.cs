namespace kundenverwaltung
{
    partial class Form1
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
            textBoxAnrede = new TextBox();
            textBoxName = new TextBox();
            textBoxVorname = new TextBox();
            textBoxAlter = new TextBox();
            textBoxUmsatz = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonSpeichern = new Button();
            buttonAnzeigen = new Button();
            SuspendLayout();
            // 
            // textBoxAnrede
            // 
            textBoxAnrede.Location = new Point(399, 44);
            textBoxAnrede.Name = "textBoxAnrede";
            textBoxAnrede.Size = new Size(136, 23);
            textBoxAnrede.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(399, 95);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(136, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxVorname
            // 
            textBoxVorname.Location = new Point(399, 147);
            textBoxVorname.Name = "textBoxVorname";
            textBoxVorname.Size = new Size(136, 23);
            textBoxVorname.TabIndex = 2;
            // 
            // textBoxAlter
            // 
            textBoxAlter.Location = new Point(399, 191);
            textBoxAlter.Name = "textBoxAlter";
            textBoxAlter.Size = new Size(136, 23);
            textBoxAlter.TabIndex = 3;
            // 
            // textBoxUmsatz
            // 
            textBoxUmsatz.Location = new Point(399, 244);
            textBoxUmsatz.Name = "textBoxUmsatz";
            textBoxUmsatz.Size = new Size(136, 23);
            textBoxUmsatz.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 47);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Anrede";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 150);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Vorname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 194);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Alter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 247);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "Umsatz";
            // 
            // buttonSpeichern
            // 
            buttonSpeichern.Location = new Point(300, 311);
            buttonSpeichern.Name = "buttonSpeichern";
            buttonSpeichern.Size = new Size(94, 23);
            buttonSpeichern.TabIndex = 10;
            buttonSpeichern.Text = "Speichern";
            buttonSpeichern.UseVisualStyleBackColor = true;
            buttonSpeichern.Click += buttonSpeichern_Click;
            // 
            // buttonAnzeigen
            // 
            buttonAnzeigen.Location = new Point(438, 311);
            buttonAnzeigen.Name = "buttonAnzeigen";
            buttonAnzeigen.Size = new Size(97, 23);
            buttonAnzeigen.TabIndex = 11;
            buttonAnzeigen.Text = "Anzeigen";
            buttonAnzeigen.UseVisualStyleBackColor = true;
            buttonAnzeigen.Click += buttonAnzeigen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAnzeigen);
            Controls.Add(buttonSpeichern);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxUmsatz);
            Controls.Add(textBoxAlter);
            Controls.Add(textBoxVorname);
            Controls.Add(textBoxName);
            Controls.Add(textBoxAnrede);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAnrede;
        private TextBox textBoxName;
        private TextBox textBoxVorname;
        private TextBox textBoxAlter;
        private TextBox textBoxUmsatz;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonSpeichern;
        private Button buttonAnzeigen;
    }
}
