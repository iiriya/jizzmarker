//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="JizzmarkerHelpForm.cs" company="Lucio Benini">
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
    #region Using Directives
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// Contains the help form.
    /// </summary>
    public partial class JizzmarkerHelpForm : Form
    {
        #region JizzmarkerHelpForm Contructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Jizzmarker.JizzmarkerHelpForm">JizzmarkerHelpForm</see> class.
        /// </summary>
        public JizzmarkerHelpForm()
        {
            this.InitializeComponent();

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.iiriya.com/";
            this.SiteLinkLabel.Links.Add(link);
            this.SiteLinkLabel.LinkClicked += this.SiteLinkLabelClicked;
        }
        #endregion

        #region JizzmarkerHelpForm Methods
        /// <summary>
        /// Called when the link label is clicked.
        /// </summary>
        /// <param name="sender">Required parameter. Type: <see cref="System.Object">Object</see>. The source of the event.</param>
        /// <param name="e">Required parameter. Type: <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs">LinkLabelLinkClickedEventArgs</see>. Contains the event data.</param>
        protected void SiteLinkLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
        #endregion
    }
}
