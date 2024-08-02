using System;
using System.Collections.Generic;

namespace Buoi6.DAL.Models;

public partial class Major
{
    public int Id { get; set; }

    public int Facultyid { get; set; }

    public string Name { get; set; } = null!;

    public virtual Faculty Faculty { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
