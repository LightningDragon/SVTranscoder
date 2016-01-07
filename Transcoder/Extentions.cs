using System;

namespace SVTranscoder
{
    public static class Extentions
    {
        public static bool IsWinVistaOrHigher(this OperatingSystem os)
        {
            return (os.Platform == PlatformID.Win32NT) && (os.Version.Major >= 6);
        }
    }
}
