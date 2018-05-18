using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Sv1
{
    public partial class Main : MetroForm
    {
        //public arguments

        Canny CannyData;
        int counter;

        float TH, TL, Sigma;
        int MaskSize;

        public Main()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
        }

        public void Start()
        {
            counter = 0;

            btnNext.Enabled = true;
            btnPrevious.Enabled = false;
            panelUnos.Enabled = true;
            lbState.Text = "Waiting";
            progressBar.Value = 0;
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (counter > 1)
            {
                counter = counter - 2;
                progressBar.Value -= 20;
                btnNext_Click(sender, e);
            }

            if(btnNext.Enabled == false)
            {
                btnNext.Enabled = true;
            }
        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            pb1.Image = null;
            pb2.Image = null;
            Start();
            btnNext.Enabled = false;
            btnNext.Text = "Start";
        }

        private void mtSaveImage_Click(object sender, EventArgs e)
        {
            try 
            {
                if (pb2.Image == null)
                {
                    MetroMessageBox.Show(this, "Start Canny edge detector", "There is no image to save.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SaveFileDialog SaveDialog = new SaveFileDialog();
                    SaveDialog.Filter = "BMP file|*.bmp";
                    SaveDialog.FileName = lbState.Text.ToString();
                    SaveDialog.Title = "Save an BMP File";
                    if (SaveDialog.ShowDialog() == DialogResult.OK)
                    {
                        pb2.Image.Save(SaveDialog.FileName);
                    }
                    MetroMessageBox.Show(this, "", "Image Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ex)
            {
                MetroMessageBox.Show(this, "Exception has trown in saving image to disk: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtAbout_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Students Dragana Vučic 14575 and Marko Stevanović 14522 \r Faculty of Electronic Engineering, University of Niš \r Computer Science Department \r Metodi i Sistemi za obradu Signala \r Januar 2015", "Information about our team", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mtSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graphics (*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.FilterIndex = 5;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    pb1.Image = Bitmap.FromFile(ofd.FileName);
                    Start();
                }
                catch (ApplicationException ex)
                {
                    MetroMessageBox.Show(this, "Exception has trown in reading image from disk: " +ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (counter == 0)
            {
                TH = (float)Convert.ToDouble(tbHighTH.Text);
                TL = (float)Convert.ToDouble(tbLowTH.Text);

                MaskSize = Convert.ToInt32(tbGausMask.Text);
                Sigma = (float)Convert.ToDouble(tbSigma.Text);
                CannyData = new Canny((Bitmap)pb1.Image, TH, TL, Sigma, MaskSize);

                pb2.Image = CannyData.DispImg(CannyData.FilteredImage);
                lbState.Text = "Gaussian Filtered Image";
                counter++;

                panelUnos.Enabled = false;
                btnPrevious.Enabled = false;
                progressBar.PerformStep();
                btnNext.Text = "Next";
            }
            else if(counter == 1)
            {
                pb2.Image = CannyData.DispImg(CannyData.NotMax);
                lbState.Text = "Found Image Gradients";

                btnPrevious.Enabled = true;
                counter++;
                progressBar.PerformStep();
            }
            else if(counter == 2)
            {
                pb2.Image = CannyData.DispImg(CannyData.HighGradients);
                lbState.Text = "Found Local Maxima";

                counter++;
                progressBar.PerformStep();
            }
            else if(counter == 3)
            {
                pb2.Image = CannyData.DispImg(CannyData.LowGradients);
                lbState.Text = "Edges Determined by Thresholding";

                counter++;
                progressBar.PerformStep();
            }
            else if(counter == 4)
            {
                pb2.Image = CannyData.DispImg(CannyData.EdgePosition);
                lbState.Text = "Canny Final Filtered Image";

                counter++;
                btnNext.Enabled = false;
                progressBar.PerformStep();
            }
        }
    }
}