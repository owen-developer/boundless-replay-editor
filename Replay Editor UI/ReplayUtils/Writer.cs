using System;
using System.IO;
using System.Text;

namespace Replay_Editor_UI.ReplayUtils
{
    class Writer
    {
        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
        static public void ReplaceBytes(string path, byte[] search, byte[] replace, int startoffset, string log)
        {
            Stream stream09 = (Stream)File.OpenRead(path);
            foreach (long offset in Researcher.FindPosition(stream09, 0, startoffset, search))
            {
                stream09.Close();
                BinaryWriter binaryWriter = new BinaryWriter(File.Open(path, FileMode.Open, FileAccess.ReadWrite));
                binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
                binaryWriter.Write(replace);
                binaryWriter.Close();
                Console.WriteLine(log);
            }
        }

        public static bool decompressed;

        static public void Write(string[] args, byte[] search, byte[] replace)
        {
            int ZeroBytes = search.Length - replace.Length;
            while (ZeroBytes > 0)
            {
                byte[] fill = { 0 };
                replace = Combine(replace, fill);
                ZeroBytes--;
            }

            StringBuilder builder = new StringBuilder();
            foreach (string value in args)
            {
                builder.Append(value);
                builder.Append(' ');
            }
            string result = builder.ToString().Replace("\"", "");

            if (decompressed)
            {
                Console.WriteLine("\nStarting at " + Path.GetDirectoryName(result) + "\\Dumped\\" + Path.GetFileName(result) + "...");
                ReplaceBytes(Path.GetDirectoryName(result) + "\\Dumped\\" + Path.GetFileName(result), search, replace, 0, "Swapped...");
            }
            else
            {
                Console.WriteLine("Starting already decompressed at " + Path.GetDirectoryName(result) + "\\" + Path.GetFileName(result) + "...");
                ReplaceBytes(result, search, replace, 0, "Swapped...");
            }
        }
    }
}
