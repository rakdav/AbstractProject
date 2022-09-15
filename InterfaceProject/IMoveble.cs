using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal interface IMoveble
    {
        void Move();
        string Name { get; set; }
    }
}
