using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawMath
{
    public partial class Form2 : Form
    {
        Function f1 = new Function();
        Pen Function = new Pen(Color.Red, 3);
        Pen blackThick = new Pen(Color.Black, 2);
        Pen blackThin = new Pen(Color.Black, 1);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        ColorDialog XY = new ColorDialog();
        ColorDialog F = new ColorDialog();
        ColorDialog T = new ColorDialog();
        public Form2()
        {
            InitializeComponent();
            BoxDokladnosc.SelectedItem = "Mała dokładność";
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trwa rysowanie wykresu. Proszę czekać.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label6.Text = convertString(txtBoxInput.Text);
            f1.SetInput(label6.Text);

            Bitmap bmp = new Bitmap(fBox.Width,fBox.Height);
            Graphics grap = Graphics.FromImage(bmp);
            
            //setup
            grap.FillRectangle(whiteBrush, new Rectangle(0,0,500,500));
            int j = -10;
            int k = 10;
            for (int i = 0; i <= 501; i += 25)
            {
                grap.DrawLine(blackThin, i, 255, i, 245);
                grap.DrawLine(blackThin, 245, i, 255, i);

                grap.DrawString(j.ToString(), new Font("Calibri", 6), blackBrush, i - 2, 265);
                grap.DrawString(k.ToString(), new Font("Calibri", 6), blackBrush, 235, i - 2);
                j++;
                k--;
            }

            PointF point1 = new PointF();
            PointF point2 = new PointF();

            Dictionary<double, double> Points = new Dictionary<double, double>();
            if(BoxDokladnosc.SelectedIndex == 0)
            {
                Points = f1.Evaluate(1f);
            }
            else if(BoxDokladnosc.SelectedIndex == 1)
            {
                Points = f1.Evaluate(0.1f);
            }
            else Points = f1.Evaluate(0.01f);

            PointF point11 = new PointF();
            PointF point22 = new PointF();
            point11.X = 250;
            point11.Y = 0;
            point22.X = 250;
            point22.Y = 500;
            grap.DrawLine(blackThick, point11, point22);
            point11.X = 0;
            point11.Y = 250;
            point22.X = 500;
            point22.Y = 250;
            grap.DrawLine(blackThick, point11, point22);

            var trygFunc = "";
            if((f1.GetInput().Contains("tg") || f1.GetInput().Contains("tan")) && f1.GetInput().Contains("c") == false)
            {
                trygFunc = "tg";
            }
            else if(f1.GetInput().Contains("ctg") || f1.GetInput().Contains("cotan"))
            {
                trygFunc = "ctg";
            }
            for (int i = 0; i < Points.Count() - 1; i++)
            {
                point1.X = float.Parse(Convert.ToString(Points.Keys.Skip(i).First())) * 25 + 250;
                point1.Y = float.Parse(Convert.ToString(Points.Values.Skip(i).First())) * 25 + 250;

                point2.X = float.Parse(Convert.ToString(Points.Keys.Skip(i + 1).First())) * 25 + 250;
                point2.Y = float.Parse(Convert.ToString(Points.Values.Skip(i + 1).First())) * 25 + 250;
                if (trygFunc != "tg" && trygFunc != "ctg")
                {
                    grap.DrawLine(Function, point1, point2);
                }
                else if(trygFunc == "tg")
                {
                    if(point1.Y > point2.Y)
                    {
                        grap.DrawLine(Function, point1, point2);
                    }
                }
                else if(trygFunc == "ctg")
                {
                    if(point1.Y < point2.Y)
                    {
                        grap.DrawLine(Function, point1, point2);
                    }
                }
            }
            MessageBox.Show("WYKRES NARYSOWANY!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fBox.Image = bmp;
            label6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fBox.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btnXY_Click(object sender, EventArgs e)
        {
            
            if (XY.ShowDialog() == DialogResult.OK)
            {
                btnXY.BackColor = XY.Color;
                blackThick = new Pen(XY.Color, 2);
                blackThin = new Pen(XY.Color, 1);
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (F.ShowDialog() == DialogResult.OK)
            {
                btnF.BackColor = F.Color;
                Function = new Pen(F.Color,3);
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (T.ShowDialog() == DialogResult.OK)
            {
                btnT.BackColor = T.Color;
                whiteBrush = new SolidBrush(T.Color);
            } 
        }

        private void txtBoxInput_TextChanged(object sender, EventArgs e)
        {
            List<char> operators = new List<char>() { '+', '-', '/', '*', '=', ' ', '|', };
            if (txtBoxInput.Text.Contains("^") && operators.Contains(txtBoxInput.Text[txtBoxInput.Text.Length - 1]))
            {
                txtBoxInput.Text = FormatPower(txtBoxInput.Text);
                txtBoxInput.SelectionStart = txtBoxInput.Text.Length;
                txtBoxInput.SelectionLength = 0;
            }
            if(txtBoxInput.Text.Contains("sqrt") && operators.Contains(txtBoxInput.Text[txtBoxInput.Text.Length - 1]))
            {
                txtBoxInput.Text = FormatSqareRoot(txtBoxInput.Text);
                txtBoxInput.SelectionStart = txtBoxInput.Text.Length;
                txtBoxInput.SelectionLength = 0;               
            }
        }

        private string convertString(string input)
        {
            var newInput = input;
            newInput = newInput.Replace("⁰", "^0").Replace("¹", "^1").Replace("²", "^2").Replace("³", "^3").Replace("⁴", "^4").Replace("⁵", "^5").Replace("⁶", "^6").Replace("³", "^7").Replace("³", "^8").Replace("⁹", "^9");
            int i = 1;
            if (newInput.Contains("√"))
            {
                while (true)
                {
                    if (newInput[newInput.IndexOf("√") + i] != ' ')
                    {
                        i++;
                    }
                    else break;
                }
                newInput = newInput.Insert(newInput.IndexOf("√") + i, ")").Replace("√", "sqrt(");
            }

            return newInput;
        }
        static string FormatPower(string sentence)
        {
            string pattern = @"(ctg|tg|cos|sin|\)|\||x|\d)+(\^(\d+))";

            MatchCollection matches = Regex.Matches(sentence, pattern);

            foreach (Match match in matches)
            {
                // string.groups pobiera kolekcję grup dopasowane przez wyrażenie regularne - regex ktory jest wyzej.
                // grupa 2 = np. ^2
                string numberWithPower = match.Groups[2].Value;
                //grupa 3 analogicznie do przypadku wyżej = np. 2
                string number = match.Groups[3].Value;

                string formattedNumber = NumberToSuperscriptPower(number);

                sentence = sentence.Replace(numberWithPower, formattedNumber);
            }
            return sentence;
        }
        static string NumberToSuperscriptPower(string number)
        {
            char[] powers = { '⁰', '¹', '²', '³', '⁴', '⁵', '⁶', '⁷', '⁸', '⁹' };

            StringBuilder output = new StringBuilder();

            foreach (char num in number)
            {
                int index = (int)num - 48;
                output.Append(powers[index]);
            }

            return output.ToString();
        }
        static string FormatSqareRoot(string sentence)
        {
            Console.WriteLine(sentence);
            string pattern = @"sqrt(\((\d+|x)\))";
            MatchCollection matches = Regex.Matches(sentence, pattern);

            foreach(Match match in matches)
            {
                string numberWithSquareRoot = match.Groups[0].Value;
                string number = match.Groups[2].Value;

                sentence = sentence.Replace(numberWithSquareRoot, "√" + number);
            }
            return sentence;
        }
    }
}
