using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tuples
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_CreateTuple()
        {
            (string DirectoryName, string FileName, string Extension) pathData =
                (DirectoryName: @"\\test\unc\path\to",
                    FileName: "something",
                    Extension: ".ext");
            Assert.AreEqual<string>(
                @"\\test\unc\path\to", pathData.DirectoryName);
            Assert.AreEqual<string>(
                "something", pathData.FileName);
            Assert.AreEqual<string>(
                ".ext", pathData.Extension);
            Assert.AreEqual<(string DirectoryName, string FileName, string Extension)>(
                (DirectoryName: @"\\test\unc\path\to",
                    FileName: "something", Extension: ".ext"),
                (pathData));
            Assert.AreEqual<(string DirectoryName, string FileName, string Extension)>(
                (@"\\test\unc\path\to", "something", ".ext"),
                (pathData));
            Assert.AreEqual<(string, string, string)>(
                (@"\\test\unc\path\to", "something", ".ext"), (pathData));
            Assert.AreEqual<Type>(
                typeof(ValueTuple<string, string, string>), pathData.GetType());
        }
        [TestMethod]
        public void ValueTuple_GivenNamedTuple_ItemXHasSameValuesAsNames()
        {
            var normalizedPath =
                (DirectoryName: @"\\test\unc\path\to", FileName: "something",
                    Extension: ".ext");
            Assert.AreEqual<string>(normalizedPath.Item1, normalizedPath.DirectoryName);
            Assert.AreEqual<string>(normalizedPath.Item2, normalizedPath.FileName);
            Assert.AreEqual<string>(normalizedPath.Item3, normalizedPath.Extension);
        }
        static public (string DirectoryName, string FileName, string Extension)
            SplitPath(string path)
        {
            // See http://bit.ly/2dmJIMm Normalize method for full implementation.
            return (          
                System.IO.Path.GetDirectoryName(path),
                System.IO.Path.GetFileNameWithoutExtension(path),
                System.IO.Path.GetExtension(path)
            );
        }
    }
}
