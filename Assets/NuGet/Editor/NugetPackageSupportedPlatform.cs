namespace NugetForUnity
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Xml;
    using System.Xml.Linq;
    using Debug = UnityEngine.Debug;

    public class NugetPackageSupportedPlatform
    {
        public string Name { get; set; }

        public List<string> LibraryNames { get; set; }

        public NugetPackageSupportedPlatform(string name)
        {
            Name = name;
            LibraryNames = new List<string>();
        }

        public NugetPackageSupportedPlatform(string name, List<string> libraryNames)
        {
            Name = name;
            LibraryNames = libraryNames;
        }
    }
}