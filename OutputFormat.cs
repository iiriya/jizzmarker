//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputFormat.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the OutputFormat enumeration.</summary>
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
    /// Determines the Output Format.
    /// </summary>
    public enum OutputFormat
    {
        /// <summary>
        /// Indicates a JPEG image.
        /// </summary>
        Jpeg,

        /// <summary>
        /// Indicates a PNG image.
        /// </summary>
        Png,

        /// <summary>
        /// Indicates a Bitmap image.
        /// </summary>
        Bitmap,

        /// <summary>
        /// Indicates a TIFF image.
        /// </summary>
        Tiff,

        /// <summary>
        /// Indicates a GIF image.
        /// </summary>
        Gif
    }
}