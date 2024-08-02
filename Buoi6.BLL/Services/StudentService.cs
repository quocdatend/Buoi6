using Buoi6.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6.BLL.Services
{
    public class StudentService
    {
        private readonly QlthongTinSvContext _context = new QlthongTinSvContext();
        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        public List<Student> GetAllHasNoMajor()
        {
            return _context.Students.Where(x => x.Majorid == 0).ToList();
        }
        public List<Student> GetAllHasNoMajor(int FacultyId)
        {
            return _context.Students.Where(x => x.Majorid == 0 && x.Facultyid.Equals(FacultyId)).ToList();
        }
        public Student FindById(string Id)
        {
            return _context.Students.Where(x => x.Id.Equals(Id)).FirstOrDefault();
        }
        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public Student FindByMSSVAndName(string name, string mssv)
        {
            return _context.Students.Where(x => x.Name.Equals(name) && x.Mssv.Equals(mssv)).FirstOrDefault();
        }
        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
        }
    }
}
