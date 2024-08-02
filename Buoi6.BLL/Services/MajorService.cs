using Buoi6.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.BLL.Services
{
    public class MajorService
    {
        private readonly QlthongTinSvContext _context = new QlthongTinSvContext();
        public List<Major> GetAllByFaculty(int facultyId)
        {
            List<Major> result = _context.Majors.Where(x => x.Equals(facultyId)).ToList();
            return result;
        }
    }
}
