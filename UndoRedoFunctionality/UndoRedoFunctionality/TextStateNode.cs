using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoFunctionality
{
    public class TextStateNode
    {
        public string Content;
        public TextStateNode Next;
        public TextStateNode Prev;

        public TextStateNode(string content)
        {
            Content = content;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return Content;
        }
    }

}
