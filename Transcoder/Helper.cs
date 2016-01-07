using System.IO;

namespace SVTranscoder
{
    public static class Helper
    {
        public static readonly byte[] SvCipher = { 0x2A, 0x44, 0x4C, 0x65 };

        public static void CipherFile(string path)
        {
            using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[0x1000];
                int bytesRead;

                while ((bytesRead = stream.Read(buffer, 0, 0x1000)) > 0)
                {
                    for (int index = 0; index < bytesRead; index++)
                    {
                        buffer[index] ^= SvCipher[index % 4];
                    }

                    stream.Position -= bytesRead;
                    stream.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
