
namespace DrawMath
{
    partial class Form2
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
            this.panelFill = new System.Windows.Forms.Panel();
            this.panelFill1 = new System.Windows.Forms.Panel();
            this.fBox = new System.Windows.Forms.PictureBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BoxDokladnosc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFill.SuspendLayout();
            this.panelFill1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fBox)).BeginInit();
            this.panelDown.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.panelFill1);
            this.panelFill.Controls.Add(this.panelDown);
            this.panelFill.Controls.Add(this.panelRight);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 0);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1000, 565);
            this.panelFill.TabIndex = 1;
            // 
            // panelFill1
            // 
            this.panelFill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFill1.Controls.Add(this.fBox);
            this.panelFill1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill1.Location = new System.Drawing.Point(0, 0);
            this.panelFill1.Name = "panelFill1";
            this.panelFill1.Size = new System.Drawing.Size(718, 518);
            this.panelFill1.TabIndex = 4;
            // 
            // fBox
            // 
            this.fBox.BackColor = System.Drawing.Color.White;
            this.fBox.Location = new System.Drawing.Point(109, 9);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(500, 500);
            this.fBox.TabIndex = 2;
            this.fBox.TabStop = false;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelDown.Controls.Add(this.button2);
            this.panelDown.Controls.Add(this.btnDraw);
            this.panelDown.Controls.Add(this.label1);
            this.panelDown.Controls.Add(this.txtBoxInput);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 518);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(718, 47);
            this.panelDown.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(595, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Eksportuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDraw.Location = new System.Drawing.Point(475, 5);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(120, 35);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Rysuj";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz funkcje:";
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxInput.Location = new System.Drawing.Point(175, 9);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(294, 31);
            this.txtBoxInput.TabIndex = 0;
            this.txtBoxInput.TextChanged += new System.EventHandler(this.txtBoxInput_TextChanged);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.BoxDokladnosc);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.btnXY);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.btnT);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.btnF);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(718, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(282, 565);
            this.panelRight.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(45, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 259);
            this.label3.TabIndex = 1;
            this.label3.Text = "Przykłady wpisywania funkcji:\r\ny = 2*x + 5\r\ny = x+2\r\nf(x) = x^2\r\nsin(x)+2\r\nAby wp" +
    "isać potęgę:\r\nx^2\r\nAby wpisać pierwiastek:\r\nsqrt(x)\r\nAby wpisać wartość bezwzglę" +
    "dna:\r\n|x|\r\n";
            // 
            // btnXY
            // 
            this.btnXY.BackColor = System.Drawing.Color.Black;
            this.btnXY.Location = new System.Drawing.Point(118, 44);
            this.btnXY.Name = "btnXY";
            this.btnXY.Size = new System.Drawing.Size(20, 20);
            this.btnXY.TabIndex = 3;
            this.btnXY.UseVisualStyleBackColor = false;
            this.btnXY.Click += new System.EventHandler(this.btnXY_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wybiesz kolory wykresu";
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.White;
            this.btnT.Location = new System.Drawing.Point(118, 92);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(20, 20);
            this.btnT.TabIndex = 4;
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "LEGENDA";
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.Red;
            this.btnF.Location = new System.Drawing.Point(118, 68);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(20, 20);
            this.btnF.TabIndex = 5;
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 121);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kolor osi x i y:\r\nKolor funkcji:\r\nKolor tła:\r\nAby zmienić kolory należy kliknąć p" +
    "rzycisk rysuj";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG Images |*.png";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // BoxDokladnosc
            // 
            this.BoxDokladnosc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxDokladnosc.FormattingEnabled = true;
            this.BoxDokladnosc.Items.AddRange(new object[] {
            "Mała dokładność",
            "Średnia dokładność",
            "Duża dokładność"});
            this.BoxDokladnosc.Location = new System.Drawing.Point(8, 209);
            this.BoxDokladnosc.Name = "BoxDokladnosc";
            this.BoxDokladnosc.Size = new System.Drawing.Size(259, 21);
            this.BoxDokladnosc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(2, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "WYBIERZ DOKŁADNOŚĆ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 565);
            this.Controls.Add(this.panelFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelFill.ResumeLayout(false);
            this.panelFill1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fBox)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.panelDown.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelFill1;
        private System.Windows.Forms.PictureBox fBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnXY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BoxDokladnosc;
    }
}