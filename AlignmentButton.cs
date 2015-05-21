//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="AlignmentButton.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains application helpers.</summary>
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
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// Provides a <see cref="System.Windows.Forms.Button">Button</see> control what contains alignment data.
    /// </summary>
    [ToolboxItem(true)]
    public class AlignmentButton : Button
    {
        #region AlignmentButton Fields
        /// <summary>
        /// The alignment.
        /// </summary>
        private ContentAlignment alignment = ContentAlignment.MiddleCenter;
        #endregion

        #region AlignmentButton Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Jizzmarker.AlignmentButton">AlignmentButton</see> class.
        /// </summary>
        public AlignmentButton() : base()
        {
        }
        #endregion

        #region AlignmentButton Properties
        /// <summary>
        /// Gets or sets the alignment.
        /// </summary>
        [Bindable(false), DefaultValue(ContentAlignment.MiddleCenter), Browsable(true)]
        public ContentAlignment Alignment
        {
            get
            {
                return this.alignment;
            }

            set
            {
                this.alignment = value;
            }
        }
        #endregion
    }
}