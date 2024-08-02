using System;
using System.Collections.Generic;

namespace Buoi6.DAL.Models;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Major> Majors { get; set; } = new List<Major>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
