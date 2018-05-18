namespace Sv1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtSelectImage = new MetroFramework.Controls.MetroTile();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.tbHighTH = new MetroFramework.Controls.MetroTextBox();
            this.tbLowTH = new MetroFramework.Controls.MetroTextBox();
            this.tbGausMask = new MetroFramework.Controls.MetroTextBox();
            this.tbSigma = new MetroFramework.Controls.MetroTextBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.btnNext = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.panelUnos = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPrevious = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.mtClear = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lbState = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.mtSaveImage = new MetroFramework.Controls.MetroTile();
            this.mtAbout = new MetroFramework.Controls.MetroTile();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.panelUnos.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtSelectImage
            // 
            this.mtSelectImage.ActiveControl = null;
            this.mtSelectImage.Location = new System.Drawing.Point(47, 292);
            this.mtSelectImage.Name = "mtSelectImage";
            this.mtSelectImage.Size = new System.Drawing.Size(110, 87);
            this.mtSelectImage.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtSelectImage.TabIndex = 0;
            this.mtSelectImage.Text = "Select Image";
            this.mtSelectImage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtSelectImage.TileImage = global::Sv1.Properties.Resources.load;
            this.mtSelectImage.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSelectImage.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtSelectImage.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSelectImage.UseSelectable = true;
            this.mtSelectImage.UseTileImage = true;
            this.mtSelectImage.Click += new System.EventHandler(this.mtSelectImage_Click);
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(21, 36);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(286, 225);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 1;
            this.pb1.TabStop = false;
            // 
            // tbHighTH
            // 
            // 
            // 
            // 
            this.tbHighTH.CustomButton.Image = null;
            this.tbHighTH.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.tbHighTH.CustomButton.Name = "";
            this.tbHighTH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbHighTH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHighTH.CustomButton.TabIndex = 1;
            this.tbHighTH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbHighTH.CustomButton.UseSelectable = true;
            this.tbHighTH.CustomButton.Visible = false;
            this.tbHighTH.Lines = new string[] {
        "20"};
            this.tbHighTH.Location = new System.Drawing.Point(138, 75);
            this.tbHighTH.MaxLength = 32767;
            this.tbHighTH.Name = "tbHighTH";
            this.tbHighTH.PasswordChar = '\0';
            this.tbHighTH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbHighTH.SelectedText = "";
            this.tbHighTH.SelectionLength = 0;
            this.tbHighTH.SelectionStart = 0;
            this.tbHighTH.Size = new System.Drawing.Size(53, 23);
            this.tbHighTH.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHighTH.TabIndex = 2;
            this.tbHighTH.Text = "20";
            this.tbHighTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHighTH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbHighTH.UseSelectable = true;
            this.tbHighTH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbHighTH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbLowTH
            // 
            // 
            // 
            // 
            this.tbLowTH.CustomButton.Image = null;
            this.tbLowTH.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.tbLowTH.CustomButton.Name = "";
            this.tbLowTH.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbLowTH.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLowTH.CustomButton.TabIndex = 1;
            this.tbLowTH.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbLowTH.CustomButton.UseSelectable = true;
            this.tbLowTH.CustomButton.Visible = false;
            this.tbLowTH.Lines = new string[] {
        "10"};
            this.tbLowTH.Location = new System.Drawing.Point(138, 104);
            this.tbLowTH.MaxLength = 32767;
            this.tbLowTH.Name = "tbLowTH";
            this.tbLowTH.PasswordChar = '\0';
            this.tbLowTH.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLowTH.SelectedText = "";
            this.tbLowTH.SelectionLength = 0;
            this.tbLowTH.SelectionStart = 0;
            this.tbLowTH.Size = new System.Drawing.Size(53, 23);
            this.tbLowTH.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbLowTH.TabIndex = 3;
            this.tbLowTH.Text = "10";
            this.tbLowTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLowTH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbLowTH.UseSelectable = true;
            this.tbLowTH.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbLowTH.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbGausMask
            // 
            // 
            // 
            // 
            this.tbGausMask.CustomButton.Image = null;
            this.tbGausMask.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.tbGausMask.CustomButton.Name = "";
            this.tbGausMask.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbGausMask.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGausMask.CustomButton.TabIndex = 1;
            this.tbGausMask.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbGausMask.CustomButton.UseSelectable = true;
            this.tbGausMask.CustomButton.Visible = false;
            this.tbGausMask.Lines = new string[] {
        "5"};
            this.tbGausMask.Location = new System.Drawing.Point(138, 147);
            this.tbGausMask.MaxLength = 32767;
            this.tbGausMask.Name = "tbGausMask";
            this.tbGausMask.PasswordChar = '\0';
            this.tbGausMask.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbGausMask.SelectedText = "";
            this.tbGausMask.SelectionLength = 0;
            this.tbGausMask.SelectionStart = 0;
            this.tbGausMask.Size = new System.Drawing.Size(53, 23);
            this.tbGausMask.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbGausMask.TabIndex = 4;
            this.tbGausMask.Text = "5";
            this.tbGausMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGausMask.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbGausMask.UseSelectable = true;
            this.tbGausMask.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbGausMask.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbSigma
            // 
            // 
            // 
            // 
            this.tbSigma.CustomButton.Image = null;
            this.tbSigma.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.tbSigma.CustomButton.Name = "";
            this.tbSigma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSigma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSigma.CustomButton.TabIndex = 1;
            this.tbSigma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSigma.CustomButton.UseSelectable = true;
            this.tbSigma.CustomButton.Visible = false;
            this.tbSigma.Lines = new string[] {
        "1"};
            this.tbSigma.Location = new System.Drawing.Point(138, 176);
            this.tbSigma.MaxLength = 32767;
            this.tbSigma.Name = "tbSigma";
            this.tbSigma.PasswordChar = '\0';
            this.tbSigma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSigma.SelectedText = "";
            this.tbSigma.SelectionLength = 0;
            this.tbSigma.SelectionStart = 0;
            this.tbSigma.Size = new System.Drawing.Size(53, 23);
            this.tbSigma.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSigma.TabIndex = 5;
            this.tbSigma.Text = "1";
            this.tbSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSigma.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSigma.UseSelectable = true;
            this.tbSigma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSigma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pb2
            // 
            this.pb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb2.Location = new System.Drawing.Point(21, 36);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(286, 225);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Image = null;
            this.btnNext.Location = new System.Drawing.Point(170, 67);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 37);
            this.btnNext.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Start";
            this.btnNext.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnNext.UseSelectable = true;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelUnos
            // 
            this.panelUnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUnos.Controls.Add(this.metroLabel5);
            this.panelUnos.Controls.Add(this.metroLabel4);
            this.panelUnos.Controls.Add(this.metroLabel3);
            this.panelUnos.Controls.Add(this.metroLabel2);
            this.panelUnos.Controls.Add(this.metroLabel1);
            this.panelUnos.Controls.Add(this.tbHighTH);
            this.panelUnos.Controls.Add(this.tbSigma);
            this.panelUnos.Controls.Add(this.tbLowTH);
            this.panelUnos.Controls.Add(this.tbGausMask);
            this.panelUnos.HorizontalScrollbarBarColor = true;
            this.panelUnos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUnos.HorizontalScrollbarSize = 10;
            this.panelUnos.Location = new System.Drawing.Point(47, 67);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(225, 219);
            this.panelUnos.Style = MetroFramework.MetroColorStyle.Blue;
            this.panelUnos.TabIndex = 8;
            this.panelUnos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelUnos.VerticalScrollbarBarColor = true;
            this.panelUnos.VerticalScrollbarHighlightOnWheel = false;
            this.panelUnos.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(193, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Enter the values on image load:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(21, 176);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Sigma";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 147);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Gauss Mask";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Low Treshold";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "High Treshold";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = null;
            this.btnPrevious.Location = new System.Drawing.Point(16, 67);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(136, 37);
            this.btnPrevious.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPrevious.UseSelectable = true;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // mtClear
            // 
            this.mtClear.ActiveControl = null;
            this.mtClear.Location = new System.Drawing.Point(164, 292);
            this.mtClear.Name = "mtClear";
            this.mtClear.Size = new System.Drawing.Size(108, 87);
            this.mtClear.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtClear.TabIndex = 10;
            this.mtClear.Text = "Clear";
            this.mtClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtClear.TileImage = global::Sv1.Properties.Resources.clear;
            this.mtClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtClear.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtClear.UseSelectable = true;
            this.mtClear.UseStyleColors = true;
            this.mtClear.UseTileImage = true;
            this.mtClear.Click += new System.EventHandler(this.mtClear_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(21, 14);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(97, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Loaded image:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.pb1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(327, 67);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(328, 279);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.pb2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(712, 67);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(328, 279);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel2.TabIndex = 13;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(21, 14);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Filtered image:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 45);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(220, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "Change steps by clicking on buttons:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(63, 11);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(54, 19);
            this.lbState.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbState.TabIndex = 15;
            this.lbState.Text = "Waiting";
            this.lbState.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbState.UseStyleColors = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(16, 11);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(41, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "State:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 67);
            this.progressBar.Maximum = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(286, 37);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.progressBar.TabIndex = 17;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(21, 11);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(155, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Filtering image progress:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // mtSaveImage
            // 
            this.mtSaveImage.ActiveControl = null;
            this.mtSaveImage.Location = new System.Drawing.Point(47, 385);
            this.mtSaveImage.Name = "mtSaveImage";
            this.mtSaveImage.Size = new System.Drawing.Size(111, 87);
            this.mtSaveImage.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtSaveImage.TabIndex = 19;
            this.mtSaveImage.Text = "Save Image";
            this.mtSaveImage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtSaveImage.TileImage = global::Sv1.Properties.Resources.save;
            this.mtSaveImage.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSaveImage.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtSaveImage.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtSaveImage.UseSelectable = true;
            this.mtSaveImage.UseStyleColors = true;
            this.mtSaveImage.UseTileImage = true;
            this.mtSaveImage.Click += new System.EventHandler(this.mtSaveImage_Click);
            // 
            // mtAbout
            // 
            this.mtAbout.ActiveControl = null;
            this.mtAbout.Location = new System.Drawing.Point(164, 385);
            this.mtAbout.Name = "mtAbout";
            this.mtAbout.Size = new System.Drawing.Size(108, 87);
            this.mtAbout.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtAbout.TabIndex = 20;
            this.mtAbout.Text = "About";
            this.mtAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtAbout.TileImage = global::Sv1.Properties.Resources.about;
            this.mtAbout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAbout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtAbout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtAbout.UseSelectable = true;
            this.mtAbout.UseStyleColors = true;
            this.mtAbout.UseTileImage = true;
            this.mtAbout.Click += new System.EventHandler(this.mtAbout_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel10);
            this.metroPanel3.Controls.Add(this.progressBar);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(327, 354);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(328, 118);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel3.TabIndex = 21;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.Controls.Add(this.btnNext);
            this.metroPanel4.Controls.Add(this.btnPrevious);
            this.metroPanel4.Controls.Add(this.lbState);
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(712, 354);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(328, 118);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel4.TabIndex = 22;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1082, 513);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.mtAbout);
            this.Controls.Add(this.mtSaveImage);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.mtSelectImage);
            this.Name = "Main";
            this.Text = "Canny";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTile mtSelectImage;
        private System.Windows.Forms.PictureBox pb1;
        private MetroFramework.Controls.MetroTextBox tbHighTH;
        private MetroFramework.Controls.MetroTextBox tbLowTH;
        private MetroFramework.Controls.MetroTextBox tbGausMask;
        private MetroFramework.Controls.MetroTextBox tbSigma;
        private System.Windows.Forms.PictureBox pb2;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnNext;
        private MetroFramework.Controls.MetroPanel panelUnos;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnPrevious;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lbState;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile mtSaveImage;
        private MetroFramework.Controls.MetroTile mtAbout;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
    }
}

