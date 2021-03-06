﻿namespace FileTypeChecker.App.MyCustomTypes
{
    using FileTypeChecker.Abstracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MyCustomFileType : FileType
    {
        private static readonly string name = "My Super Cool Custom Type 1.0";
        private static readonly string extension = "ext";
        private static readonly byte[] magicBytes = new byte[] { 0xAF };

        public MyCustomFileType() : base(name, extension, magicBytes)
        {
        }
    }
}
