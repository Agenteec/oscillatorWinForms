namespace OscForm
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
            this.BTNS = new System.Windows.Forms.Button();
            this.PBo = new System.Windows.Forms.PictureBox();
            this.TBW1 = new System.Windows.Forms.TextBox();
            this.TBW2 = new System.Windows.Forms.TextBox();
            this.W1Lbl = new System.Windows.Forms.Label();
            this.W2LBL = new System.Windows.Forms.Label();
            this.TRW1 = new System.Windows.Forms.TrackBar();
            this.TRW2 = new System.Windows.Forms.TrackBar();
            this.TRQ2 = new System.Windows.Forms.TrackBar();
            this.TRQ1 = new System.Windows.Forms.TrackBar();
            this.Q2LBL = new System.Windows.Forms.Label();
            this.Q1LBL = new System.Windows.Forms.Label();
            this.TBQ2 = new System.Windows.Forms.TextBox();
            this.TBQ1 = new System.Windows.Forms.TextBox();
            this.TRY1 = new System.Windows.Forms.TrackBar();
            this.TRY2 = new System.Windows.Forms.TrackBar();
            this.Y1LBL = new System.Windows.Forms.Label();
            this.Y2LBL = new System.Windows.Forms.Label();
            this.TBY1 = new System.Windows.Forms.TextBox();
            this.TBY2 = new System.Windows.Forms.TextBox();
            this.LFBtn = new System.Windows.Forms.Button();
            this.A1Lbl = new System.Windows.Forms.Label();
            this.B1Lbl = new System.Windows.Forms.Label();
            this.B2Lbl = new System.Windows.Forms.Label();
            this.A2Lbl = new System.Windows.Forms.Label();
            this.TRX1 = new System.Windows.Forms.TrackBar();
            this.X1LBL = new System.Windows.Forms.Label();
            this.TBX1 = new System.Windows.Forms.TextBox();
            this.TRX2 = new System.Windows.Forms.TrackBar();
            this.X2LBL = new System.Windows.Forms.Label();
            this.TBX2 = new System.Windows.Forms.TextBox();
            this.TRD1 = new System.Windows.Forms.TrackBar();
            this.D1LBL = new System.Windows.Forms.Label();
            this.TBD1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRD1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNS
            // 
            this.BTNS.Location = new System.Drawing.Point(1010, 12);
            this.BTNS.Name = "BTNS";
            this.BTNS.Size = new System.Drawing.Size(94, 29);
            this.BTNS.TabIndex = 0;
            this.BTNS.Text = "Биение";
            this.BTNS.UseVisualStyleBackColor = true;
            this.BTNS.Click += new System.EventHandler(this.BTNS_Click);
            // 
            // PBo
            // 
            this.PBo.Location = new System.Drawing.Point(3, 12);
            this.PBo.Name = "PBo";
            this.PBo.Size = new System.Drawing.Size(1001, 908);
            this.PBo.TabIndex = 1;
            this.PBo.TabStop = false;
            // 
            // TBW1
            // 
            this.TBW1.Location = new System.Drawing.Point(1052, 47);
            this.TBW1.Name = "TBW1";
            this.TBW1.Size = new System.Drawing.Size(125, 27);
            this.TBW1.TabIndex = 2;
            // 
            // TBW2
            // 
            this.TBW2.Location = new System.Drawing.Point(1052, 132);
            this.TBW2.Name = "TBW2";
            this.TBW2.Size = new System.Drawing.Size(125, 27);
            this.TBW2.TabIndex = 3;
            // 
            // W1Lbl
            // 
            this.W1Lbl.AutoSize = true;
            this.W1Lbl.Location = new System.Drawing.Point(1015, 47);
            this.W1Lbl.Name = "W1Lbl";
            this.W1Lbl.Size = new System.Drawing.Size(31, 20);
            this.W1Lbl.TabIndex = 4;
            this.W1Lbl.Text = "W1";
            // 
            // W2LBL
            // 
            this.W2LBL.AutoSize = true;
            this.W2LBL.Location = new System.Drawing.Point(1015, 132);
            this.W2LBL.Name = "W2LBL";
            this.W2LBL.Size = new System.Drawing.Size(31, 20);
            this.W2LBL.TabIndex = 5;
            this.W2LBL.Text = "W2";
            // 
            // TRW1
            // 
            this.TRW1.Location = new System.Drawing.Point(1005, 80);
            this.TRW1.Maximum = 1000;
            this.TRW1.Name = "TRW1";
            this.TRW1.Size = new System.Drawing.Size(300, 56);
            this.TRW1.TabIndex = 6;
            this.TRW1.Scroll += new System.EventHandler(this.TRW1_Scroll);
            // 
            // TRW2
            // 
            this.TRW2.Location = new System.Drawing.Point(1005, 168);
            this.TRW2.Maximum = 1000;
            this.TRW2.Name = "TRW2";
            this.TRW2.Size = new System.Drawing.Size(300, 56);
            this.TRW2.TabIndex = 7;
            this.TRW2.Scroll += new System.EventHandler(this.TRW2_Scroll);
            // 
            // TRQ2
            // 
            this.TRQ2.Location = new System.Drawing.Point(1010, 343);
            this.TRQ2.Maximum = 1000;
            this.TRQ2.Name = "TRQ2";
            this.TRQ2.Size = new System.Drawing.Size(300, 56);
            this.TRQ2.TabIndex = 13;
            this.TRQ2.Scroll += new System.EventHandler(this.TRQ2_Scroll);
            // 
            // TRQ1
            // 
            this.TRQ1.Location = new System.Drawing.Point(1010, 255);
            this.TRQ1.Maximum = 1000;
            this.TRQ1.Name = "TRQ1";
            this.TRQ1.Size = new System.Drawing.Size(300, 56);
            this.TRQ1.TabIndex = 12;
            this.TRQ1.Scroll += new System.EventHandler(this.TRQ1_Scroll);
            // 
            // Q2LBL
            // 
            this.Q2LBL.AutoSize = true;
            this.Q2LBL.Location = new System.Drawing.Point(1018, 307);
            this.Q2LBL.Name = "Q2LBL";
            this.Q2LBL.Size = new System.Drawing.Size(28, 20);
            this.Q2LBL.TabIndex = 11;
            this.Q2LBL.Text = "Q2";
            // 
            // Q1LBL
            // 
            this.Q1LBL.AutoSize = true;
            this.Q1LBL.Location = new System.Drawing.Point(1018, 222);
            this.Q1LBL.Name = "Q1LBL";
            this.Q1LBL.Size = new System.Drawing.Size(28, 20);
            this.Q1LBL.TabIndex = 10;
            this.Q1LBL.Text = "Q1";
            // 
            // TBQ2
            // 
            this.TBQ2.Location = new System.Drawing.Point(1052, 307);
            this.TBQ2.Name = "TBQ2";
            this.TBQ2.Size = new System.Drawing.Size(125, 27);
            this.TBQ2.TabIndex = 9;
            // 
            // TBQ1
            // 
            this.TBQ1.Location = new System.Drawing.Point(1052, 222);
            this.TBQ1.Name = "TBQ1";
            this.TBQ1.Size = new System.Drawing.Size(125, 27);
            this.TBQ1.TabIndex = 8;
            // 
            // TRY1
            // 
            this.TRY1.Location = new System.Drawing.Point(1010, 511);
            this.TRY1.Maximum = 1000;
            this.TRY1.Name = "TRY1";
            this.TRY1.Size = new System.Drawing.Size(300, 56);
            this.TRY1.TabIndex = 19;
            this.TRY1.Scroll += new System.EventHandler(this.TRY1_Scroll);
            // 
            // TRY2
            // 
            this.TRY2.Location = new System.Drawing.Point(1010, 423);
            this.TRY2.Maximum = 1000;
            this.TRY2.Name = "TRY2";
            this.TRY2.Size = new System.Drawing.Size(300, 56);
            this.TRY2.TabIndex = 18;
            this.TRY2.Scroll += new System.EventHandler(this.TRY2_Scroll);
            // 
            // Y1LBL
            // 
            this.Y1LBL.AutoSize = true;
            this.Y1LBL.Location = new System.Drawing.Point(1146, 478);
            this.Y1LBL.Name = "Y1LBL";
            this.Y1LBL.Size = new System.Drawing.Size(35, 20);
            this.Y1LBL.TabIndex = 17;
            this.Y1LBL.Text = "Oy1";
            // 
            // Y2LBL
            // 
            this.Y2LBL.AutoSize = true;
            this.Y2LBL.Location = new System.Drawing.Point(1146, 390);
            this.Y2LBL.Name = "Y2LBL";
            this.Y2LBL.Size = new System.Drawing.Size(35, 20);
            this.Y2LBL.TabIndex = 16;
            this.Y2LBL.Text = "Oy2";
            // 
            // TBY1
            // 
            this.TBY1.Location = new System.Drawing.Point(1015, 478);
            this.TBY1.Name = "TBY1";
            this.TBY1.Size = new System.Drawing.Size(125, 27);
            this.TBY1.TabIndex = 15;
            // 
            // TBY2
            // 
            this.TBY2.Location = new System.Drawing.Point(1015, 390);
            this.TBY2.Name = "TBY2";
            this.TBY2.Size = new System.Drawing.Size(125, 27);
            this.TBY2.TabIndex = 14;
            // 
            // LFBtn
            // 
            this.LFBtn.Location = new System.Drawing.Point(1110, 12);
            this.LFBtn.Name = "LFBtn";
            this.LFBtn.Size = new System.Drawing.Size(94, 29);
            this.LFBtn.TabIndex = 20;
            this.LFBtn.Text = "Фигуры Л";
            this.LFBtn.UseVisualStyleBackColor = true;
            this.LFBtn.Click += new System.EventHandler(this.LFBtn_Click);
            // 
            // A1Lbl
            // 
            this.A1Lbl.AutoSize = true;
            this.A1Lbl.Location = new System.Drawing.Point(1183, 47);
            this.A1Lbl.Name = "A1Lbl";
            this.A1Lbl.Size = new System.Drawing.Size(19, 20);
            this.A1Lbl.TabIndex = 21;
            this.A1Lbl.Text = "A";
            // 
            // B1Lbl
            // 
            this.B1Lbl.AutoSize = true;
            this.B1Lbl.Location = new System.Drawing.Point(1183, 132);
            this.B1Lbl.Name = "B1Lbl";
            this.B1Lbl.Size = new System.Drawing.Size(18, 20);
            this.B1Lbl.TabIndex = 22;
            this.B1Lbl.Text = "B";
            // 
            // B2Lbl
            // 
            this.B2Lbl.AutoSize = true;
            this.B2Lbl.Location = new System.Drawing.Point(1183, 307);
            this.B2Lbl.Name = "B2Lbl";
            this.B2Lbl.Size = new System.Drawing.Size(18, 20);
            this.B2Lbl.TabIndex = 24;
            this.B2Lbl.Text = "b";
            // 
            // A2Lbl
            // 
            this.A2Lbl.AutoSize = true;
            this.A2Lbl.Location = new System.Drawing.Point(1183, 222);
            this.A2Lbl.Name = "A2Lbl";
            this.A2Lbl.Size = new System.Drawing.Size(17, 20);
            this.A2Lbl.TabIndex = 23;
            this.A2Lbl.Text = "a";
            // 
            // TRX1
            // 
            this.TRX1.Location = new System.Drawing.Point(1010, 591);
            this.TRX1.Maximum = 1000;
            this.TRX1.Name = "TRX1";
            this.TRX1.Size = new System.Drawing.Size(300, 56);
            this.TRX1.TabIndex = 27;
            this.TRX1.Scroll += new System.EventHandler(this.TRX1_Scroll);
            // 
            // X1LBL
            // 
            this.X1LBL.AutoSize = true;
            this.X1LBL.Location = new System.Drawing.Point(1146, 558);
            this.X1LBL.Name = "X1LBL";
            this.X1LBL.Size = new System.Drawing.Size(35, 20);
            this.X1LBL.TabIndex = 26;
            this.X1LBL.Text = "Ox1";
            // 
            // TBX1
            // 
            this.TBX1.Location = new System.Drawing.Point(1015, 558);
            this.TBX1.Name = "TBX1";
            this.TBX1.Size = new System.Drawing.Size(125, 27);
            this.TBX1.TabIndex = 25;
            // 
            // TRX2
            // 
            this.TRX2.Location = new System.Drawing.Point(1010, 672);
            this.TRX2.Maximum = 1000;
            this.TRX2.Name = "TRX2";
            this.TRX2.Size = new System.Drawing.Size(300, 56);
            this.TRX2.TabIndex = 30;
            this.TRX2.Scroll += new System.EventHandler(this.TRX2_Scroll);
            // 
            // X2LBL
            // 
            this.X2LBL.AutoSize = true;
            this.X2LBL.Location = new System.Drawing.Point(1145, 639);
            this.X2LBL.Name = "X2LBL";
            this.X2LBL.Size = new System.Drawing.Size(35, 20);
            this.X2LBL.TabIndex = 29;
            this.X2LBL.Text = "Ox2";
            // 
            // TBX2
            // 
            this.TBX2.Location = new System.Drawing.Point(1015, 639);
            this.TBX2.Name = "TBX2";
            this.TBX2.Size = new System.Drawing.Size(125, 27);
            this.TBX2.TabIndex = 28;
            // 
            // TRD1
            // 
            this.TRD1.Location = new System.Drawing.Point(1010, 744);
            this.TRD1.Maximum = 1000;
            this.TRD1.Name = "TRD1";
            this.TRD1.Size = new System.Drawing.Size(300, 56);
            this.TRD1.TabIndex = 33;
            this.TRD1.Scroll += new System.EventHandler(this.TRD1_Scroll);
            // 
            // D1LBL
            // 
            this.D1LBL.AutoSize = true;
            this.D1LBL.Location = new System.Drawing.Point(1145, 711);
            this.D1LBL.Name = "D1LBL";
            this.D1LBL.Size = new System.Drawing.Size(18, 20);
            this.D1LBL.TabIndex = 32;
            this.D1LBL.Text = "δ";
            // 
            // TBD1
            // 
            this.TBD1.Location = new System.Drawing.Point(1015, 711);
            this.TBD1.Name = "TBD1";
            this.TBD1.Size = new System.Drawing.Size(125, 27);
            this.TBD1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 967);
            this.Controls.Add(this.TRD1);
            this.Controls.Add(this.D1LBL);
            this.Controls.Add(this.TBD1);
            this.Controls.Add(this.TRX2);
            this.Controls.Add(this.X2LBL);
            this.Controls.Add(this.TBX2);
            this.Controls.Add(this.TRX1);
            this.Controls.Add(this.X1LBL);
            this.Controls.Add(this.TBX1);
            this.Controls.Add(this.B2Lbl);
            this.Controls.Add(this.A2Lbl);
            this.Controls.Add(this.B1Lbl);
            this.Controls.Add(this.A1Lbl);
            this.Controls.Add(this.LFBtn);
            this.Controls.Add(this.TRY1);
            this.Controls.Add(this.TRY2);
            this.Controls.Add(this.Y1LBL);
            this.Controls.Add(this.Y2LBL);
            this.Controls.Add(this.TBY1);
            this.Controls.Add(this.TBY2);
            this.Controls.Add(this.TRQ2);
            this.Controls.Add(this.TRQ1);
            this.Controls.Add(this.Q2LBL);
            this.Controls.Add(this.Q1LBL);
            this.Controls.Add(this.TBQ2);
            this.Controls.Add(this.TBQ1);
            this.Controls.Add(this.TRW2);
            this.Controls.Add(this.TRW1);
            this.Controls.Add(this.W2LBL);
            this.Controls.Add(this.W1Lbl);
            this.Controls.Add(this.TBW2);
            this.Controls.Add(this.TBW1);
            this.Controls.Add(this.PBo);
            this.Controls.Add(this.BTNS);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRD1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTNS;
        private PictureBox PBo;
        private TextBox TBW1;
        private TextBox TBW2;
        private Label W1Lbl;
        private Label W2LBL;
        private TrackBar TRW1;
        private TrackBar TRW2;
        private TrackBar TRQ2;
        private TrackBar TRQ1;
        private Label Q2LBL;
        private Label Q1LBL;
        private TextBox TBQ2;
        private TextBox TBQ1;
        private TrackBar TRY1;
        private TrackBar TRY2;
        private Label Y1LBL;
        private Label Y2LBL;
        private TextBox TBY1;
        private TextBox TBY2;
        private Button LFBtn;
        private Label A1Lbl;
        private Label B1Lbl;
        private Label B2Lbl;
        private Label A2Lbl;
        private TrackBar TRX1;
        private Label X1LBL;
        private TextBox TBX1;
        private TrackBar TRX2;
        private Label X2LBL;
        private TextBox TBX2;
        private TrackBar TRD1;
        private Label D1LBL;
        private TextBox TBD1;
    }
}