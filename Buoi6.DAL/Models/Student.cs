using System;
using System.Collections.Generic;

namespace Buoi6.DAL.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Mssv { get; set; } = null!;

    public string Name { get; set; } = null!;

    public double Averagescore { get; set; }

    public int Facultyid { get; set; }

    public int? Majorid { get; set; }

    public string? Avatar { get; set; }

    public virtual Faculty Faculty { get; set; } = null!;

    public virtual Major? Major { get; set; }
}
