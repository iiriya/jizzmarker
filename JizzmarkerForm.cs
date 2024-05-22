//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="JizzmarkerForm.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the main form.</summary>
// <remarks>
//      Iiriya's Jizzmarker.
//      
//      This project contains a watermarker for generic images.
//      
//      This solution and all its components its owned by Lucio Benini and his companies.
//      This solution is designed in C# for Microsoft .NET Framework and works only under the Windows Operative System.
//      For Mono or other platforms integrations contact the main project owner.
//      The designer and his companies aren't responsible for any damage due to unauthorized installations or usages.
//      
//      This project is created and designed under Microsoft .NET 4.0 environment and runtime and requires the runtime version 4.0 or later.
//      
//      This project is licensed. Copyright © Lucio Benini 2015. All Rights Reserved.
// </remarks>
//-----------------------------------------------------------------------------------------------------------------------

namespace Iiriya.Apps.Jizzmarker
{
    #region Using Directives
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// The main form.
    /// </summary>
    public partial class JizzmarkerForm : Form, IJizzmarkerForm
    {
        #region JizzmarkerForm Fields
        /// <summary>
        /// The form resources
        /// </summary>
        private ComponentResourceManager formResources = new ComponentResourceManager(typeof(JizzmarkerForm));

        /// <summary>
        /// A value indicating whether the worker is busy.
        /// </summary>
        private bool isBusy = false;

        /// <summary>
        /// The logo position.
        /// </summary>
        private ContentAlignment logoPosizion = ContentAlignment.MiddleCenter;

        /// <summary>
        /// The output format.
        /// </summary>
        private OutputFormat outputFormat = OutputFormat.Jpeg;

        /// <summary>
        /// The files.
        /// </summary>
        private string[] files;

        /// <summary>
        /// The output quality.
        /// </summary>
        private long quality = 100L;

        /// <summary>
        /// The logo margin.
        /// </summary>
        private int logoMargin = 3;

        /// <summary>
        /// The relative logo size.
        /// </summary>
        private int logoSize = 100;

        /// <summary>
        /// The logo opacity percentage.
        /// </summary>
        private int logoOpacity = 100;

        /// <summary>
        /// The count of loaded files.
        /// </summary>
        private int? filesLoaded = null;

        /// <summary>
        /// The current processing file.
        /// </summary>
        private int? filesCurrent = null;
        #endregion

        #region JizzmarkerForm Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Jizzmarker.JizzmarkerForm">JizzmarkerForm</see> class.
        /// </summary>
        public JizzmarkerForm()
        {
            this.InitializeComponent();
            
            this.SourceButton.Click += this.SourceButtonClick;
            this.DestinationButton.Click += this.DestinationButtonClick;
            this.LogoButton.Click += this.LogoButtonClick;
            this.ResizeCheckBox.CheckedChanged += this.ResizeCheckBoxCheckedChanged;
            this.CenterPostionButton.Click += this.PostionButtonClick;
            this.LeftPostionButton.Click += this.PostionButtonClick;
            this.RightPostionButton.Click += this.PostionButtonClick;
            this.TopPostionButton.Click += this.PostionButtonClick;
            this.TopLeftPostionButton.Click += this.PostionButtonClick;
            this.TopRightPostionButton.Click += this.PostionButtonClick;
            this.BottomPostionButton.Click += this.PostionButtonClick;
            this.BottomLeftPostionButton.Click += this.PostionButtonClick;
            this.BottomRightPostionButton.Click += this.PostionButtonClick;
            this.SubmitButton.Click += this.SubmitButtonClick;
            this.BackgroundWorker.DoWork += this.DoWork;
            this.BackgroundWorker.ProgressChanged += this.ProgressChanged;
            this.BackgroundWorker.RunWorkerCompleted += this.RunWorkerCompleted;
            this.QualityBar.ValueChanged += this.QualityBarValueChanged;
            this.MarginBar.ValueChanged += this.MarginBarValueChanged;
            this.LogoSizeBar.ValueChanged += this.LogoSizeBarValueChanged;
            this.OpacityBar.ValueChanged += this.OpacityBarValueChanged;
            this.FormatComboBox.SelectedValueChanged += this.FormatChanged;
            
            this.QualityBar.Value = (int)this.quality;
            this.MarginBar.Value = this.logoMargin;
            this.LogoSizeBar.Value = this.logoSize;
            this.OpacityBar.Value = this.logoOpacity;

            this.FormatComboBox.Items.Add(OutputFormat.Jpeg);
            this.FormatComboBox.Items.Add(OutputFormat.Bitmap);
            this.FormatComboBox.Items.Add(OutputFormat.Gif);
            this.FormatComboBox.Items.Add(OutputFormat.Png);
            this.FormatComboBox.Items.Add(OutputFormat.Tiff);
            this.FormatComboBox.SelectedItem = OutputFormat.Jpeg;

            Helpers.UpdateLabelPercentage(this.QualityBarLabel, (int)this.quality, this.formResources);
            Helpers.UpdateLabelPercentage(this.MarginBarLabel, this.logoMargin, this.formResources);
            Helpers.UpdateLabelPercentage(this.LogoSizeBarLabel, this.logoSize, this.formResources);
            Helpers.UpdateLabelPercentage(this.OpacityBarLabel, this.logoSize, this.formResources);

            this.CheckAlignmentStatus();
        }
        #endregion

