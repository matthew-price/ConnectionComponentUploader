using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionComponentUploader
{
    class ConnectionComponent
    {
        private byte[] importFile;

        public byte[] ImportFile { get => importFile; set => importFile = value; }
    }
}
