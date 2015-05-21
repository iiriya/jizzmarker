//-----------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Lucio Benini">
//      Copyright (c) Lucio Benini. All rights reserved.
// </copyright>
// <author>Lucio Benini</author>
// <summary>Contains the default program class.</summary>
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
    using System.Windows.Forms;
    #endregion

    /// <summary>
    /// Contains the default program class.
    /// </summary>
    public static class Program
    {
        #region Program Constructors
        /// <summary>
        /// The default entry point for this application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JizzmarkerForm());
        }
        #endregion
    }
}