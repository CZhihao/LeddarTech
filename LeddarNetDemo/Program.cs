// *****************************************************************************
// Module..: SDK -- Software development kit for Leddar products.
//
/// \file    Program.cs
///
/// \brief   Entry point of LeddarNET example program.
///
// Platform: .NET
//
// Copyright (c) 2013 LeddarTech Inc. All rights reserved.
// Information contained herein is or may be confidential and proprietary to
// LeddarTech inc. Prior to using any part of the software development kit
// accompanying this notice, you must accept and agree to be bound to the
// terms of the LeddarTech Inc. license agreement accompanying this file.
// *****************************************************************************

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeddarNetDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm() );
        }
    }
}

// End of file Program.cs
