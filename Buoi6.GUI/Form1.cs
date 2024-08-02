using Buoi6.BLL.Services;
using Buoi6.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Buoi6.GUI
{
    public partial class frm_Student : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private bool isClick = false;
        private bool isChecked = false;
        private int rowIndex = -1;
        private void reloadDGV()
        {
            List<Faculty> faculties = facultyService.GetAll();
            List<Student> students = studentService.GetAll();
            foreach (var item in students)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.Mssv;
                dgvStudent.Rows[index].Cells[1].Value = item.Name;
                foreach (var itemf in faculties)
                {
                    if (itemf.Id == item.Facultyid)
                    {
                        dgvStudent.Rows[index].Cells[2].Value = itemf.Name;
                    }
                }
                dgvStudent.Rows[index].Cells[3].Value = item.Averagescore;
            }
        }
        public frm_Student()
        {
            InitializeComponent();
            List<Faculty> faculties = facultyService.GetAll();
            foreach (var item in faculties)
            {
                cb_khoa.Items.Add(item.Name);
            }
            reloadDGV();
        }

        private void btn_Add_Update_Click(object sender, EventArgs e)
        {
            Faculty f = facultyService.GetByName(cb_khoa.Text);

            Student student = new Student()
            {
                Mssv = txt_mssv.Text,
                Name = txt_name.Text,
                Facultyid = f.Id,
                Averagescore = float.Parse(txt_dtb.Text)
            };
            if (isClick is true)
            {
                studentService.UpdateStudent(student);
                dgvStudent.Rows.Clear();
            }
            else
            {
                studentService.AddStudent(student);
                dgvStudent.Rows.Clear();
            }
            reloadDGV();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            isClick = true;
            rowIndex = e.RowIndex;
        }

        private void btb_Delete_Click(object sender, EventArgs e)
        {
            if (isClick)
            {
                DataGridViewRow row = dgvStudent.Rows[rowIndex];
                Student student =  studentService.FindByMSSVAndName(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                studentService.DeleteStudent(student);
                reloadDGV();
            }
        }
    }
}
