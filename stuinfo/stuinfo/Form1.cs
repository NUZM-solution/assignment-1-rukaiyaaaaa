using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stuinfo
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

            InitializeDataTable();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //MessageBox.Show("Form Loaded!");  // Debug message to check if the event fires


        }

        // Initialize DataTable structure (headers)
        private void InitializeDataTable()
        {

            DataColumn dc1 = new DataColumn("ROLL NO", typeof(int));
            DataColumn dc2 = new DataColumn("NAME", typeof(string));
            DataColumn dc3 = new DataColumn("DEGREE", typeof(string));
            DataColumn dc4 = new DataColumn("SEMESTER", typeof(int));
            //DataColumn dc5 = new DataColumn("TYPE", typeof(string));  // Veg/Non-Veg
            DataColumn dc6 = new DataColumn("GPA", typeof(float));    // GPA (float)
            DataColumn dc7 = new DataColumn("CGPA", typeof(float));   // CGPA (float)

            // Add columns to DataTable
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            //dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
        }
        public void CreateNewRow()
        {
            //MessageBox.Show("Please fill in all fields.");
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtrollNo.Text) ||
                string.IsNullOrWhiteSpace(txtname.Text) ||
                cmbdegree.SelectedItem == null ||
                cmbsemester.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtgpa.Text) ||
                string.IsNullOrWhiteSpace(txtcgpa.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the method if validation fails
            }

            // Try to parse GPA and CGPA
            if (!float.TryParse(txtgpa.Text, out float gpa) ||
                !float.TryParse(txtcgpa.Text, out float cgpa))
            {
                MessageBox.Show("Please enter valid numeric values for GPA and CGPA.");
                return; // Exit the method if parsing fails
            }

            // Try to parse Roll No and Semester
            if (!int.TryParse(txtrollNo.Text, out int rollNo) ||
                !int.TryParse(cmbsemester.SelectedItem.ToString(), out int semester))
            {
                MessageBox.Show("Please enter valid numeric values for Roll No and Semester.");
                return; // Exit the method if parsing fails
            }

            // Add the row to the DataTable with values from input fields
            dt.Rows.Add(
                rollNo,                          // Roll No (integer)
                txtname.Text,                   // Name (string)
                cmbdegree.SelectedItem.ToString(), // Degree (string from ComboBox)
                semester,                       // Semester (integer from ComboBox)
                gpa,                            // GPA (float from TextBox)
                cgpa
            );
            // CGPA (float from TextBox)
            txtrollNo.Clear();
            txtname.Clear();
            cmbdegree.SelectedIndex = -1;
            cmbsemester.SelectedIndex = -1;
            txtgpa.Clear();
            txtcgpa.Clear();

            // Bind the updated DataTable to the DataGridView
            dataGridView2.DataSource = dt;
        }

        // Button click event handler to trigger data entry and binding
        //private void button1_Click(object sender, EventArgs e)
        //{
        //CreateNewRow();  // Call the method to add a new row
        //}
    

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewRow();  // Call the method to add a new row

        }
    }
    }



