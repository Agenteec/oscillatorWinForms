

using System.Drawing.Imaging;

namespace OscForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNS_Click(object sender, EventArgs e)
        {
            int x = 15, y = 14;
            int NumOfPoints = 1000;
            double W1 = 25, W2 =30;
            double Q1  = 25, Q2 = 30;
            double Oy2 = 400, Oy1 = 100, Ox1 = 1, Ox2 = 0; ;
            if(!string.IsNullOrEmpty(TBW1.Text))
                W1 = Convert.ToDouble(TBW1.Text);
            if (!string.IsNullOrEmpty(TBW2.Text))
                W2 = Convert.ToDouble(TBW2.Text);
            if (!string.IsNullOrEmpty(TBQ1.Text))
                Q1 = Convert.ToDouble(TBQ1.Text);
            if (!string.IsNullOrEmpty(TBQ2.Text))
                Q2 = Convert.ToDouble(TBQ2.Text);
            if (!string.IsNullOrEmpty(TBY2.Text))
                Oy2 = Convert.ToDouble(TBY2.Text);
            if (!string.IsNullOrEmpty(TBY1.Text))
                Oy1 = Convert.ToDouble(TBY1.Text);
            if (!string.IsNullOrEmpty(TBX1.Text))
                Ox1 = Convert.ToDouble(TBX1.Text);
            if (!string.IsNullOrEmpty(TBX2.Text))
                Ox2 = Convert.ToDouble(TBX2.Text);
            Bitmap bmp = new Bitmap(Convert.ToInt32(x*100), Convert.ToInt32(x*100), PixelFormat.Format24bppRgb);
            Rectangle rect = new Rectangle(0, 0, x*100, y*100);
            Graphics g = PBo.CreateGraphics();
            #region Form
            g.FillRectangle(Brushes.White, rect);
            Pen pen = new Pen(Color.DeepSkyBlue, 1f);
            for (int i = 0; i <= x * y/2; i++)
            {
                if (i % 10 == 0)
                {
                    pen.Width = 2f;
                    //MessageBox.Show(i.ToString());
                }
                else { pen.Width = 1f; }
                g.DrawLine(pen, i * 10, y * 100, i * 10, 0);
                g.DrawLine(pen, x * 100, i * 10, 0, i * 10);
            }
            Point[] points = new Point[NumOfPoints];
            pen.Width = 0.2f;
            pen.Color = Color.Black;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i*(int)Ox1+(int)Ox2, (int)((Math.Sin((double)W1* (Math.PI / 180) * i / Q1) + (Math.Sin((double)W2* (Math.PI / 180) * i / Q2))) * Oy1 + Oy2));
            }
            g.DrawLines(pen, points);
            #endregion
            #region BMP
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, rect);
            pen = new Pen(Color.DeepSkyBlue, 1f);
            for (int i = 0; i <= x * y; i++)
            {
                if (i % 10 == 0)
                {
                    pen.Width = 2f;
                }
                else { pen.Width = 1f; }
                g.DrawLine(pen, i * 10, y*100, i * 10, 0);
                g.DrawLine(pen, x*100, i * 10, 0, i * 10);
            }
            pen.Width = 1f;
            pen.Color = Color.Black;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i*(int)Ox1+(int)Ox2, (int)((Math.Sin((double)W1*(Math.PI / 180) * i / Q1) + (Math.Sin((double)W2* (Math.PI / 180) * i / Q2))) * Oy1 + Oy2));
            }
            g.DrawLines(pen, points);
            bmp.Save("Биение.bmp");
            #endregion

        }

        private void TRQ2_Scroll(object sender, EventArgs e)
        {
            TBQ2.Text = (TRQ2.Value).ToString();
        }

        private void TRQ1_Scroll(object sender, EventArgs e)
        {
            TBQ1.Text = TRQ1.Value.ToString();
        }

        private void TRW2_Scroll(object sender, EventArgs e)
        {
            TBW2.Text = TRW2.Value.ToString();
        }

        private void TRW1_Scroll(object sender, EventArgs e)
        {
           TBW1.Text = TRW1.Value.ToString();
        }

        private void TRY2_Scroll(object sender, EventArgs e)
        {
            TBY2.Text = TRY2.Value.ToString();
        }

        private void TRY1_Scroll(object sender, EventArgs e)
        {
            TBY1.Text = TRY1.Value.ToString();
        }

        private void TRX1_Scroll(object sender, EventArgs e)
        {
            TBX1.Text = TRX1.Value.ToString();
        }

        private void TRX2_Scroll(object sender, EventArgs e)
        {
            TBX2.Text = TRX2.Value.ToString();
        }

        private void TRD1_Scroll(object sender, EventArgs e)
        {
            TBD1.Text = TRD1.Value.ToString();
        }

        private void LFBtn_Click(object sender, EventArgs e)
        {
            int x = 15, y = 14;
            int NumOfPoints = 1000;
            double A1 = 30, B1 = 30;
            double A2 = 30, B2 = 30;
            double Oy2 = 400, Oy1 = 8, Ox1 = 8, Ox2 = 400;
            double δ = 1;
            if (!string.IsNullOrEmpty(TBW1.Text))
                A1 = Convert.ToDouble(TBW1.Text);
            if (!string.IsNullOrEmpty(TBW2.Text))
                B1 = Convert.ToDouble(TBW2.Text);
            if (!string.IsNullOrEmpty(TBQ1.Text))
                A2 = Convert.ToDouble(TBQ1.Text);
            if (!string.IsNullOrEmpty(TBQ2.Text))
                B2 = Convert.ToDouble(TBQ2.Text);
            if (!string.IsNullOrEmpty(TBY2.Text))
                Oy2 = Convert.ToDouble(TBY2.Text);
            if (!string.IsNullOrEmpty(TBY1.Text))
                Oy1 = Convert.ToDouble(TBY1.Text);
            if (!string.IsNullOrEmpty(TBX1.Text))
                Ox1 = Convert.ToDouble(TBX1.Text);
            if (!string.IsNullOrEmpty(TBX2.Text))
                Ox2 = Convert.ToDouble(TBX2.Text);
            if (!string.IsNullOrEmpty(TBD1.Text))
                δ = Convert.ToDouble(TBD1.Text);
            Bitmap bmp = new Bitmap(Convert.ToInt32(x*100), Convert.ToInt32(x*100), PixelFormat.Format24bppRgb);
            Rectangle rect = new Rectangle(0, 0, x*100, y*100);
            Graphics g = PBo.CreateGraphics();
            #region Form
            g.FillRectangle(Brushes.White, rect);
            Pen pen = new Pen(Color.DeepSkyBlue, 1f);
            for (int i = 0; i <= x*y/2; i++)
            {
                if (i % 10 == 0)
                {
                    pen.Width = 2f;
                    //MessageBox.Show(i.ToString());
                }
                else { pen.Width = 1f; }
                g.DrawLine(pen, i * 10, y*100, i * 10, 0);
                g.DrawLine(pen, x*100, i * 10, 0, i * 10);
                
            }
            Point[] points = new Point[NumOfPoints];
            pen.Width = 1f;
            pen.Color = Color.Black;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point((int)(A1*Math.Sin(A2 * (Math.PI / 180)*i + δ * (Math.PI / 180)))*(int)Ox1+(int)Ox2, (int)(B1 * (Math.Sin((double)B2 * (Math.PI / 180) * i)) * Oy1 + Oy2));
                
            }
            g.DrawLines(pen, points);
            #endregion
            #region BMP
            g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, rect);
            pen = new Pen(Color.DeepSkyBlue, 1f);
            for (int i = 0; i <= x * y/2; i++)
            {
                if (i % 10 == 0)
                {
                    pen.Width = 2f;
                }
                else { pen.Width = 1f; }
                g.DrawLine(pen, i * 10, y * 100, i * 10, 0);
                g.DrawLine(pen, x * 100, i * 10, 0, i * 10);
            }
            pen.Width = 1f;
            pen.Color = Color.Black;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point((int)((A1 * Math.Sin(A2 * (Math.PI / 180) * i + δ * (Math.PI / 180))) *(int)Ox1)+(int)Ox2, (int)(B1 * (Math.Sin((double)B2 * (Math.PI / 180) * i)) * Oy1 + Oy2));

            }
            g.DrawLines(pen, points);
            bmp.Save("Фигура Лиссажу.bmp");
            #endregion

        }


    }
}
