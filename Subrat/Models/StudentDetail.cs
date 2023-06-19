using System;
using System.Collections.Generic;

namespace Subrat.Models;

public partial class StudentDetail
{
    public int Sid { get; set; }

    public string Fname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Parentsname { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public DateTime Dob { get; set; }

    public int PhoneNo { get; set; }

    public int Class { get; set; }

    public virtual ICollection<Marksheet> Marksheets { get; set; } = new List<Marksheet>();
}
