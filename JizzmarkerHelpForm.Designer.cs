//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="JizzmarkerHelpForm.Designer.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the help form.</summary>
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
    /// Contains the designer class for <see cref="Iiriya.Apps.Jizzmarker.JizzmarkerHelpForm">JizzmarkerHelpForm</see>.
    /// </summary>
    partial class JizzmarkerHelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JizzmarkerHelpForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.LicenseLabel = new System.Windows.Forms.Label();
            this.SiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Name = "TitleLabel";
            // 
            // SubtitleLabel
            // 
            resources.ApplyResources(this.SubtitleLabel, "SubtitleLabel");
            this.SubtitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.SubtitleLabel.Name = "SubtitleLabel";
            // 
            // CopyrightLabel
            // 
            resources.ApplyResources(this.CopyrightLabel, "CopyrightLabel");
            this.CopyrightLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyrightLabel.Name = "CopyrightLabel";
            // 
            // LicenseLabel
            // 
            resources.ApplyResources(this.LicenseLabel, "LicenseLabel");
            this.LicenseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.LicenseLabel.Name = "LicenseLabel";
            // 
            // SiteLinkLabel
            // 
            resources.ApplyResources(this.SiteLinkLabel, "SiteLinkLabel");
            this.SiteLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SiteLinkLabel.LinkColor = System.Drawing.Color.White;
            this.SiteLinkLabel.Name = "SiteLinkLabel";
            this.SiteLinkLabel.TabStop = true;
            // 
            // JizzmarkerHelpForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.SiteLinkLabel);
            this.Controls.Add(this.LicenseLabel);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JizzmarkerHelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.Label LicenseLabel;
        private System.Windows.Forms.LinkLabel SiteLinkLabel;
    }
}