namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.LStatusX = new System.Windows.Forms.Label();
            this.L2StatusX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LStatusZ = new System.Windows.Forms.Label();
            this.LStatusY = new System.Windows.Forms.Label();
            this.L2StatusY = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClariry = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.Label();
            this.gbWL = new System.Windows.Forms.GroupBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblMaxClarity = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxV = new System.Windows.Forms.TextBox();
            this.txtMinV = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnInvDis = new System.Windows.Forms.RadioButton();
            this.rbtnInvEn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbtnN = new System.Windows.Forms.RadioButton();
            this.rbtnS = new System.Windows.Forms.RadioButton();
            this.rbtnW = new System.Windows.Forms.RadioButton();
            this.rbtnE = new System.Windows.Forms.RadioButton();
            this.rbtnNE = new System.Windows.Forms.RadioButton();
            this.rbtnSE = new System.Windows.Forms.RadioButton();
            this.rbtnSW = new System.Windows.Forms.RadioButton();
            this.rbtnNW = new System.Windows.Forms.RadioButton();
            this.txt00 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt01 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt02 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblErr = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbhInverse = new System.Windows.Forms.CheckBox();
            this.cbhNorm = new System.Windows.Forms.CheckBox();
            this.cbxLight = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbhL5Gr = new System.Windows.Forms.CheckBox();
            this.cbhLab5WL = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCountDots = new System.Windows.Forms.Label();
            this.lblCentral = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMaxL5 = new System.Windows.Forms.TextBox();
            this.txtMinL5 = new System.Windows.Forms.TextBox();
            this.tBarL5 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbWL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarL5)).BeginInit();
            this.SuspendLayout();
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(24, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(256, 256);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Paint += new System.Windows.Forms.PaintEventHandler(this.AnT_Paint);
            this.AnT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseClick);
            this.AnT.MouseLeave += new System.EventHandler(this.AnT_MouseLeave);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // LStatusX
            // 
            this.LStatusX.AutoSize = true;
            this.LStatusX.Location = new System.Drawing.Point(12, 26);
            this.LStatusX.Name = "LStatusX";
            this.LStatusX.Size = new System.Drawing.Size(32, 13);
            this.LStatusX.TabIndex = 3;
            this.LStatusX.Text = "Xpat:";
            // 
            // L2StatusX
            // 
            this.L2StatusX.AutoSize = true;
            this.L2StatusX.Location = new System.Drawing.Point(11, 19);
            this.L2StatusX.Name = "L2StatusX";
            this.L2StatusX.Size = new System.Drawing.Size(17, 13);
            this.L2StatusX.TabIndex = 4;
            this.L2StatusX.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "L";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LStatusZ);
            this.groupBox1.Controls.Add(this.LStatusY);
            this.groupBox1.Controls.Add(this.LStatusX);
            this.groupBox1.Location = new System.Drawing.Point(289, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates patient";
            // 
            // LStatusZ
            // 
            this.LStatusZ.AutoSize = true;
            this.LStatusZ.Location = new System.Drawing.Point(12, 70);
            this.LStatusZ.Name = "LStatusZ";
            this.LStatusZ.Size = new System.Drawing.Size(32, 13);
            this.LStatusZ.TabIndex = 8;
            this.LStatusZ.Text = "Zpat:";
            // 
            // LStatusY
            // 
            this.LStatusY.AutoSize = true;
            this.LStatusY.Location = new System.Drawing.Point(12, 48);
            this.LStatusY.Name = "LStatusY";
            this.LStatusY.Size = new System.Drawing.Size(32, 13);
            this.LStatusY.TabIndex = 8;
            this.LStatusY.Text = "Ypat:";
            // 
            // L2StatusY
            // 
            this.L2StatusY.AutoSize = true;
            this.L2StatusY.Location = new System.Drawing.Point(11, 37);
            this.L2StatusY.Name = "L2StatusY";
            this.L2StatusY.Size = new System.Drawing.Size(17, 13);
            this.L2StatusY.TabIndex = 8;
            this.L2StatusY.Text = "Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.L2StatusX);
            this.groupBox2.Controls.Add(this.L2StatusY);
            this.groupBox2.Controls.Add(this.lblClariry);
            this.groupBox2.Location = new System.Drawing.Point(290, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordinates pixel";
            // 
            // lblClariry
            // 
            this.lblClariry.AutoSize = true;
            this.lblClariry.Location = new System.Drawing.Point(11, 59);
            this.lblClariry.Name = "lblClariry";
            this.lblClariry.Size = new System.Drawing.Size(41, 13);
            this.lblClariry.TabIndex = 0;
            this.lblClariry.Text = "Clarity: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.PID);
            this.groupBox3.Location = new System.Drawing.Point(289, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 97);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data about patient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Location = new System.Drawing.Point(7, 20);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(54, 13);
            this.PID.TabIndex = 0;
            this.PID.Text = "PatientID:";
            // 
            // gbWL
            // 
            this.gbWL.Controls.Add(this.lblLevel);
            this.gbWL.Controls.Add(this.trackBar2);
            this.gbWL.Controls.Add(this.trackBar1);
            this.gbWL.Controls.Add(this.lblWin);
            this.gbWL.Controls.Add(this.lblMaxClarity);
            this.gbWL.Controls.Add(this.label7);
            this.gbWL.Controls.Add(this.label1);
            this.gbWL.Controls.Add(this.txtMaxV);
            this.gbWL.Controls.Add(this.txtMinV);
            this.gbWL.Location = new System.Drawing.Point(6, 7);
            this.gbWL.Name = "gbWL";
            this.gbWL.Size = new System.Drawing.Size(310, 166);
            this.gbWL.TabIndex = 2;
            this.gbWL.TabStop = false;
            this.gbWL.Text = "Window\\Level";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(25, 116);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(43, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "l (level):";
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar2.Location = new System.Drawing.Point(74, 79);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(183, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Value = 100;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBar1.Location = new System.Drawing.Point(74, 43);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(183, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(5, 138);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(63, 13);
            this.lblWin.TabIndex = 6;
            this.lblWin.Text = "w (window):";
            // 
            // lblMaxClarity
            // 
            this.lblMaxClarity.AutoSize = true;
            this.lblMaxClarity.Location = new System.Drawing.Point(8, 28);
            this.lblMaxClarity.Name = "lblMaxClarity";
            this.lblMaxClarity.Size = new System.Drawing.Size(60, 13);
            this.lblMaxClarity.TabIndex = 4;
            this.lblMaxClarity.Text = "Max clarity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Min %";
            // 
            // txtMaxV
            // 
            this.txtMaxV.Location = new System.Drawing.Point(263, 79);
            this.txtMaxV.Name = "txtMaxV";
            this.txtMaxV.Size = new System.Drawing.Size(41, 20);
            this.txtMaxV.TabIndex = 1;
            this.txtMaxV.TextChanged += new System.EventHandler(this.txtMaxV_TextChanged);
            // 
            // txtMinV
            // 
            this.txtMinV.Location = new System.Drawing.Point(263, 43);
            this.txtMinV.Name = "txtMinV";
            this.txtMinV.Size = new System.Drawing.Size(41, 20);
            this.txtMinV.TabIndex = 0;
            this.txtMinV.TextChanged += new System.EventHandler(this.txtMinV_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnInvDis);
            this.groupBox4.Controls.Add(this.rbtnInvEn);
            this.groupBox4.Location = new System.Drawing.Point(6, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 64);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inversion";
            // 
            // rbtnInvDis
            // 
            this.rbtnInvDis.AutoSize = true;
            this.rbtnInvDis.Checked = true;
            this.rbtnInvDis.Location = new System.Drawing.Point(11, 40);
            this.rbtnInvDis.Name = "rbtnInvDis";
            this.rbtnInvDis.Size = new System.Drawing.Size(60, 17);
            this.rbtnInvDis.TabIndex = 1;
            this.rbtnInvDis.TabStop = true;
            this.rbtnInvDis.Text = "Disable";
            this.rbtnInvDis.UseVisualStyleBackColor = true;
            // 
            // rbtnInvEn
            // 
            this.rbtnInvEn.AutoSize = true;
            this.rbtnInvEn.Location = new System.Drawing.Point(11, 20);
            this.rbtnInvEn.Name = "rbtnInvEn";
            this.rbtnInvEn.Size = new System.Drawing.Size(58, 17);
            this.rbtnInvEn.TabIndex = 0;
            this.rbtnInvEn.Text = "Enable";
            this.rbtnInvEn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // rbtnN
            // 
            this.rbtnN.AutoSize = true;
            this.rbtnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnN.Location = new System.Drawing.Point(107, 7);
            this.rbtnN.Name = "rbtnN";
            this.rbtnN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbtnN.Size = new System.Drawing.Size(36, 21);
            this.rbtnN.TabIndex = 14;
            this.rbtnN.Text = "N";
            this.rbtnN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnN.UseVisualStyleBackColor = true;
            this.rbtnN.CheckedChanged += new System.EventHandler(this.tbtnN_CheckedChanged);
            // 
            // rbtnS
            // 
            this.rbtnS.AutoSize = true;
            this.rbtnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnS.Location = new System.Drawing.Point(86, 162);
            this.rbtnS.Name = "rbtnS";
            this.rbtnS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnS.Size = new System.Drawing.Size(35, 21);
            this.rbtnS.TabIndex = 14;
            this.rbtnS.Text = "S";
            this.rbtnS.UseVisualStyleBackColor = true;
            this.rbtnS.CheckedChanged += new System.EventHandler(this.rbtnS_CheckedChanged);
            // 
            // rbtnW
            // 
            this.rbtnW.AutoSize = true;
            this.rbtnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnW.Location = new System.Drawing.Point(8, 84);
            this.rbtnW.Name = "rbtnW";
            this.rbtnW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnW.Size = new System.Drawing.Size(39, 21);
            this.rbtnW.TabIndex = 14;
            this.rbtnW.Text = "W";
            this.rbtnW.UseVisualStyleBackColor = true;
            this.rbtnW.CheckedChanged += new System.EventHandler(this.rbtnW_CheckedChanged);
            // 
            // rbtnE
            // 
            this.rbtnE.AutoSize = true;
            this.rbtnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnE.Location = new System.Drawing.Point(181, 84);
            this.rbtnE.Name = "rbtnE";
            this.rbtnE.Size = new System.Drawing.Size(35, 21);
            this.rbtnE.TabIndex = 14;
            this.rbtnE.Text = "E";
            this.rbtnE.UseVisualStyleBackColor = true;
            this.rbtnE.CheckedChanged += new System.EventHandler(this.rbtnE_CheckedChanged);
            // 
            // rbtnNE
            // 
            this.rbtnNE.AutoSize = true;
            this.rbtnNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnNE.Location = new System.Drawing.Point(145, 47);
            this.rbtnNE.Name = "rbtnNE";
            this.rbtnNE.Size = new System.Drawing.Size(39, 17);
            this.rbtnNE.TabIndex = 14;
            this.rbtnNE.Text = "NE";
            this.rbtnNE.UseVisualStyleBackColor = true;
            this.rbtnNE.CheckedChanged += new System.EventHandler(this.rbtnNE_CheckedChanged);
            // 
            // rbtnSE
            // 
            this.rbtnSE.AutoSize = true;
            this.rbtnSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnSE.Location = new System.Drawing.Point(146, 126);
            this.rbtnSE.Name = "rbtnSE";
            this.rbtnSE.Size = new System.Drawing.Size(39, 17);
            this.rbtnSE.TabIndex = 14;
            this.rbtnSE.Text = "SE";
            this.rbtnSE.UseVisualStyleBackColor = true;
            this.rbtnSE.CheckedChanged += new System.EventHandler(this.rbtnSE_CheckedChanged);
            // 
            // rbtnSW
            // 
            this.rbtnSW.AutoSize = true;
            this.rbtnSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnSW.Location = new System.Drawing.Point(41, 126);
            this.rbtnSW.Name = "rbtnSW";
            this.rbtnSW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnSW.Size = new System.Drawing.Size(41, 17);
            this.rbtnSW.TabIndex = 14;
            this.rbtnSW.Text = "SW";
            this.rbtnSW.UseVisualStyleBackColor = true;
            this.rbtnSW.CheckedChanged += new System.EventHandler(this.rbtnSW_CheckedChanged);
            // 
            // rbtnNW
            // 
            this.rbtnNW.AutoSize = true;
            this.rbtnNW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnNW.Location = new System.Drawing.Point(41, 48);
            this.rbtnNW.Name = "rbtnNW";
            this.rbtnNW.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnNW.Size = new System.Drawing.Size(41, 17);
            this.rbtnNW.TabIndex = 14;
            this.rbtnNW.Text = "NW";
            this.rbtnNW.UseVisualStyleBackColor = true;
            this.rbtnNW.CheckedChanged += new System.EventHandler(this.rbtnNW_CheckedChanged);
            // 
            // txt00
            // 
            this.txt00.Location = new System.Drawing.Point(224, 64);
            this.txt00.Name = "txt00";
            this.txt00.Size = new System.Drawing.Size(30, 20);
            this.txt00.TabIndex = 15;
            this.txt00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(224, 85);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(30, 20);
            this.txt10.TabIndex = 16;
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt20
            // 
            this.txt20.Location = new System.Drawing.Point(224, 106);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(30, 20);
            this.txt20.TabIndex = 17;
            this.txt20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt01
            // 
            this.txt01.Location = new System.Drawing.Point(256, 64);
            this.txt01.Name = "txt01";
            this.txt01.Size = new System.Drawing.Size(30, 20);
            this.txt01.TabIndex = 18;
            this.txt01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt11
            // 
            this.txt11.Location = new System.Drawing.Point(256, 85);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(30, 20);
            this.txt11.TabIndex = 19;
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt21
            // 
            this.txt21.Location = new System.Drawing.Point(256, 106);
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(30, 20);
            this.txt21.TabIndex = 20;
            this.txt21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt02
            // 
            this.txt02.Location = new System.Drawing.Point(287, 64);
            this.txt02.Name = "txt02";
            this.txt02.Size = new System.Drawing.Size(30, 20);
            this.txt02.TabIndex = 21;
            this.txt02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt12
            // 
            this.txt12.Location = new System.Drawing.Point(287, 85);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(30, 20);
            this.txt12.TabIndex = 22;
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt22
            // 
            this.txt22.Location = new System.Drawing.Point(287, 106);
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(30, 20);
            this.txt22.TabIndex = 23;
            this.txt22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(410, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 274);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbWL);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lab 3";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblErr);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.rbtnCustom);
            this.tabPage2.Controls.Add(this.txt22);
            this.tabPage2.Controls.Add(this.txt12);
            this.tabPage2.Controls.Add(this.rbtnN);
            this.tabPage2.Controls.Add(this.txt02);
            this.tabPage2.Controls.Add(this.rbtnS);
            this.tabPage2.Controls.Add(this.txt21);
            this.tabPage2.Controls.Add(this.rbtnW);
            this.tabPage2.Controls.Add(this.txt11);
            this.tabPage2.Controls.Add(this.rbtnE);
            this.tabPage2.Controls.Add(this.txt01);
            this.tabPage2.Controls.Add(this.rbtnNE);
            this.tabPage2.Controls.Add(this.txt20);
            this.tabPage2.Controls.Add(this.rbtnSE);
            this.tabPage2.Controls.Add(this.txt10);
            this.tabPage2.Controls.Add(this.rbtnSW);
            this.tabPage2.Controls.Add(this.txt00);
            this.tabPage2.Controls.Add(this.rbtnNW);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lab 4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.ForeColor = System.Drawing.Color.Red;
            this.lblErr.Location = new System.Drawing.Point(142, 192);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 13);
            this.lblErr.TabIndex = 26;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(236, 155);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(243, 132);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(60, 17);
            this.rbtnCustom.TabIndex = 24;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.rbtnCustom_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbhInverse);
            this.groupBox5.Controls.Add(this.cbhNorm);
            this.groupBox5.Controls.Add(this.cbxLight);
            this.groupBox5.Location = new System.Drawing.Point(8, 209);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 33);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // cbhInverse
            // 
            this.cbhInverse.AutoSize = true;
            this.cbhInverse.Location = new System.Drawing.Point(135, 11);
            this.cbhInverse.Name = "cbhInverse";
            this.cbhInverse.Size = new System.Drawing.Size(61, 17);
            this.cbhInverse.TabIndex = 29;
            this.cbhInverse.Text = "Inverse";
            this.cbhInverse.UseVisualStyleBackColor = true;
            // 
            // cbhNorm
            // 
            this.cbhNorm.AutoSize = true;
            this.cbhNorm.Location = new System.Drawing.Point(78, 11);
            this.cbhNorm.Name = "cbhNorm";
            this.cbhNorm.Size = new System.Drawing.Size(51, 17);
            this.cbhNorm.TabIndex = 28;
            this.cbhNorm.Text = "Norm";
            this.cbhNorm.UseVisualStyleBackColor = true;
            // 
            // cbxLight
            // 
            this.cbxLight.AutoSize = true;
            this.cbxLight.Location = new System.Drawing.Point(8, 11);
            this.cbxLight.Name = "cbxLight";
            this.cbxLight.Size = new System.Drawing.Size(64, 17);
            this.cbxLight.TabIndex = 27;
            this.cbxLight.Text = "Win\\Lvl";
            this.cbxLight.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbhL5Gr);
            this.tabPage3.Controls.Add(this.cbhLab5WL);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(330, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lab 5";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbhL5Gr
            // 
            this.cbhL5Gr.AutoSize = true;
            this.cbhL5Gr.Location = new System.Drawing.Point(14, 228);
            this.cbhL5Gr.Name = "cbhL5Gr";
            this.cbhL5Gr.Size = new System.Drawing.Size(257, 17);
            this.cbhL5Gr.TabIndex = 7;
            this.cbhL5Gr.Text = "Growing the region relative to the previous region";
            this.cbhL5Gr.UseVisualStyleBackColor = true;
            // 
            // cbhLab5WL
            // 
            this.cbhLab5WL.AutoSize = true;
            this.cbhLab5WL.Location = new System.Drawing.Point(14, 209);
            this.cbhLab5WL.Name = "cbhLab5WL";
            this.cbhLab5WL.Size = new System.Drawing.Size(64, 17);
            this.cbhLab5WL.TabIndex = 0;
            this.cbhLab5WL.Text = "Win\\Lvl";
            this.cbhLab5WL.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCountDots);
            this.groupBox6.Controls.Add(this.lblCentral);
            this.groupBox6.Location = new System.Drawing.Point(14, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 60);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Information of region";
            // 
            // lblCountDots
            // 
            this.lblCountDots.AutoSize = true;
            this.lblCountDots.Location = new System.Drawing.Point(16, 38);
            this.lblCountDots.Name = "lblCountDots";
            this.lblCountDots.Size = new System.Drawing.Size(155, 13);
            this.lblCountDots.TabIndex = 5;
            this.lblCountDots.Text = "How many dots in the region: N";
            // 
            // lblCentral
            // 
            this.lblCentral.AutoSize = true;
            this.lblCentral.Location = new System.Drawing.Point(17, 20);
            this.lblCentral.Name = "lblCentral";
            this.lblCentral.Size = new System.Drawing.Size(144, 13);
            this.lblCentral.TabIndex = 3;
            this.lblCentral.Text = "Central dot in the region: (x,y)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txtMaxL5);
            this.groupBox7.Controls.Add(this.txtMinL5);
            this.groupBox7.Controls.Add(this.tBarL5);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtC);
            this.groupBox7.Location = new System.Drawing.Point(14, 92);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(313, 100);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Parameters";
            // 
            // txtMaxL5
            // 
            this.txtMaxL5.Location = new System.Drawing.Point(265, 50);
            this.txtMaxL5.Name = "txtMaxL5";
            this.txtMaxL5.Size = new System.Drawing.Size(42, 20);
            this.txtMaxL5.TabIndex = 7;
            this.txtMaxL5.TextChanged += new System.EventHandler(this.txtMaxL5_TextChanged);
            // 
            // txtMinL5
            // 
            this.txtMinL5.Location = new System.Drawing.Point(7, 50);
            this.txtMinL5.Name = "txtMinL5";
            this.txtMinL5.Size = new System.Drawing.Size(42, 20);
            this.txtMinL5.TabIndex = 4;
            this.txtMinL5.TextChanged += new System.EventHandler(this.txtMinL5_TextChanged);
            // 
            // tBarL5
            // 
            this.tBarL5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tBarL5.Location = new System.Drawing.Point(55, 47);
            this.tBarL5.Maximum = 200;
            this.tBarL5.Name = "tBarL5";
            this.tBarL5.Size = new System.Drawing.Size(204, 45);
            this.tBarL5.TabIndex = 3;
            this.tBarL5.ValueChanged += new System.EventHandler(this.tBarL5_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "c:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(135, 19);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(48, 20);
            this.txtC.TabIndex = 1;
            this.txtC.Text = "0,5";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Max";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 296);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AnT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DICOM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbWL.ResumeLayout(false);
            this.gbWL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarL5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Label LStatusX;
        private System.Windows.Forms.Label L2StatusX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LStatusZ;
        private System.Windows.Forms.Label LStatusY;
        private System.Windows.Forms.Label L2StatusY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClariry;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnInvDis;
        private System.Windows.Forms.RadioButton rbtnInvEn;
        private System.Windows.Forms.GroupBox gbWL;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblMaxClarity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxV;
        private System.Windows.Forms.TextBox txtMinV;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbtnSW;
        private System.Windows.Forms.RadioButton rbtnSE;
        private System.Windows.Forms.RadioButton rbtnNE;
        private System.Windows.Forms.RadioButton rbtnE;
        private System.Windows.Forms.RadioButton rbtnW;
        private System.Windows.Forms.RadioButton rbtnS;
        private System.Windows.Forms.RadioButton rbtnN;
        private System.Windows.Forms.RadioButton rbtnNW;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt02;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt01;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt00;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.CheckBox cbxLight;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbhNorm;
        private System.Windows.Forms.CheckBox cbhInverse;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCentral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.CheckBox cbhLab5WL;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMaxL5;
        private System.Windows.Forms.TextBox txtMinL5;
        private System.Windows.Forms.TrackBar tBarL5;
        private System.Windows.Forms.CheckBox cbhL5Gr;
        private System.Windows.Forms.Label lblCountDots;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

