using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainterEngineSharp.Types;

public struct TimeStamp
{
    public short Year { get; set; }
    public short Month { get; set; }
    public short Day { get; set; }
    public short Hour {  get; set; }
    public short Minute { get; set; }
    public short Second { get; set; }
}
