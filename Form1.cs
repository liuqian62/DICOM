using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;
using Tao.FreeGlut;
using EvilDICOM.Core;
using EvilDICOM.Core.Element;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        double[] ImOrMass;
        double[] imPosMass;
        double[] PSMass;
        Int16[] resolution;
        Int16 rw;
        Int16 cl;

        //When bitAlloc = 8;
        byte[] PixelDataByte;
        Int32[] result;
        byte maxByte;
        byte minByte;
        
        //When bitAlloc = 16
        ushort[] PDS;
        ushort[] resultShort;
        short maxShort;
        ushort M;

        // lab 4
        int[] E = { -3, -3, 5, -3, 0, 5, -3, -3, 5 };
        int[] NE = { -3, 5, 5, -3, 0, 5, -3, -3, -3 };
        int[] N = { 5, 5, 5, -3, 0, -3, -3, -3, -3 };
        int[] NW = { 5, 5, -3, 5, 0, -3, -3, -3, -3 };
        int[] W = { 5, -3, -3, 5, 0, -3, 5, -3, -3 };
        int[] SE = { -3, -3, -3, 5, 0, -3, 5, 5, -3 };
        int[] S = { -3, -3, -3, -3, 0, -3, 5, 5, 5 };
        int[] SW = { -3, -3, -3, -3, 0, 5, -3, 5, 5 };

        // lab 5
        double MO;
        double SO;
        ushort[] map;
        Queue<int> QueueDots = new Queue<int>();
        double m;
        double v;
        double c;
        int c_dots = 0;

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        public void Form1_Load(object sender, System.EventArgs e)   
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGBA | Glut.GLUT_SINGLE);

            uint texture = 0;
            Gl.glGenTextures(1, out texture);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture);

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Dicom file (*.dcm)|*.dcm";
            ofd.ShowDialog();
            string filepath = ofd.FileName;

            if (ofd.FileName.Equals(""))
            {
                MessageBox.Show("Warning: Problem with file, program will be close.");
                Application.Exit();
            }

            var dcm = DICOMObject.Read(@"" + filepath + "");
            var PatientPosition = dcm.FindFirst("00185100").DData_;
            var PationOrientation = dcm.FindFirst("00200020").DData_;

            var PatientID = dcm.FindFirst("00100020").DData;
            var PatientSex = dcm.FindFirst("00100040").DData;
            var PatientAge = dcm.FindFirst("00101010").DData;
            var PatientWeight = dcm.FindFirst("00101030").DData;

            PID.Text = "PatID: " + Convert.ToString(PatientID);
            label4.Text = "PatSex: " + Convert.ToString(PatientSex);
            label5.Text = "PatAge: " + Convert.ToString(PatientAge);
            label6.Text = "PatWeight: " + Convert.ToString(PatientWeight);

            var imgOr = dcm.FindFirst("00200037").DData_;
            ImOrMass = new double[6];
            imgOr.CopyTo(ImOrMass, 0);

            var imgPos = dcm.FindFirst("00200032").DData_;
            imPosMass = new double[3];
            imgPos.CopyTo(imPosMass, 0);

            var PixelSpacing = dcm.FindFirst("00280030").DData_;
            PSMass = new double[2];
            PixelSpacing.CopyTo(PSMass, 0);

            var bitsAllc = dcm.FindFirst("00280100").DData;
            rw = Convert.ToInt16(dcm.FindFirst("00280010").DData);
            cl = Convert.ToInt16(dcm.FindFirst("00280011").DData);
            resolution = new Int16[] { rw, cl };
            AnT.Size = new System.Drawing.Size(rw, cl);
            var thePixels = dcm.FindFirst("7FE00010").DData_;

            var findMaxInDICOM = dcm.FindFirst("00280107").DData;
            if (Convert.ToInt16(findMaxInDICOM) >= 0)
                maxShort = (short)findMaxInDICOM;

            switch (Convert.ToInt16(bitsAllc))
            {
                case 8:
                    maxByte = byte.MaxValue;
                    minByte = byte.MinValue;
                    PixelDataByte = new byte[rw * cl];
                    result = new Int32[rw * cl];
                    thePixels.CopyTo(PixelDataByte, 0);
                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_LUMINANCE, cl, rw, 0, Gl.GL_LUMINANCE, Gl.GL_UNSIGNED_BYTE, PixelDataByte);
                    MessageBox.Show("Case 8: OK");
                    break;
                case 16:
                    M = ushort.MaxValue;

                    txtMinL5.Text = tBarL5.Minimum.ToString();
                    txtMaxL5.Text = (tBarL5.Maximum * 0.01).ToString();

                    PDS = new ushort[rw *cl * 2];
                    thePixels.CopyTo(PDS, 0);

                    int pix = 0;
                    for (int i = 0; i < rw * cl * 2; i += 2)
                        PDS[pix++] = (ushort)(PDS[i] | PDS[i + 1] << 8); 
                    Array.Clear(PDS, rw * cl, rw * cl);

                    Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_LUMINANCE, cl, rw, 0, Gl.GL_LUMINANCE, Gl.GL_UNSIGNED_SHORT, PDS);
                    break;  
            }

            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glActiveTexture(Gl.GL_TEXTURE0);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glTexCoord2d(0, 0); Gl.glVertex3d(1, -1, 0);
            Gl.glTexCoord2d(0, 1); Gl.glVertex3d(1, 1, 0);
            Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-1, 1, 0);
            Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-1, -1, 0);

            Gl.glEnd();
            Gl.glFlush();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            AnT.Invalidate();
        }

        public ushort fill_new_data(int[] way, 
                                    ushort a00, ushort a01, ushort a02,
                                    ushort a10, ushort a11, ushort a12,
                                    ushort a20, ushort a21, ushort a22)
        {
            int ans = 0;
            ans =   way[0] * a00 + 
                    way[1] * a01 + 
                    way[2] * a02 +
                    way[3] * a10 +
                    way[4] * a11 +
                    way[5] * a12 +
                    way[6] * a20 +
                    way[7] * a21 +
                    way[8] * a22;

            if (ans < 0)
                ans = 0;
            else if (ans > ushort.MaxValue)
                ans = ushort.MaxValue;

            return ((ushort)ans);
        }
        
        public void fill_tmp_arr(int[] way)
        {
            lblErr.Text = "";
            resultShort = new ushort[rw * cl];
            for (int i = 0; i < rw * cl; i++)
            {
                if (i == 0) /* Upper left courner */
                    resultShort[i] = fill_new_data(way,
                        PDS[i],             PDS[i],             PDS[i + 1],
                        PDS[i],             PDS[i],             PDS[i + 1],
                        PDS[i + rw],        PDS[i + rw],        PDS[i + rw + 1]);
                else if (i == rw - 1) /* Upper right corner */
                    resultShort[i] = fill_new_data(way,
                        PDS[rw - 2],        PDS[rw - 1],    PDS[rw - 1], 
                        PDS[rw - 2],        PDS[rw - 1],    PDS[rw - 1], 
                        PDS[i + rw - 1],    PDS[i + rw],    PDS[i + rw]);
                else if (i == rw * cl - cl) /* Lower left corner */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - cl],        PDS[i - cl],    PDS[i - cl + 1], 
                        PDS[i],             PDS[i],         PDS[i + 1], 
                        PDS[i],             PDS[i],         PDS[i + 1]);
                else if (i == rw * cl - 1) /* Lower right corner */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - cl - 1],    PDS[i - cl],    PDS[i - cl], 
                        PDS[i - 1],         PDS[i],         PDS[i], 
                        PDS[i - 1],         PDS[i],         PDS[i]);
                else if (i < rw - 1) /* Upper bound */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - 1],         PDS[i],         PDS[i + 1], 
                        PDS[i - 1],         PDS[i],         PDS[i + 1], 
                        PDS[i + cl - 1],    PDS[i + cl],    PDS[i + cl + 1]);
                else if (i > rw * cl - cl) /* Lower bound */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - cl - 1],    PDS[i - cl],    PDS[i - cl + 1], 
                        PDS[i - 1],         PDS[i],         PDS[i + 1], 
                        PDS[i - 1],         PDS[i],         PDS[i + 1]);
                else if (i % rw == rw - 1) /* Right bound */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - rw - 1],    PDS[i - rw],    PDS[i - rw], 
                        PDS[i - 1],         PDS[i],         PDS[i], 
                        PDS[i + rw - 1],    PDS[i + rw],    PDS[i + rw]);
                else if (i % cl == 0) /* Left bound */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - cl],        PDS[i - cl],    PDS[i - cl + 1], 
                        PDS[i - 1],         PDS[i],         PDS[i + 1], 
                        PDS[i + cl],        PDS[i + cl],    PDS[i + cl + 1]);
                else /* in other case */
                    resultShort[i] = fill_new_data(way,
                        PDS[i - cl - 1],    PDS[i - cl],    PDS[i - cl + 1],
                        PDS[i - 1],         PDS[i],         PDS[i + 1],
                        PDS[i + cl - 1],    PDS[i + cl],    PDS[i + cl + 1]);
            }
            if (cbxLight.Checked)
                win_lvl_l4(resultShort);
            if (cbhNorm.Checked)
                norm(resultShort);
            if (cbhInverse.Checked)
                inverse(resultShort);
            draw_pic(resultShort);
        }

        public void fill_txt(int[] arr)
        {
            txt00.Text = arr[0].ToString();
            txt01.Text = arr[1].ToString();
            txt02.Text = arr[2].ToString();
            txt10.Text = arr[3].ToString();
            txt11.Text = arr[4].ToString();
            txt12.Text = arr[5].ToString();
            txt20.Text = arr[6].ToString();
            txt21.Text = arr[7].ToString();
            txt22.Text = arr[8].ToString();
        }

        public void inverse(ushort[] resultShort)
        {
            for (int j = 0; j < resultShort.Length; j++)
                resultShort[j] = (ushort)(M - resultShort[j]);
        }

        public void norm(ushort[] resultShort)
        {
            int min;
            int max;

            min = 0 * (maxShort / 100);
            max = 100 * (maxShort / 100);
            for (int i = 0; i < resultShort.Length; i++)
                resultShort[i] = (ushort)(((resultShort[i] - min) / (max - min)) * M);
        }

        public void win_lvl_l4(ushort[] resultShort)
        {
            int min;
            int max;

            int win;
            int lvl;

            if (maxShort <= 0)
                findMax(resultShort);

            lblMaxClarity.Text = "Max clarity: " + maxShort.ToString();

            min = (maxShort / 100) * 0;
            max = (maxShort / 100) * 100;

            lvl = (max + min) / 2;
            win = max - min;

            lblWin.Text = "w (window): " + win.ToString();
            lblLevel.Text = "l (level): " + lvl.ToString();

            for (int i = 0; i < resultShort.Length; i++)
            {
                if (resultShort[i] < lvl - win / 2)
                    resultShort[i] = 0;
                else if (resultShort[i] > lvl + win / 2)
                    resultShort[i] = (ushort)M;
                else
                    resultShort[i] = (ushort)(M / win * (resultShort[i] - lvl + win / 2));
            }
        }
        
        public void win_lvl()
        {
            int min;
            int max;

            int win;
            int lvl;

            if (txtMinV.Text == "" || txtMaxV.Text == "")
            {
                MessageBox.Show("You must enter value!");
                return;
            }

            resultShort = new ushort[PDS.Length];

            if (maxShort <= 0)
                findMax(resultShort);

            lblMaxClarity.Text = "Max clarity: " + maxShort.ToString();

            min = (maxShort / 100) * Convert.ToInt32(txtMinV.Text);
            max = (maxShort / 100) * Convert.ToInt32(txtMaxV.Text);

            lvl = (max + min) / 2;
            win = max - min;

            lblWin.Text = "w (window): " + win.ToString();
            lblLevel.Text = "l (level): " + lvl.ToString();

            for (int i = 0; i < PDS.Length; i++)
            {
                if (PDS[i] < lvl - win / 2)
                    resultShort[i] = 0;
                else if (PDS[i] > lvl + win / 2)
                    resultShort[i] = (ushort)M;
                else
                    resultShort[i] = (ushort)(M / win * (PDS[i] - lvl + win / 2));
            }
        }
  
        public void findMax(ushort[] M2)
        {
            for (int i = 0; i < resultShort.Length; i++)
                if (resultShort[i] > maxShort)
                    maxShort = (short)resultShort[i];
        }

        public void apply_inversion()
        {
            resultShort = new ushort[PDS.Length];
            PDS.CopyTo(resultShort, 0);

            if (maxShort <= 0)
                findMax(resultShort);
            for (int j = 0; j < resultShort.Length; j++)
                resultShort[j] = (ushort)(maxShort - resultShort[j]);
        }

        public void draw_pic(ushort[] M1)
        {
            Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_LUMINANCE, cl, rw, 0, Gl.GL_LUMINANCE, Gl.GL_UNSIGNED_SHORT, M1);

            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glActiveTexture(Gl.GL_TEXTURE0);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glTexCoord2d(0, 0); Gl.glVertex3d(1, -1, 0);
            Gl.glTexCoord2d(0, 1); Gl.glVertex3d(1, 1, 0);
            Gl.glTexCoord2d(1, 1); Gl.glVertex3d(-1, 1, 0);
            Gl.glTexCoord2d(1, 0); Gl.glVertex3d(-1, -1, 0);

            Gl.glEnd();
            Gl.glFlush();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            AnT.Invalidate();
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= cl * 2 && e.Y <= rw * 2)
            {
                LStatusX.Text = "Xpat: " + Math.Round((imPosMass[0] + PSMass[1] * resolution[1] * (ImOrMass[0] * 2 * e.X / (float)AnT.Width) + resolution[0] * (ImOrMass[3] * 2 * e.Y / (float)AnT.Height)), 3);
                LStatusY.Text = "Ypat: " + Math.Round((imPosMass[1] + PSMass[0] * resolution[0] * (ImOrMass[4] * 2 * e.Y / (float)AnT.Height) + resolution[1] * (-ImOrMass[1] * e.X / (float)AnT.Width)), 3);
                LStatusZ.Text = "Zpat: " + Math.Round((imPosMass[2] + ImOrMass[2] * 2 * e.X / (float)AnT.Width + ImOrMass[5] * 2 * e.Y / (float)AnT.Height), 3);
                L2StatusX.Text = "X: " + (cl - e.X);
                L2StatusY.Text = "Y: " + (rw - e.Y);
                lblClariry.Text = "Clarity: " + PDS[e.Y * cl + e.X]; 
            }
            else
            {
                LStatusX.Text = "";
                LStatusY.Text = "";
                LStatusZ.Text = "";
                L2StatusX.Text = "";
                L2StatusY.Text = "";
                lblClariry.Text = "";
            }
        }

        private void AnT_MouseLeave(object sender, EventArgs e)
        {
            LStatusX.Text = "";
            LStatusY.Text = "";
            LStatusZ.Text = "";
            L2StatusX.Text = "";
            L2StatusY.Text = "";
            lblClariry.Text = "";
        }

        private void AnT_Paint(object sender, PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, "A", this.Font,
                new Rectangle(new Point(118, 12), this.Size), Color.White);
            TextRenderer.DrawText(e.Graphics, "L", this.Font,
              new Rectangle(new Point(215, 104), this.Size), Color.White);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == trackBar2.Value)
                draw_pic(PDS);
            else
            {
                txtMinV.Text = trackBar1.Value.ToString();
                txtMaxV.Text = trackBar2.Value.ToString();
                win_lvl();
                if (rbtnInvEn.Checked)
                    inverse(resultShort);
                draw_pic(resultShort);
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value == trackBar2.Value)
                draw_pic(PDS);
            else
            {
                txtMinV.Text = trackBar1.Value.ToString();
                txtMaxV.Text = trackBar2.Value.ToString();
                win_lvl();
                if (rbtnInvEn.Checked)
                    inverse(resultShort);
                draw_pic(resultShort);
            }
        }

        private void txtMinV_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMinV.Text) < 0 || Convert.ToInt32(txtMinV.Text) > 100)
            {
                MessageBox.Show("You must enter number between 0...100!");
                txtMinV.Text = "0";
            }
            trackBar1.Value = Convert.ToInt32(txtMinV.Text);
        }

        private void txtMaxV_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMaxV.Text) < 0 || Convert.ToInt32(txtMaxV.Text) > 100)
            {
                MessageBox.Show("You must enter number between 0...100!");
                txtMaxV.Text = "100";
            }
            trackBar2.Value = Convert.ToInt32(txtMaxV.Text);
        }

        private void tbtnN_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(N);
            if (rbtnN.Checked)
                fill_tmp_arr(N);
        }

        private void rbtnNE_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(NE);
            if (rbtnNE.Checked)
                fill_tmp_arr(NE);
        }

        private void rbtnE_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(E);
            if (rbtnE.Checked)
                fill_tmp_arr(E);
        }

        private void rbtnSE_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(SE);
            if (rbtnSE.Checked)
                fill_tmp_arr(SE);
        }

        private void rbtnS_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(S);
            if (rbtnS.Checked)
                fill_tmp_arr(S);
        }

        private void rbtnSW_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(SW);
            if (rbtnSW.Checked)
                fill_tmp_arr(SW);
        }

        private void rbtnW_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(W);
            if (rbtnW.Checked)
                fill_tmp_arr(W);
        }

        private void rbtnNW_CheckedChanged(object sender, EventArgs e)
        {
            fill_txt(NW);
            if (rbtnNW.Checked)
                fill_tmp_arr(NW);
        }

        private void rbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (txt00.Text == "" || txt01.Text == "" || txt02.Text == "" || 
                txt10.Text == "" || txt11.Text == "" || txt12.Text == "" || 
                txt20.Text == "" || txt21.Text == "" || txt22.Text == "")
            {
                lblErr.Text = "TextBox(-s) without data!";
                rbtnCustom.Checked = false;
            }
            else
            {
                int[] cust = new int[] { Convert.ToInt32(txt00.Text), Convert.ToInt32(txt01.Text), Convert.ToInt32(txt02.Text), 
                                         Convert.ToInt32(txt10.Text), Convert.ToInt32(txt11.Text), Convert.ToInt32(txt12.Text), 
                                         Convert.ToInt32(txt20.Text), Convert.ToInt32(txt21.Text), Convert.ToInt32(txt22.Text) };
                if (rbtnCustom.Checked)
                    fill_tmp_arr(cust);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbtnE.Checked = false;
            rbtnN.Checked = false;
            rbtnNE.Checked = false;
            rbtnSE.Checked = false;
            rbtnS.Checked = false;
            rbtnSW.Checked = false;
            rbtnW.Checked = false;
            rbtnNW.Checked = false;
            rbtnCustom.Checked = false;

            txt00.Text = "";
            txt01.Text = "";
            txt02.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txt20.Text = "";
            txt21.Text = "";
            txt22.Text = "";
        }

        public void math_w(int i) // math wait
        {
            MO += PDS[i];
            m = MO / c_dots;
        }

        public void math_s(int i) //stdo
        {
            SO += Math.Pow(PDS[i] - m, 2);
            v = SO / c_dots;
            v = Math.Sqrt(v);
        }

        public void fill_queue(int i)
        {
            if (i % cl != cl - 1) // right
                if (map[i + 1] == 0)
                {
                    map[i + 1] = 2;
                    QueueDots.Enqueue(i + 1);
                }
            if (i % cl != 0) // left
                if (map[i - 1] == 0)
                {
                    map[i - 1] = 2;
                    QueueDots.Enqueue(i - 1);
                }
            if (i / cl != rw - 1) // down
                if (map[i + cl] == 0)
                {
                    map[i + cl] = 2;
                    QueueDots.Enqueue(i + cl);
                }
            if (i / cl != 0) // up
                if (map[i - cl] == 0)
                {
                    map[i - cl] = 2;
                    QueueDots.Enqueue(i - cl);
                }
        }

        public void fill_map(int i)
        {
            math_s(i);
            math_w(i);
            c = Convert.ToDouble(txtC.Text);
            if (Math.Abs((double)PDS[i] - m) <= c * v)
                map[i] = 1;
        }

        public void fill_start_params(int i)
        {
            // fill map equal "1", if dot inside a region
            map[i] = 1;
            map[i + 1] = 1;
            map[i - 1] = 1;
            map[i + cl] = 1;
            map[i + cl + 1] = 1;
            map[i + cl - 1] = 1;
            map[i - cl] = 1;
            map[i - cl + 1] = 1;
            map[i - cl - 1] = 1;

            // calculate MO in start region
            MO = (PDS[i - cl - 1] + PDS[i - cl] + PDS[i - cl + 1] +
                  PDS[i - 1] + PDS[i] + PDS[i + 1] +
                  PDS[i + cl - 1] + PDS[i + cl] + PDS[i + cl + 1]);

            // calculate SO in start region 
            SO += Math.Pow(PDS[i] - m, 2);
            SO += Math.Pow(PDS[i + 1] - m, 2);
            SO += Math.Pow(PDS[i - 1] - m, 2);
            SO += Math.Pow(PDS[i + cl] - m, 2);
            SO += Math.Pow(PDS[i + cl + 1] - m, 2);
            SO += Math.Pow(PDS[i + cl - 1] - m, 2);
            SO += Math.Pow(PDS[i - cl] - m, 2);
            SO += Math.Pow(PDS[i - cl + 1] - m, 2);
            SO += Math.Pow(PDS[i - cl - 1] - m, 2);

            // fill queue
            fill_queue(i + cl);
            fill_queue(i - 1);
            fill_queue(i + 1);
            fill_queue(i - cl);
            fill_queue(i + cl - 1);
            fill_queue(i + cl + 1);
            fill_queue(i - cl - 1);
            fill_queue(i - cl + 1);
        }

        private void AnT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && tabControl1.SelectedIndex == 2)
            {
                int i;
                
                if (cbhL5Gr.Checked == false)
                {
                    SO = 0;
                    MO = 0;
                }
                c_dots = 9;
                resultShort = new ushort[rw * cl];
                lblCentral.Text = "Central dot in the region: (" + (cl - e.X) + "," + (rw - e.Y) + ")";
                
                map = new ushort[rw * cl];
                i = (rw - e.Y) * cl + (cl - e.X);
                fill_start_params(i);

                m = MO / c_dots;
                v = SO / c_dots;
                v = Math.Sqrt(v);

                bool flag;
                if (QueueDots.Count == 0)
                    flag = false;
                else
                    flag = true;
                while (flag)
                {
                    if (QueueDots.Count == 0)
                        flag = false;
                    else
                    {
                        i = QueueDots.Dequeue();
                        fill_map(i);
                        if (map[i] == 1)
                        {
                            c_dots++;
                            fill_queue(i);
                        }
                    }
                }
                lblCountDots.Text = "How many dots in the region: " + c_dots;
                for (int j = 0; j < rw * cl; j++)
                {
                    if (map[j] == 1)
                        resultShort[j] = ushort.MaxValue;
                    else
                        resultShort[j] = ushort.MinValue;
                }
                QueueDots.Clear();
                draw_pic(resultShort);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right && tabControl1.SelectedIndex == 2)
            {
                SO = 0;
                MO = 0;
                lblCentral.Text = "Central dot in the region: (x,y)";
                lblCountDots.Text = "How many dots in the region: 0";
                if (cbhLab5WL.Checked)
                {
                    win_lvl();
                    draw_pic(resultShort);
                }
                else
                    draw_pic(PDS);
            }
            else
                if (tabControl1.SelectedIndex == 2)
                    MessageBox.Show("Only left or right mouse buttons!");
        }

        private void tBarL5_ValueChanged(object sender, EventArgs e)
        {
            txtC.Text = (tBarL5.Value * 0.01).ToString();
        }

        private void txtMinL5_TextChanged(object sender, EventArgs e)
        {
            tBarL5.Minimum = Convert.ToInt32(txtMinL5.Text);
        }

        private void txtMaxL5_TextChanged(object sender, EventArgs e)
        {
            tBarL5.Maximum = Convert.ToInt32(txtMaxL5.Text) * 100;
        }
    }
}