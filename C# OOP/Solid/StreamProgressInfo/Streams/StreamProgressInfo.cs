using StreamProgressInfo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamProgressInfo.Streams
{
    public class StreamProgressInfo : StreamProgressor
    {
        public StreamProgressInfo(IStreamable file) : base(file)
        {
        }
    }
}
