using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections;




//-----------------------------------------------------------------------------
// Uradio sam samo zadatak 6) E. Hafmanov algoritam nisam uspeo da implementiram
//
// U slucaju problema, na ovom linku imate celu verziju projekta: 
//
//  https://github.com/Jakov1970/MMS-Lab4
//
//------------------------------------------------------------------------------


namespace MMS
{
    public partial class Form1 : Form
    {

        public System.Drawing.Bitmap m_Bitmap;
        public System.Drawing.Bitmap recBitMap;
        private System.Drawing.Bitmap m_Undo;
        private Operator processing;

        public Form1()
        {
            InitializeComponent();
            m_Bitmap = new Bitmap(2, 2);
            processing = new Operator();
        }
                  
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|GIF files(*.gif)|*.gif|PNG files(*.png)|*.png|All valid files|*.bmp/*.jpg/*.gif/*.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                this.pictureBox1.Image = new Bitmap(new Bitmap(openFileDialog.FileName), 530,840);
                this.processing.setImage(new Bitmap(this.pictureBox1.Image));
                this.Invalidate();
                this.sviHistogrami();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                m_Bitmap.Save(saveFileDialog.FileName);
            }
        }

         public void mojaFunkcija()
        {
            if(m_Bitmap!=null)
            this.pictureBox1.Image = new Bitmap(m_Bitmap,540,840);
            if (recBitMap != null) 
         this.pBoxReconstructed.Image = new Bitmap(recBitMap, 540, 840);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void sviHistogrami()
        {
            this.processing.calcHisto(this);
            this.processing.calcHistoBlue(this);
            this.processing.calcHistoRed(this);
            this.processing.calcHistoGreen(this);
        }

        private void orderedDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {

            m_Undo = (Bitmap)m_Bitmap.Clone();

            Bitmap input = m_Bitmap;
            bool fastMode = true;
            string filenameBase = "dither";

            DitherCalculateAndSave(new FloydSteinbergDithering(TrueColorToWebSafeColor, fastMode), input, filenameBase);
            this.Invalidate(); this.mojaFunkcija(); this.processing.setImage(new Bitmap(this.pictureBox1.Image)); this.sviHistogrami();
        }

       public void DitherCalculateAndSave(DitheringBase method, Bitmap input, string filenameWithoutExtension)
        {
            Bitmap dithered = method.DoDithering(input);
            double mse = CalculateMSE(input, dithered);
            double psrn = CalculatePSRN(mse);


            m_Bitmap = dithered;
        }

        private static Color TrueColorToWebSafeColor(Color inputColor)
        {
            Color returnColor = Color.FromArgb((byte)Math.Round(inputColor.R / 51.0) * 51,
                                                (byte)Math.Round(inputColor.G / 51.0) * 51,
                                                (byte)Math.Round(inputColor.B / 51.0) * 51);
            return returnColor;
        }

        private static double CalculatePSRN(double mse)
        {
            return 10 * Math.Log(255 * 255 / mse) / Math.Log(10);
        }

        private static double CalculateMSE(Bitmap original, Bitmap dithered)
        {
            long mseR = 0;
            long mseG = 0;
            long mseB = 0;

            int difference = 0;

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    difference = original.GetPixel(i, j).R - dithered.GetPixel(i, j).R;
                    mseR += (difference * difference);

                    difference = original.GetPixel(i, j).G - dithered.GetPixel(i, j).G;
                    mseG += (difference * difference);

                    difference = original.GetPixel(i, j).B - dithered.GetPixel(i, j).B;
                    mseB += (difference * difference);
                }
            }

            return (double)(mseR + mseG + mseB) / (double)((original.Width * original.Height) * 3);
        }

        private void sierraDitheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Undo = (Bitmap)m_Bitmap.Clone();
            Bitmap input = m_Bitmap;
            bool fastMode = true;
            string filenameBase = "dither";

            DitherCalculateAndSave(new BillAtkinsonAlgoritam(TrueColorToWebSafeColor, fastMode), input, filenameBase);
            this.Invalidate(); this.mojaFunkcija(); this.processing.setImage(new Bitmap(this.pictureBox1.Image)); this.sviHistogrami();
        }
    }
}
