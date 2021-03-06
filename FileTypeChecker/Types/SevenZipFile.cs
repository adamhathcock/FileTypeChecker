﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    public class SevenZipFile : FileType, IFileType
    {
        private static readonly string name = "7-Zip File Format";
        private static readonly string extension = "7z";
        private static readonly byte[] magicBytes = new byte[] { 0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C };

        public SevenZipFile() : base(name, extension, magicBytes)
        {
        }
    }
}
