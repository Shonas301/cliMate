using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliMate
{
    class ImageFileNode : Node
    {
        String FileName;

        public ImageFileNode(NodeMap map, String fileName) : base(map)
        {

        }

        public override void doOperation()
        {
            //TODO Slap the file import logic here and put it into the output grid
            throw new NotImplementedException();
        }
    }
}
