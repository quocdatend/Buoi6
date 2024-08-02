using Buoi6.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.BLL.Services
{
    public class FacultyService
    {
        private readonly QlthongTinSvContext _context = new QlthongTinSvContext();
        public List<Faculty> GetAll()
        {
            return _context.Faculties.ToList();
        }
        public Faculty GetByName(string name)
        {
            return _context.Faculties.Where(x => x.Name.Equals(name)).First();
        }
    }
}