        #region JizzmarkerForm Properties
        /// <summary>
        /// Gets or sets the logo position.
        /// </summary>
        public ContentAlignment LogoPosizion
        {
            get
            {
                return this.logoPosizion;
            }

            set
            {
                this.logoPosizion = value;
            }
        }

        /// <summary>
        /// Gets or sets the output format.
        /// </summary>
        public OutputFormat OutputFormat
        {
            get
            {
                return this.outputFormat;
            }

            set
            {
                this.outputFormat = value;
            }
        }

        /// <summary>
        /// Gets or sets the output quality.
        /// </summary>
        public long Quality
        {
            get
            {
                return this.quality;
            }

            set
            {
                this.quality = value;
                Helpers.UpdateLabelPercentage(this.QualityBarLabel, (int)this.quality, this.formResources);
            }
        }

        /// <summary>
        /// Gets or sets the logo margin.
        /// </summary>
        public int LogoMargin
        {
            get
            {
                return this.logoMargin;
            }

            set
            {
                this.logoMargin = value;
                Helpers.UpdateLabelPercentage(this.MarginBarLabel, this.logoMargin, this.formResources);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the process resizes images.
        /// </summary>
        public bool ResizeImage
        {
            get
            {
                return this.ResizeCheckBox.Checked;
            }

            set
            {
                this.ResizeCheckBox.Checked = value;
            }
        }

        /// <summary>
        /// Gets or sets the resized images size.
        /// </summary>
        public int ImageSize
        {
            get
            {
                return (int)this.ResizeSize.Value;
            }

            set
            {
                this.ResizeSize.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the relative logo size.
        /// </summary>
        public int LogoSize
        {
            get
            {
                return this.logoSize;
            }

            set
            {
                this.logoSize = value;
                Helpers.UpdateLabelPercentage(this.LogoSizeBarLabel, this.logoSize, this.formResources);
            }
        }

        /// <summary>
        /// Gets or sets the logo opacity percentage.
        /// </summary>
        public int LogoOpacity
        {
            get
            {
                return this.logoOpacity;
            }

            set
            {
                this.logoOpacity = value;
                Helpers.UpdateLabelPercentage(this.OpacityBarLabel, this.logoOpacity, this.formResources);
            }
        }

        /// <summary>
        /// Gets a value indicating whether the worker is busy.
        /// </summary>
        protected bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
        }
        #endregion

        #region JizzmarkerForm Methods
        /// <summary>
        /// Gets the marker settings.
        /// </summary>
        /// <returns>Type: <see cref="Iiriya.Apps.Jizzmarker.MarkerSettings">MarkerSettings</see>. The marker settings.</returns>
        public MarkerSettings CreateMarkerSettings()
        {
            return new MarkerSettings(this);
        }

        /// <summary>
        /// Called when the output format value changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void FormatChanged(object sender, EventArgs e)
        {
            this.OutputFormat = (OutputFormat)this.FormatComboBox.SelectedItem;
        }

        /// <summary>
        /// Called when the quality bar value changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void QualityBarValueChanged(object sender, EventArgs e)
        {
            this.Quality = this.QualityBar.Value;
        }

        /// <summary>
        /// Called when the margin bar value changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void MarginBarValueChanged(object sender, EventArgs e)
        {
            this.LogoMargin = this.MarginBar.Value;
        }

        /// <summary>
        /// Called when the logo size bar value changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void LogoSizeBarValueChanged(object sender, EventArgs e)
        {
            this.LogoSize = this.LogoSizeBar.Value;
        }

        /// <summary>
        /// Called when the logo opacity bar value changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void OpacityBarValueChanged(object sender, EventArgs e)
        {
            this.LogoOpacity = this.OpacityBar.Value;
            this.CheckSubmitStatus();
        }
        
        /// <summary>
        /// Called when the worker has been stopped.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.ComponentModel.RunWorkerCompletedEventArgs">RunWorkerCompletedEventArgs</see>. Contains the event data.</param>
        protected void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.isBusy = false;
            this.filesLoaded = this.files.Length;
            this.filesCurrent = null;
            Helpers.UpdateLabelFiles(this.FilesStatusLabel, this.filesLoaded);
            this.CheckSubmitStatus();
        }

        /// <summary>
        /// Called when the progress changes.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.ComponentModel.ProgressChangedEventArgs">ProgressChangedEventArgs</see>. Contains the event data.</param>
        protected void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e != null)
            {
                Helpers.UpdateLabelFiles(this.FilesStatusLabel, this.filesLoaded, this.filesCurrent);
                this.ProgressBar.Value = e.ProgressPercentage;
            }
        }

