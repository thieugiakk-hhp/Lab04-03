using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab04_03.Models;

namespace Lab04_03
{
    public partial class frmSearch : Form
    {
        #region Properties
        StudentContext context;

        List<Student> students;
        List<Faculty> faculties;

        List<Student> findStudents;
        #endregion

        public frmSearch()
        {
            InitializeComponent();

            context = new StudentContext();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            faculties = context.Faculties.ToList();
            students = context.Students.ToList();

            GetFacultyToCombobox(faculties);
            GetStudentToDataGridView(students);

            txtKetQua.Text = dgvTimKiem.Rows.Count.ToString();
        }

        #region Lấy dữ liệu từ Database đổ lên Form
        private void GetFacultyToCombobox(List<Faculty> list)
        {
            cbbKhoaVien.DataSource = list;
            cbbKhoaVien.DisplayMember = "FacultyName";
            cbbKhoaVien.ValueMember = "FacultyID";
        }

        private void GetStudentToDataGridView(List<Student> list)
        {
            dgvTimKiem.Rows.Clear();

            foreach (var item in list)
            {
                int indexRow = dgvTimKiem.Rows.Add();
                dgvTimKiem.Rows[indexRow].Cells[0].Value = item.StudentID;
                dgvTimKiem.Rows[indexRow].Cells[1].Value = item.FullName;
                dgvTimKiem.Rows[indexRow].Cells[2].Value = item.Faculty.FacultyName;
                dgvTimKiem.Rows[indexRow].Cells[3].Value = item.AverageScore;
            }
        }
        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            findStudents = new List<Student>();

            string id = txtMSSV.Text.ToLower();
            string name = txtHoTen.Text.ToLower();

            foreach (var item in students)
            {
                if (txtMSSV.Text == "" && txtHoTen.Text == "")
                {
                    if (item.Faculty.FacultyName == cbbKhoaVien.Text)
                    {
                        findStudents.Add(item);
                    }
                }
                else
                {
                    if (txtMSSV.Text != "" && txtHoTen.Text != "")
                    {
                        if (item.StudentID.ToString().ToLower().IndexOf(id) != -1 && item.FullName.ToString().ToLower().IndexOf(name) != -1 && item.Faculty.FacultyName == cbbKhoaVien.Text)
                        {
                            findStudents.Add(item);
                        }
                    }
                    else if (txtHoTen.Text != "" && txtMSSV.Text == "")
                    {
                        if (item.FullName.ToString().ToLower().IndexOf(name) != -1 && item.Faculty.FacultyName == cbbKhoaVien.Text)
                        {
                            findStudents.Add(item);
                        }
                    }
                    else if (txtHoTen.Text == "" && txtMSSV.Text != "")
                    {
                        if (item.StudentID.ToString().ToLower().IndexOf(id) != -1 && item.Faculty.FacultyName == cbbKhoaVien.Text)
                        {
                            findStudents.Add(item);
                        }
                    }
                }
            }

            txtKetQua.Text = findStudents.Count.ToString();

            GetStudentToDataGridView(findStudents);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmSearch_Load(null, null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng trang?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
