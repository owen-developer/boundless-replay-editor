using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replay_Editor
{
    class Researcher
    {
        public static List<long> FindPosition(Stream stream, int searchPosition, long startIndex, byte[] searchPattern)
        {
            List<long> searchResults = new List<long>();
            stream.Position = startIndex;

            while (true)
            {
                if (stream.Position == 5000000000)
                {
                    return searchResults;
                }

                var latestbyte = stream.ReadByte();
                if (latestbyte == -1)
                {
                    break;
                }

                if (latestbyte == searchPattern[searchPosition])
                {
                    searchPosition++;
                    if (searchPosition == searchPattern.Length)
                    {
                        searchResults.Add(stream.Position - searchPattern.Length);
                        return searchResults;
                    }
                }
                else
                {
                    searchPosition = 0;
                }
            }

            return searchResults;
        }
    }
}