        /// <summary>
        /// Called when the an asynchronous work starts.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.ComponentModel.CancelEventArgs">CancelEventArgs</see>. Contains the event data.</param>
        protected void DoWork(object sender, CancelEventArgs e)
        {
            if (e != null)
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                this.isBusy = true;
                string logoPath = this.LogoTextBox.Text;

                if (Helpers.CheckRenderImage(logoPath, this.LogoOpacity) || this.ResizeImage)
                {
                    MarkerSettings settings = this.CreateMarkerSettings();
                    string[] images = this.files;
                    string destination = this.DestinationTextBox.Text;
                    this.filesLoaded = images.Length;
                    using (Image logo = Helpers.CheckRenderImage(logoPath, this.LogoOpacity) ? Image.FromFile(logoPath) : null)
                    {
                        for (int i = 0; i < images.Length; i++)
                        {
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }
                            else
                            {
                                this.filesCurrent = i + 1;
                                Helpers.ProcessImage(images[i], destination, logo, settings);
                                worker.ReportProgress(Helpers.GetPercentage(images.Length, i));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Called when the submit button is clicked.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void SubmitButtonClick(object sender, EventArgs e)
        {
            if (!this.isBusy)
            {
                this.isBusy = true;
                this.CheckIsBusy();
                this.BackgroundWorker.RunWorkerAsync();
            }
            else
            {
                this.BackgroundWorker.CancelAsync();
            }
        }

        /// <summary>
        /// Called when a position button is clicked.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void PostionButtonClick(object sender, EventArgs e)
        {
            this.LogoPosizion = ((AlignmentButton)sender).Alignment;
            this.CheckAlignmentStatus();
        }

        /// <summary>
        /// Called when the resize checkbox status change.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void ResizeCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (this.ResizeCheckBox.Checked)
            {
                this.ResizeSize.Enabled = true;
                this.ResizeSize.Visible = true;
            }
            else
            {
                this.ResizeSize.Enabled = false;
                this.ResizeSize.Visible = false;
            }

            this.CheckSubmitStatus();
        }

        /// <summary>
        /// Called when the logo button is clicked.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void LogoButtonClick(object sender, EventArgs e)
        {
            if (this.LogoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.LogoTextBox.Text = this.LogoOpenFileDialog.FileName;

                using (Image logo = new Bitmap(this.LogoOpenFileDialog.FileName))
                {
                    Size size = Helpers.GetSize(logo.Size, this.LogoPictureBox.Width);
                    this.LogoPictureBox.Image = logo.GetThumbnailImage(size.Width, size.Height, null, IntPtr.Zero);
                }

                this.CheckSubmitStatus();
            }
        }

        /// <summary>
        /// Called when the source button is clicked.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void SourceButtonClick(object sender, EventArgs e)
        {
            if (this.OpenFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.SourceTextBox.Text = this.OpenFolderBrowserDialog.SelectedPath;
                this.SourceButton.ForeColor = Color.DarkGreen;

                this.files = Helpers.FindFiles(this.OpenFolderBrowserDialog.SelectedPath);
                Helpers.UpdateLabelFiles(this.FilesStatusLabel, this.files.Length);
                this.CheckSubmitStatus();
            }
        }

        /// <summary>
        /// Called when the destination button is clicked.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.EventArgs">EventArgs</see>. Contains the event data.</param>
        protected void DestinationButtonClick(object sender, EventArgs e)
        {
            if (this.SaveFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.DestinationTextBox.Text = this.SaveFolderBrowserDialog.SelectedPath;
                this.DestinationButton.ForeColor = Color.DarkGreen;

                this.CheckSubmitStatus();
            }
        }

        /// <summary>
        /// Checks the alignment status and recreates the buttons style.
        /// </summary>
        protected void CheckAlignmentStatus()
        {
            Helpers.ChangeButtonColor(this.CenterPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.LeftPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.RightPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.TopPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.TopLeftPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.TopRightPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.BottomPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.BottomLeftPostionButton, SystemColors.Control, Color.Black);
            Helpers.ChangeButtonColor(this.BottomRightPostionButton, SystemColors.Control, Color.Black);

            switch (this.LogoPosizion)
            {
                case ContentAlignment.MiddleCenter:
                    Helpers.ChangeButtonColor(this.CenterPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.MiddleLeft:
                    Helpers.ChangeButtonColor(this.LeftPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.MiddleRight:
                    Helpers.ChangeButtonColor(this.RightPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.TopCenter:
                    Helpers.ChangeButtonColor(this.TopPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.TopLeft:
                    Helpers.ChangeButtonColor(this.TopLeftPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.TopRight:
                    Helpers.ChangeButtonColor(this.TopRightPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.BottomCenter:
                    Helpers.ChangeButtonColor(this.BottomPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.BottomLeft:
                    Helpers.ChangeButtonColor(this.BottomLeftPostionButton, Color.Yellow);
                    break;
                case ContentAlignment.BottomRight:
                    Helpers.ChangeButtonColor(this.BottomRightPostionButton, Color.Yellow);
                    break;
            }
        }

        /// <summary>
        /// Checks whether the worker is busy.
        /// </summary>
        protected void CheckIsBusy()
        {
            if (this.IsBusy)
            {
                this.ProgressBar.Visible = true;
                this.SubmitButton.Text = "STOP";
            }
            else
            {
                this.ProgressBar.Visible = false;
                this.ProgressBar.Value = 0;
                this.SubmitButton.Text = this.formResources.GetString("SubmitButton.Text");
            }
        }

        /// <summary>
        /// Checks the submit button status.
        /// </summary>
        protected void CheckSubmitStatus()
        {
            this.CheckIsBusy();

            if (!string.IsNullOrWhiteSpace(this.SourceTextBox.Text) && !string.IsNullOrWhiteSpace(this.DestinationTextBox.Text) && ((!string.IsNullOrWhiteSpace(this.LogoTextBox.Text) && this.LogoOpacity > 0) || this.ResizeImage))
            {
                this.SubmitButton.ForeColor = Color.DarkGreen;
                this.SubmitButton.Enabled = true;
            }
            else
            {
                this.SubmitButton.ForeColor = Color.Red;
                this.SubmitButton.Enabled = false;
            }
        }

        /// <summary>
        /// Processes a command key.
        /// </summary>
        /// <param name="msg">Required parameter. Type: <see cref="System.Windows.Forms.Message">Message</see>. A <see cref="System.Windows.Forms.Message">Message</see>, passed by reference, that represents the Win32 message to process.</param>
        /// <param name="keyData">Required parameter. Type: <see cref="System.Windows.Forms.Keys">Keys</see>. One of the <see cref="System.Windows.Forms.Keys">Keys</see> values that represents the key to process.</param>
        /// <returns>Type: <see cref="System.Boolean">Boolean</see>. "True" if the keystroke was processed and consumed by the control; otherwise, "False" to allow further processing.</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    using (JizzmarkerHelpForm help = new JizzmarkerHelpForm())
                    {
                        help.ShowDialog(this);
                    }

                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        #endregion
    }
}
