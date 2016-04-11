﻿using System;
using System.Collections.Generic;
using Telerik.JustDecompiler.Languages.CSharp;
using Telerik.JustDecompiler.Languages.VisualBasic;

namespace Telerik.JustDecompiler.Languages
{
    public static partial class LanguageFactory
    {
        public static ILanguage GetLanguage(CSharpVersion version)
        {
            switch (version)
            {
                case CSharpVersion.None:
                    return new CSharp();
                case CSharpVersion.V5:
                    return new CSharpV5();
                case CSharpVersion.V6:
                    return new CSharpV6();
                default:
                    throw new ArgumentException();
            }
        }
    }
}
