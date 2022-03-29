using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerifConfig
{
    internal class Verif
    {
        public string Chemain { get; set; }
        public string Contenue { get; set; }

        public Verif ()
        {
            Chemain = "";
            Contenue = "";
        }

        public Verif (string direct, string content)
        {
            Chemain = direct;
            Contenue = content;
        }
        
    }
}
