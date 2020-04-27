namespace NugetForUnity
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a supported Platform for NuGet packages
    /// A platform is defined by a name (which should be tightly coupled to BuildTargetGroup)
    /// and a list of supported library names defined as Regular Expressions
    /// </summary>
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