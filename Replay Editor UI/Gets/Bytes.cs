using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replay_Editor_UI.Gets
{
    class Bytes
    {
        public static byte[] Get(string v)
        {
            return Encoding.ASCII.GetBytes(v);
        }
    }
}
