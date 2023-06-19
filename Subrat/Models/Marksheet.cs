using System;
using System.Collections.Generic;

namespace Subrat.Models;

public partial class Marksheet
{
    public int Id { get; set; }

    public int? Sid { get; set; }

    public int Subject1 { get; set; }

    public int Subject2 { get; set; }

    public int Subject3 { get; set; }

    public int Subject4 { get; set; }

    public int Subject5 { get; set; }

    public virtual StudentDetail? SidNavigation { get; set; }
}
