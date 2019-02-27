// Guids.cs
// MUST match guids.h
using System;

namespace EBLM.CreateMyFolders
{
    static class GuidList
    {
        public const string guidCreateMyFoldersPkgString = "cf11f412-8844-4b35-96c2-0d0141ac63e9";
        public const string guidCreateMyFoldersCmdSetString = "91085cbb-1b53-4fd4-b25f-8afcd05fef01";
        public const string guidCreateMyFoldersEditorFactoryString = "cfe34965-9aa3-409c-8fb1-9fc57e8135b7";

        public static readonly Guid guidCreateMyFoldersCmdSet = new Guid(guidCreateMyFoldersCmdSetString);
        public static readonly Guid guidCreateMyFoldersEditorFactory = new Guid(guidCreateMyFoldersEditorFactoryString);
    };
}