//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="Helpers.cs" company="Lucio Benini">
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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// Contains application helpers.
    /// </summary>
    internal static class Helpers
    {
        #region Helpers Fields
        /// <summary>
        /// The default file Extensions.
        /// </summary>
        private static readonly string[] Extensions = new string[] { "JPE", "JPG", "JPEG", "TIF", "TIFF", "BMP", "PNG", "GIF" };
        #endregion

        #region Helpers Methods
        /// <summary>
        /// Changes the color of the given <paramref name="button"/>.
        /// </summary>
        /// <param name="button">Required parameter. Type: <see cref="System.Windows.Forms.ButtonBase">ButtonBase</see>. The button.</param>
        /// <param name="back">Required parameter. Type: <see cref="System.Drawing.Color">Color</see>. The back color.</param>
        /// <param name="fore">Required parameter. Type: <see cref="System.Drawing.Color">Color</see>. The fore color.</param>
        internal static void ChangeButtonColor(ButtonBase button, Color back, Color fore)
        {
            if (button != null)
            {
                button.ForeColor = fore;
                button.BackColor = back;
            }
        }

        /// <summary>
        /// Changes the color of the given <paramref name="button"/>.
        /// </summary>
        /// <param name="button">Required parameter. Type: <see cref="System.Windows.Forms.ButtonBase">ButtonBase</see>. The button.</param>
        /// <param name="color">Required parameter. Type: <see cref="System.Drawing.Color">Color</see>. The destination color.</param>
        internal static void ChangeButtonColor(Button button, Color color)
        {
            ChangeButtonColor(button, color, color);
        }

        /// <summary>
        /// Retrieves the resized <paramref name="size"/> using the given <paramref name="square"/>.
        /// </summary>
        /// <param name="size">Required parameter. Type: <see cref="System.Drawing.Size">Size</see>. The size.</param>
        /// <param name="square">Required parameter. Type: <see cref="System.Int32">Integer</see>. A square side used to limit the resize.</param>
        /// <returns>Type: <see cref="System.Drawing.Size">Size</see>. The resized <paramref name="size"/>.</returns>
        internal static Size GetSize(Size size, int square)
        {
            square = Math.Abs(square);
            int width;
            int height;

            if (size.Width > size.Height)
            {
                width = square;
                height = (size.Height * square) / size.Width;
            }
            else if (size.Width < size.Height)
            {
                width = (size.Width * square) / size.Height;
                height = square;
            }
            else
            {
                width = square;
                height = square;
            }

            return new Size(width, height);
        }

        /// <summary>
        /// Gets an uppercase file extension form the given <paramref name="path"/>.
        /// </summary>
        /// <param name="path">Required parameter. Type: <see cref="System.String">String</see>. The path.</param>
        /// <returns>Type: <see cref="System.String">String</see>. An uppercase file extension form the given <paramref name="path"/>.</returns>
        internal static string GetExtension(string path)
        {
            return Path.GetExtension(path).ToUpperInvariant().TrimStart('.');
        }

        /// <summary>
        /// Generates an array of files from the given <paramref name="path"/> using the default <see cref="Iiriya.Apps.Jizzmarker.Helpers.Extensions">Extensions</see>.
        /// </summary>
        /// <param name="path">Required parameter. Type: <see cref="System.String">String</see>. The path of the directory.</param>
        /// <param name="options">Optional parameter. Type: <see cref="System.IO.SearchOption">SearchOption</see>. The search options.</param>
        /// <returns>Type: <see cref="System.String">String</see>[]. An array of files from the given <paramref name="path"/>.</returns>
        /// <seealso cref="Iiriya.Apps.Jizzmarker.Helpers.Extensions"/>
        internal static string[] FindFiles(string path, SearchOption options = SearchOption.TopDirectoryOnly)
        {
            string[] files = Directory.GetFiles(path, "*.*", options);
            List<string> list = new List<string>();

            foreach (string file in files)
            {
                if (Extensions.Contains(GetExtension(file), StringComparer.OrdinalIgnoreCase))
                {
                    list.Add(file);
                }
            }

            return list.ToArray();
        }

        /// <summary>
        /// Converts the given <paramref name="format"/> to its relative <see cref="System.Drawing.Imaging.ImageFormat">ImageFormat</see>.
        /// </summary>
        /// <param name="format">Required parameter. Type: <see cref="Iiriya.Apps.Jizzmarker.OutputFormat">OutputFormat</see>. The format.</param>
        /// <returns>Type: <see cref="System.Drawing.Imaging.ImageFormat">ImageFormat</see>. The <see cref="System.Drawing.Imaging.ImageFormat">ImageFormat</see> relative to the given <paramref name="format"/>.</returns>
        internal static ImageFormat GetImageFormat(OutputFormat format)
        {
            switch (format)
            {
                case OutputFormat.Png:
                    return ImageFormat.Png;
                case OutputFormat.Bitmap:
                    return ImageFormat.Bmp;
                case OutputFormat.Tiff:
                    return ImageFormat.Tiff;
                case OutputFormat.Gif:
                    return ImageFormat.Gif;
                default:
                    return ImageFormat.Jpeg;
            }
        }

        /// <summary>
        /// Returns the given <paramref name="format"/> to its relative file extension.
        /// </summary>
        /// <param name="format">Required parameter. Type: <see cref="Iiriya.Apps.Jizzmarker.OutputFormat">OutputFormat</see>. The format.</param>
        /// <returns>Type: <see cref="System.String">String</see>. The file extension relative to the given <paramref name="format"/>.</returns>
        /// <exception cref="System.NotSupportedException">The <paramref name="format"/> provides a not supported value.</exception>
        internal static string GetImageExtension(OutputFormat format)
        {
            switch (format)
            {
                case OutputFormat.Png:
                    return "png";
                case OutputFormat.Bitmap:
                    return "bmp";
                case OutputFormat.Tiff:
                    return "tif";
                case OutputFormat.Gif:
                    return "gif";
                case OutputFormat.Jpeg:
                    return "jpg";
                default:
                    throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Processes and saves an image from the given <paramref name="path"/>.
        /// </summary>
        /// <param name="path">Required parameter. Type: <see cref="System.String">String</see>. The path of the image to load.</param>
        /// <param name="outputFolder">Required parameter. Type: <see cref="System.String">String</see>. The output folder.</param>
        /// <param name="logo">Required parameter. Type: <see cref="System.Drawing.Image">Image</see>. The logo.</param>
        /// <param name="settings">Required parameter. Type: <see cref="Iiriya.Apps.Jizzmarker.MarkerSettings">MarkerSettings</see>. The settings.</param>
        internal static void ProcessImage(string path, string outputFolder, Image logo, MarkerSettings settings)
        {
            if (settings != null)
            {
                using (Image img = new Bitmap(path))
                {
                    Size newSize = settings.ResizeImage ? img.Size : GetSize(img.Size, settings.ImageSize);
                    using (Image background = new Bitmap(img, newSize))
                    {
                        if (logo != null && settings.LogoOpacity > 0)
                        {
                            Size logoSize = GetLogoSize(settings.LogoPosizion, newSize, logo, settings.LogoMargin, settings.LogoSize);
                            using (Graphics graphics = Graphics.FromImage(background))
                            {
                                graphics.DrawImage(background, new Point(0, 0));

                                Point pos = GetLogoPosition(settings.LogoPosizion, logoSize, newSize, settings.LogoMargin);

                                if (settings.LogoOpacity < 100)
                                {
                                    using (ImageAttributes attributes = new ImageAttributes())
                                    {
                                        ColorMatrix matrix = new ColorMatrix();
                                        matrix.Matrix33 = settings.LogoOpacity * 0.01f;
                                        attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                                        graphics.DrawImage(logo, new Rectangle(pos, logoSize), 0, 0, logo.Width, logo.Height, GraphicsUnit.Pixel, attributes);
                                    }
                                }
                                else
                                {
                                    graphics.DrawImage(logo, new Rectangle(pos, logoSize), 0, 0, logo.Width, logo.Height, GraphicsUnit.Pixel);
                                }

                                graphics.Save();
                            }
                        }

                        using (EncoderParameters parameters = new EncoderParameters(1))
                        {
                            parameters.Param[0] = new EncoderParameter(Encoder.Quality, settings.Quality);
                            background.Save(Path.Combine(outputFolder, Path.GetFileNameWithoutExtension(path) + "." + GetImageExtension(settings.OutputFormat)), GetEncoderInfo(GetImageFormat(settings.OutputFormat)), parameters);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Provides the <see cref="System.Drawing.Imaging.ImageCodecInfo">ImageCodecInfo</see> related to the given <paramref name="format"/>.
        /// </summary>
        /// <param name="format">Required parameter. Type: <see cref="System.Drawing.Imaging.ImageFormat">ImageFormat</see>. The image format.</param>
        /// <returns>Type: <see cref="System.Drawing.Imaging.ImageCodecInfo">ImageCodecInfo</see>. The <see cref="System.Drawing.Imaging.ImageCodecInfo">ImageCodecInfo</see> related to the given <paramref name="format"/>.</returns>
        /// <seealso cref="System.Drawing.Imaging.ImageCodecInfo"/>
        internal static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
            {
                if (encoder.FormatID == format.Guid)
                {
                    return encoder;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the resized <paramref name="logo"/> size.
        /// </summary>
        /// <param name="alignment">Required parameter. Type: <see cref="System.Drawing.ContentAlignment">ContentAlignment</see>. The logo alignment.</param>
        /// <param name="imageSize">Required parameter. Type: <see cref="System.Drawing.Size">Size</see>. The image size.</param>
        /// <param name="logo">Required parameter. Type: <see cref="System.Drawing.Image">Image</see>. The logo.</param>
        /// <param name="margins">Required parameter. Type: <see cref="System.Int32">Integer</see>. The logo margins.</param>
        /// <param name="size">Optional parameter. Type: <see cref="System.Int32">Integer</see>. The logo relative size in percentage.</param>
        /// <returns>Type: <see cref="System.Drawing.Size">Size</see>. The logo size.</returns>
        internal static Size GetLogoSize(ContentAlignment alignment, Size imageSize, Image logo, int margins, int size = 100)
        {
            if (logo != null)
            {
                decimal width = imageSize.Width;
                decimal height = imageSize.Height;

                if (alignment == ContentAlignment.MiddleCenter)
                {
                    width /= 3;
                    height /= 3;

                    if (logo.Size.Width > logo.Size.Height)
                    {
                        return GetSize(logo.Size, decimal.ToInt32((width / 100) * size));
                    }
                    else
                    {
                        return GetSize(logo.Size, decimal.ToInt32((height / 100) * size));
                    }
                }
                else
                {
                    decimal mw = (width / 100) * margins;
                    decimal mh = (height / 100) * margins;
                    width /= 5;
                    height /= 5;

                    if (logo.Size.Width > logo.Size.Height)
                    {
                        return GetSize(logo.Size, decimal.ToInt32(((width / 100) * size) - mw));
                    }
                    else
                    {
                        return GetSize(logo.Size, decimal.ToInt32(((height / 100) * size) - mh));
                    }
                }
            }
            else
            {
                return Size.Empty;
            }
        }

        /// <summary>
        /// Gets the logo position.
        /// </summary>
        /// <param name="alignment">Required parameter. Type: <see cref="System.Drawing.ContentAlignment">ContentAlignment</see>. The logo alignment.</param>
        /// <param name="logoSize">Required parameter. Type: <see cref="System.Drawing.Size">Size</see>. The logo size.</param>
        /// <param name="imageSize">Required parameter. Type: <see cref="System.Drawing.Size">Size</see>. The image size.</param>
        /// <param name="margins">Required parameter. Type: <see cref="System.Int32">Integer</see>. The logo margins.</param>
        /// <returns>Type: <see cref="System.Drawing.Point">Point</see>. The logo position.</returns>
        internal static Point GetLogoPosition(ContentAlignment alignment, Size logoSize, Size imageSize, int margins)
        {
            int mw = (imageSize.Width / 100) * margins;
            int mh = (imageSize.Height / 100) * margins;

            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                    return new Point(mw, mh);
                case ContentAlignment.TopCenter:
                    return new Point((imageSize.Width / 2) - (logoSize.Width / 2), mh);
                case ContentAlignment.TopRight:
                    return new Point(imageSize.Width - logoSize.Width - mw, mh);
                case ContentAlignment.MiddleLeft:
                    return new Point(mw, (imageSize.Height / 2) - (logoSize.Height / 2));
                case ContentAlignment.MiddleRight:
                    return new Point(imageSize.Width - logoSize.Width - mw, (imageSize.Height / 2) - (logoSize.Height / 2));
                case ContentAlignment.BottomLeft:
                    return new Point(mw, imageSize.Height - (logoSize.Height + mh));
                case ContentAlignment.BottomCenter:
                    return new Point((imageSize.Width / 2) - (logoSize.Width / 2), imageSize.Height - (logoSize.Height + mh));
                case ContentAlignment.BottomRight:
                    return new Point(imageSize.Width - logoSize.Width - mw, imageSize.Height - (logoSize.Height + mh));
                default:
                    return new Point((imageSize.Width / 2) - (logoSize.Width / 2), (imageSize.Height / 2) - (logoSize.Height / 2));
            }
        }

        /// <summary>
        /// Gets the percentage between <paramref name="current"/> and <paramref name="total"/>.
        /// </summary>
        /// <param name="total">Required parameter. Type: <see cref="System.Decimal">Decimal</see>. The total (100%) size.</param>
        /// <param name="current">Required parameter. Type: <see cref="System.Decimal">Decimal</see>. The current size.</param>
        /// <returns>Type: <see cref="System.Int32">Integer</see>. The percentage between <paramref name="current"/> and <paramref name="total"/>.</returns>
        internal static int GetPercentage(decimal total, decimal current)
        {
            return 100 - decimal.ToInt32(100 * (total - current) / total);
        }

        /// <summary>
        /// Updates the <paramref name="label"/> <see cref="System.Windows.Forms.Label.Text">Text</see> using a percentage format with the given <paramref name="percentage"/>.
        /// </summary>
        /// <param name="label">Required parameter. Type: <see cref="System.Windows.Forms.Label">Label</see>. The <see cref="System.Windows.Forms.Label">Label</see> to update.</param>
        /// <param name="percentage">Required parameter. Type: <see cref="System.Int32">Integer</see>. The percentage.</param>
        /// <param name="resources">Optional parameter. Type: <see cref="System.ComponentModel.ComponentResourceManager">ComponentResourceManager</see>. The resource manager.</param>
        internal static void UpdateLabelPercentage(Label label, int percentage, ComponentResourceManager resources = null)
        {
            if (label != null)
            {
                if (resources != null)
                {
                    label.Text = string.Format((IFormatProvider)null, "{0} {1}{2}", resources.GetString(label.Name + ".Text"), percentage, '%');
                }
                else
                {
                    label.Text = string.Format((IFormatProvider)null, "{0}{1}", percentage, '%');
                }
            }
        }

        /// <summary>
        /// Updates the <paramref name="label"/> <see cref="System.Windows.Forms.Label.Text">Text</see> using the files format.
        /// </summary>
        /// <param name="label">Required parameter. Type: <see cref="System.Windows.Forms.Label">Label</see>. The <see cref="System.Windows.Forms.Label">Label</see> to update.</param>
        /// <param name="total">Optional parameter. Type: <see cref="System.Nullable&lt;T&gt;">Nullable</see>&lt;<see cref="System.Int32">Integer</see>&gt;. The total count of files.</param>
        /// <param name="current">Optional parameter. Type: <see cref="System.Nullable&lt;T&gt;">Nullable</see>&lt;<see cref="System.Int32">Integer</see>&gt;. The current count of files.</param>
        internal static void UpdateLabelFiles(Label label, int? total = null, int? current = null)
        {
            if (label != null)
            {
                string t = total == null ? string.Empty : string.Concat(total, " files");
                string c = current == null ? string.Empty : string.Concat(current, '/');
                label.Text = c + t;
            }
        }
        #endregion
    }
}