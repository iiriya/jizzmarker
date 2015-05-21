//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="MarkerSettings.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Provides the settings used by the marker workers.</summary>
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
    using System.Drawing;
    #endregion

    /// <summary>
    /// Provides the settings used by the marker workers.
    /// </summary>
    public class MarkerSettings
    {
        #region MarkerSettings Fields
        /// <summary>
        /// The logo position.
        /// </summary>
        private ContentAlignment logoPosizion;

        /// <summary>
        /// The output format.
        /// </summary>
        private OutputFormat outputFormat;

        /// <summary>
        /// The output quality.
        /// </summary>
        private long quality;

        /// <summary>
        /// The logo margin.
        /// </summary>
        private int logoMargin;

        /// <summary>
        /// A value indicating whether the process resizes images.
        /// </summary>
        private bool resizeImage;

        /// <summary>
        /// The resized images size.
        /// </summary>
        private int imageSize;

        /// <summary>
        /// The relative logo size.
        /// </summary>
        private int logoSize;

        /// <summary>
        /// The logo opacity percentage.
        /// </summary>
        private int logoOpacity;
        #endregion

        #region MarkerSettings Contructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Jizzmarker.MarkerSettings">MarkerSettings</see> class.
        /// </summary>
        public MarkerSettings() : this(ContentAlignment.MiddleCenter, OutputFormat.Jpeg, 100L, 3, false, 1600, 100, 100)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Jizzmarker.MarkerSettings">MarkerSettings</see> class.
        /// </summary>
        /// <param name="data">Required parameter. Type: <see cref="Iiriya.Apps.Jizzmarker.IJizzmarkerForm">IJizzmarkerForm</see>. The object that contains the settings data.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="data"/> is null.</exception>
        public MarkerSettings(IJizzmarkerForm data)
        {
            if (data != null)
            {
                this.logoPosizion = data.LogoPosizion;
                this.outputFormat = data.OutputFormat;
                this.quality = data.Quality;
                this.logoMargin = data.LogoMargin;
                this.resizeImage = data.ResizeImage;
                this.imageSize = data.ImageSize;
                this.logoSize = data.LogoSize;
                this.logoOpacity = data.LogoOpacity;
            }
            else
            {
                throw new ArgumentNullException("data");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Iiriya.Apps.Jizzmarker.MarkerSettings">MarkerSettings</see> class.
        /// </summary>
        /// <param name="logoPosizion">Required parameter. Type: <see cref="System.Drawing.ContentAlignment">ContentAlignment</see>. The logo position.</param>
        /// <param name="outputFormat">Required parameter. Type: <see cref="Iiriya.Apps.Jizzmarker.OutputFormat">OutputFormat</see>. The output format.</param>
        /// <param name="quality">Required parameter. Type: <see cref="System.Int64">Long Integer</see>. The output quality.</param>
        /// <param name="logoMargin">Required parameter. Type: <see cref="System.Int32">Integer</see>. The logo margin.</param>
        /// <param name="resizeImage">Required parameter. Type: <see cref="System.Boolean">Boolean</see>. A value indicating whether the process resizes images.</param>
        /// <param name="imageSize">Required parameter. Type: <see cref="System.Int32">Integer</see>. The resized images size.</param>
        /// <param name="logoSize">Required parameter. Type: <see cref="System.Int32">Integer</see>. The relative logo size.</param>
        /// <param name="logoOpacity">Required parameter. Type: <see cref="System.Int32">Integer</see>. The logo opacity percentage.</param>
        public MarkerSettings(ContentAlignment logoPosizion, OutputFormat outputFormat, long quality, int logoMargin, bool resizeImage, int imageSize, int logoSize, int logoOpacity)
        {
            this.logoPosizion = logoPosizion;
            this.outputFormat = outputFormat;
            this.quality = quality;
            this.logoMargin = logoMargin;
            this.resizeImage = resizeImage;
            this.imageSize = imageSize < 0 ? 0 : imageSize;
            this.logoSize = logoSize;
            this.logoOpacity = logoOpacity;
        }
        #endregion

        #region MarkerSettings Properties
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
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the process resizes images.
        /// </summary>
        public bool ResizeImage
        {
            get
            {
                return this.resizeImage;
            }

            set
            {
                this.resizeImage = value;
            }
        }

        /// <summary>
        /// Gets or sets the resized images size.
        /// </summary>
        public int ImageSize
        {
            get
            {
                return this.imageSize;
            }

            set
            {
                this.imageSize = value;
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
            }
        }
        #endregion
    }
}