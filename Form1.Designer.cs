namespace Max_BMI
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
            textBoxKg = new TextBox();
            textBoxM = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            labelErgebnis = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBoxKg
            // 
            textBoxKg.Location = new Point(176, 177);
            textBoxKg.Name = "textBoxKg";
            textBoxKg.Size = new Size(100, 27);
            textBoxKg.TabIndex = 0;
            textBoxKg.TextChanged += textBox1_TextChanged;
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(456, 177);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(152, 27);
            textBoxM.TabIndex = 2;
            textBoxM.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(319, 251);
            button1.Name = "button1";
            button1.Size = new Size(122, 41);
            button1.TabIndex = 5;
            button1.Text = "Berechnen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 154);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 7;
            label1.Text = "Gewicht in Kg";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 154);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 8;
            label2.Text = "Körpergröße in Meter";
            // 
            // labelErgebnis
            // 
            labelErgebnis.Font = new Font("Segoe UI", 12F);
            labelErgebnis.Location = new Point(12, 340);
            labelErgebnis.Name = "labelErgebnis";
            labelErgebnis.ReadOnly = true;
            labelErgebnis.Size = new Size(776, 34);
            labelErgebnis.TabIndex = 6;
            labelErgebnis.TextChanged += labelErgebnis_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(128, 23);
            label3.Name = "label3";
            label3.Size = new Size(546, 25);
            label3.TabIndex = 9;
            label3.Text = "| Bitte geben sie in die Leeren Felder ihre benötigten daten ein |";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mann", "Frau" });
            comboBox1.Location = new Point(304, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelErgebnis);
            Controls.Add(button1);
            Controls.Add(textBoxM);
            Controls.Add(textBoxKg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxKg;
        private TextBox textBoxM;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox labelErgebnis;
        private Label label3;
        private ComboBox comboBox1;
    }
}
