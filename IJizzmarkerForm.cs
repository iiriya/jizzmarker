//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="IJizzmarkerForm.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the IJizzmarkerForm interface.</summary>
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
    using System.Drawing;
    #endregion

    /// <summary>
    /// The IJizzmarkerForm interface.
    /// </summary>
    public interface IJizzmarkerForm
    {
        #region IJizzmarkerForm Properties
        /// <summary>
        /// Gets or sets the logo position.
        /// </summary>
        ContentAlignment LogoPosizion
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the output format.
        /// </summary>
        OutputFormat OutputFormat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the output quality.
        /// </summary>
        long Quality
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the logo margin.
        /// </summary>
        int LogoMargin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the process resizes images.
        /// </summary>
        bool ResizeImage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the resized images size.
        /// </summary>
        int ImageSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the relative logo size.
        /// </summary>
        int LogoSize
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the logo opacity percentage.
        /// </summary>
        int LogoOpacity
        {
            get;
            set;
        }
        #endregion

        #region IJizzmarkerForm Methods
        /// <summary>
        /// Gets the marker settings.
        /// </summary>
        /// <returns>Type: <see cref="Iiriya.Apps.Jizzmarker.MarkerSettings">MarkerSettings</see>. The marker settings.</returns>
        MarkerSettings CreateMarkerSettings();
        #endregion
    }
}