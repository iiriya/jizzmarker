//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="JizzmarkerForm.Designer.cs" company="Lucio Benini">
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
    /// <summary>
    /// Contains the designer class for <see cref="Iiriya.Apps.Jizzmarker.JizzmarkerForm">JizzmarkerForm</see>.
    /// </summary>
    partial class JizzmarkerForm
    {
        /// <summary>
        /// Designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">Required parameter. Type: <see cref="System.Boolean">Boolean</see>. "True" to release both managed and unmanaged resources; "False" to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer Code

        /// <summary>
        /// Required methods for the support of the designer window.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JizzmarkerForm));
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OpenFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourceButton = new System.Windows.Forms.Button();
            this.DestinationButton = new System.Windows.Forms.Button();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.LogoButton = new System.Windows.Forms.Button();
            this.LogoTextBox = new System.Windows.Forms.TextBox();
            this.LogoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ResizeCheckBox = new System.Windows.Forms.CheckBox();
            this.ResizeSize = new System.Windows.Forms.NumericUpDown();
            this.FilesStatusLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.QualityBar = new System.Windows.Forms.TrackBar();
            this.QualityBarLabel = new System.Windows.Forms.Label();
            this.MarginBarLabel = new System.Windows.Forms.Label();
            this.MarginBar = new System.Windows.Forms.TrackBar();
            this.LogoSizeBarLabel = new System.Windows.Forms.Label();
            this.LogoSizeBar = new System.Windows.Forms.TrackBar();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.OutputFormatLabel = new System.Windows.Forms.Label();
            this.OpacityBarLabel = new System.Windows.Forms.Label();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.BottomRightPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.BottomLeftPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.BottomPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.TopRightPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.TopLeftPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.TopPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.RightPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.LeftPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            this.CenterPostionButton = new Iiriya.Apps.Jizzmarker.AlignmentButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSizeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Control;
            this.SubmitButton.ForeColor = System.Drawing.Color.Red;
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // OpenFolderBrowserDialog
            // 
            resources.ApplyResources(this.OpenFolderBrowserDialog, "OpenFolderBrowserDialog");
            this.OpenFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // SaveFolderBrowserDialog
            // 
            resources.ApplyResources(this.SaveFolderBrowserDialog, "SaveFolderBrowserDialog");
            // 
            // SourceButton
            // 
            resources.ApplyResources(this.SourceButton, "SourceButton");
            this.SourceButton.BackColor = System.Drawing.SystemColors.Control;
            this.SourceButton.ForeColor = System.Drawing.Color.Red;
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.UseVisualStyleBackColor = false;
            // 
            // DestinationButton
            // 
            resources.ApplyResources(this.DestinationButton, "DestinationButton");
            this.DestinationButton.BackColor = System.Drawing.SystemColors.Control;
            this.DestinationButton.ForeColor = System.Drawing.Color.Red;
            this.DestinationButton.Name = "DestinationButton";
            this.DestinationButton.UseVisualStyleBackColor = false;
            // 
            // SourceTextBox
            // 
            resources.ApplyResources(this.SourceTextBox, "SourceTextBox");
            this.SourceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.ReadOnly = true;
            this.SourceTextBox.TabStop = false;
            // 
            // DestinationTextBox
            // 
            resources.ApplyResources(this.DestinationTextBox, "DestinationTextBox");
            this.DestinationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.ReadOnly = true;
            this.DestinationTextBox.TabStop = false;
            // 
            // LogoButton
            // 
            resources.ApplyResources(this.LogoButton, "LogoButton");
            this.LogoButton.BackColor = System.Drawing.SystemColors.Control;
            this.LogoButton.ForeColor = System.Drawing.Color.Black;
            this.LogoButton.Name = "LogoButton";
            this.LogoButton.UseVisualStyleBackColor = false;
            // 
            // LogoTextBox
            // 
            resources.ApplyResources(this.LogoTextBox, "LogoTextBox");
            this.LogoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoTextBox.Name = "LogoTextBox";
            this.LogoTextBox.ReadOnly = true;
            this.LogoTextBox.TabStop = false;
            // 
            // LogoOpenFileDialog
            // 
            resources.ApplyResources(this.LogoOpenFileDialog, "LogoOpenFileDialog");
            // 
            // LogoPictureBox
            // 
            resources.ApplyResources(this.LogoPictureBox, "LogoPictureBox");
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.TabStop = false;
            // 
            // ResizeCheckBox
            // 
            resources.ApplyResources(this.ResizeCheckBox, "ResizeCheckBox");
            this.ResizeCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ResizeCheckBox.Name = "ResizeCheckBox";
            this.ResizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResizeSize
            // 
            resources.ApplyResources(this.ResizeSize, "ResizeSize");
            this.ResizeSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResizeSize.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.ResizeSize.Name = "ResizeSize";
            this.ResizeSize.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            // 
            // FilesStatusLabel
            // 
            resources.ApplyResources(this.FilesStatusLabel, "FilesStatusLabel");
            this.FilesStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilesStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.FilesStatusLabel.Name = "FilesStatusLabel";
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.ForeColor = System.Drawing.Color.Red;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            // 
            // QualityBar
            // 
            resources.ApplyResources(this.QualityBar, "QualityBar");
            this.QualityBar.Maximum = 100;
            this.QualityBar.Name = "QualityBar";
            // 
            // QualityBarLabel
            // 
            resources.ApplyResources(this.QualityBarLabel, "QualityBarLabel");
            this.QualityBarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.QualityBarLabel.Name = "QualityBarLabel";
            // 
            // MarginBarLabel
            // 
            resources.ApplyResources(this.MarginBarLabel, "MarginBarLabel");
            this.MarginBarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MarginBarLabel.Name = "MarginBarLabel";
            // 
            // MarginBar
            // 
            resources.ApplyResources(this.MarginBar, "MarginBar");
            this.MarginBar.Maximum = 5;
            this.MarginBar.Name = "MarginBar";
            // 
            // LogoSizeBarLabel
            // 
            resources.ApplyResources(this.LogoSizeBarLabel, "LogoSizeBarLabel");
            this.LogoSizeBarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LogoSizeBarLabel.Name = "LogoSizeBarLabel";
            // 
            // LogoSizeBar
            // 
            resources.ApplyResources(this.LogoSizeBar, "LogoSizeBar");
            this.LogoSizeBar.Maximum = 100;
            this.LogoSizeBar.Minimum = 50;
            this.LogoSizeBar.Name = "LogoSizeBar";
            this.LogoSizeBar.Value = 100;
            // 
            // FormatComboBox
            // 
            resources.ApplyResources(this.FormatComboBox, "FormatComboBox");
            this.FormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Name = "FormatComboBox";
            // 
            // OutputFormatLabel
            // 
            resources.ApplyResources(this.OutputFormatLabel, "OutputFormatLabel");
            this.OutputFormatLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OutputFormatLabel.Name = "OutputFormatLabel";
            // 
            // OpacityBarLabel
            // 
            resources.ApplyResources(this.OpacityBarLabel, "OpacityBarLabel");
            this.OpacityBarLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.OpacityBarLabel.Name = "OpacityBarLabel";
            // 
            // OpacityBar
            // 
            resources.ApplyResources(this.OpacityBar, "OpacityBar");
            this.OpacityBar.Maximum = 100;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Value = 100;
            // 
            // BottomRightPostionButton
            // 
            resources.ApplyResources(this.BottomRightPostionButton, "BottomRightPostionButton");
            this.BottomRightPostionButton.Alignment = System.Drawing.ContentAlignment.BottomRight;
            this.BottomRightPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.BottomRightPostionButton.Name = "BottomRightPostionButton";
            this.BottomRightPostionButton.UseVisualStyleBackColor = false;
            // 
            // BottomLeftPostionButton
            // 
            resources.ApplyResources(this.BottomLeftPostionButton, "BottomLeftPostionButton");
            this.BottomLeftPostionButton.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.BottomLeftPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.BottomLeftPostionButton.Name = "BottomLeftPostionButton";
            this.BottomLeftPostionButton.UseVisualStyleBackColor = false;
            // 
            // BottomPostionButton
            // 
            resources.ApplyResources(this.BottomPostionButton, "BottomPostionButton");
            this.BottomPostionButton.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            this.BottomPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.BottomPostionButton.Name = "BottomPostionButton";
            this.BottomPostionButton.UseVisualStyleBackColor = false;
            // 
            // TopRightPostionButton
            // 
            resources.ApplyResources(this.TopRightPostionButton, "TopRightPostionButton");
            this.TopRightPostionButton.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.TopRightPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.TopRightPostionButton.Name = "TopRightPostionButton";
            this.TopRightPostionButton.UseVisualStyleBackColor = false;
            // 
            // TopLeftPostionButton
            // 
            resources.ApplyResources(this.TopLeftPostionButton, "TopLeftPostionButton");
            this.TopLeftPostionButton.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.TopLeftPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.TopLeftPostionButton.Name = "TopLeftPostionButton";
            this.TopLeftPostionButton.UseVisualStyleBackColor = false;
            // 
            // TopPostionButton
            // 
            resources.ApplyResources(this.TopPostionButton, "TopPostionButton");
            this.TopPostionButton.Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.TopPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.TopPostionButton.Name = "TopPostionButton";
            this.TopPostionButton.UseVisualStyleBackColor = false;
            // 
            // RightPostionButton
            // 
            resources.ApplyResources(this.RightPostionButton, "RightPostionButton");
            this.RightPostionButton.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.RightPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.RightPostionButton.Name = "RightPostionButton";
            this.RightPostionButton.UseVisualStyleBackColor = false;
            // 
            // LeftPostionButton
            // 
            resources.ApplyResources(this.LeftPostionButton, "LeftPostionButton");
            this.LeftPostionButton.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeftPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.LeftPostionButton.Name = "LeftPostionButton";
            this.LeftPostionButton.UseVisualStyleBackColor = false;
            // 
            // CenterPostionButton
            // 
            resources.ApplyResources(this.CenterPostionButton, "CenterPostionButton");
            this.CenterPostionButton.BackColor = System.Drawing.SystemColors.Control;
            this.CenterPostionButton.Name = "CenterPostionButton";
            this.CenterPostionButton.UseVisualStyleBackColor = false;
            // 
            // JizzmarkerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.OpacityBarLabel);
            this.Controls.Add(this.OpacityBar);
            this.Controls.Add(this.FilesStatusLabel);
            this.Controls.Add(this.OutputFormatLabel);
            this.Controls.Add(this.FormatComboBox);
            this.Controls.Add(this.LogoSizeBarLabel);
            this.Controls.Add(this.LogoSizeBar);
            this.Controls.Add(this.MarginBarLabel);
            this.Controls.Add(this.MarginBar);
            this.Controls.Add(this.QualityBarLabel);
            this.Controls.Add(this.QualityBar);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.BottomRightPostionButton);
            this.Controls.Add(this.BottomLeftPostionButton);
            this.Controls.Add(this.BottomPostionButton);
            this.Controls.Add(this.TopRightPostionButton);
            this.Controls.Add(this.TopLeftPostionButton);
            this.Controls.Add(this.TopPostionButton);
            this.Controls.Add(this.RightPostionButton);
            this.Controls.Add(this.LeftPostionButton);
            this.Controls.Add(this.CenterPostionButton);
            this.Controls.Add(this.ResizeSize);
            this.Controls.Add(this.ResizeCheckBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.LogoTextBox);
            this.Controls.Add(this.LogoButton);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.SourceTextBox);
            this.Controls.Add(this.DestinationButton);
            this.Controls.Add(this.SourceButton);
            this.Controls.Add(this.SubmitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "JizzmarkerForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarginBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSizeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.FolderBrowserDialog OpenFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog SaveFolderBrowserDialog;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.Button DestinationButton;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Button LogoButton;
        private System.Windows.Forms.TextBox LogoTextBox;
        private System.Windows.Forms.OpenFileDialog LogoOpenFileDialog;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.CheckBox ResizeCheckBox;
        private System.Windows.Forms.NumericUpDown ResizeSize;
        private System.Windows.Forms.Label FilesStatusLabel;
        private AlignmentButton LeftPostionButton;
        private AlignmentButton RightPostionButton;
        private AlignmentButton TopRightPostionButton;
        private AlignmentButton TopLeftPostionButton;
        private AlignmentButton TopPostionButton;
        private AlignmentButton BottomRightPostionButton;
        private AlignmentButton BottomLeftPostionButton;
        private AlignmentButton BottomPostionButton;
        private AlignmentButton CenterPostionButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.TrackBar QualityBar;
        private System.Windows.Forms.Label QualityBarLabel;
        private System.Windows.Forms.Label MarginBarLabel;
        private System.Windows.Forms.TrackBar MarginBar;
        private System.Windows.Forms.Label LogoSizeBarLabel;
        private System.Windows.Forms.TrackBar LogoSizeBar;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Label OutputFormatLabel;
        private System.Windows.Forms.Label OpacityBarLabel;
        private System.Windows.Forms.TrackBar OpacityBar;
    }
}