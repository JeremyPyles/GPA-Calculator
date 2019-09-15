using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double getGPA()
        {
            double gpa = 0;
            double grade = 0;
            double totalCredits = 0;
            List<String> letterGrade = new List<String>();
            List<String> numCredits = new List<String>();

            foreach (Control c in panel1.Controls.Cast<Control>())
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    if (c.Text == "")
                    {
                        continue;
                    }
                    else
                    {
                        numCredits.Add(c.Text);

                    }
                }
                else if (c.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    if (c.Text == "")
                    {
                        continue;
                    }
                    else
                    {
                        letterGrade.Add(c.Text);
                    }
                }
            }

            if (letterGrade.Count != numCredits.Count)
            {
                return -1;
            }

            Double temp;

            for (int i = 0; i < letterGrade.Count; i++)
            {
                try
                {
                    temp = Convert.ToDouble(numCredits[i]);
                }
                catch (System.FormatException)
                {
                    return -2;
                }
                switch (letterGrade[i])
                {
                    case "A+":
                    case "A": grade += 4.0 * Convert.ToDouble(numCredits[i]); break;
                    case "A-": grade += 3.7 * Convert.ToDouble(numCredits[i]); break;
                    case "B+": grade += 3.3 * Convert.ToDouble(numCredits[i]); break;
                    case "B": grade += 3 * Convert.ToDouble(numCredits[i]); break;
                    case "B-": grade += 2.7 * Convert.ToDouble(numCredits[i]); break;
                    case "C+": grade += 2.3 * Convert.ToDouble(numCredits[i]); break;
                    case "C": grade += 2 * Convert.ToDouble(numCredits[i]); break;
                    case "C-": grade += 1.7 * Convert.ToDouble(numCredits[i]); break;
                    case "D+": grade += 1.3 * Convert.ToDouble(numCredits[i]); break;
                    case "D": grade += 1.0 * Convert.ToDouble(numCredits[i]); break;
                    case "D-": grade += 0.7 * Convert.ToDouble(numCredits[i]); break;
                    default: break;
                }
                totalCredits += Convert.ToDouble(numCredits[i]);
            }

            return grade / totalCredits;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gpa = getGPA();
            if (gpa == -1)
            {
                MessageBox.Show("Please fill in all the boxes");
            }
            else if (gpa == -2)
            {
                MessageBox.Show("Incorrect Input");
            }
            else if (gpa % 1 == 0)
            {
                MessageBox.Show(Convert.ToString(gpa) + ".0", "Your GPA");

            }
            else
            {
                MessageBox.Show(Convert.ToString(gpa), "Your GPA");
            }
        }

        private void btnAddAnother_Click(object sender, EventArgs e)
        {
            //create textbox in panel
            TextBox textbox = new TextBox();
            int count = panel1.Controls.OfType<TextBox>().ToList().Count;
            if (count == 10)
            {
                return;
            }
            textbox.Location = new System.Drawing.Point(36, 35 * count);
            textbox.Size = new System.Drawing.Size(58, 25);
            textbox.Name = "txt_" + (count + 1); 
            textbox.TextAlign = HorizontalAlignment.Center;
            panel1.Controls.Add(textbox);

            //create combobox
            ComboBox combobox = new ComboBox();
            combobox.Location = new System.Drawing.Point(122, 35 * count);
            combobox.Size = new System.Drawing.Size(58, 25);
            combobox.Name = "cmb_" + (count + 1);
            combobox.DisplayMember = "Name";
            combobox.ValueMember = "Value";
            combobox.Items.AddRange(new[]
            {
                new GradeOptions() {Name = "Select", Value = "", Selectable = false },
                new GradeOptions() {Name = "A+", Value = "A+", Selectable = true},
                new GradeOptions() {Name = "A", Value = "A", Selectable = true},
                new GradeOptions() {Name = "A-", Value = "A-", Selectable = true},
                new GradeOptions() {Name = "B+", Value = "B+", Selectable = true},
                new GradeOptions() {Name = "B", Value = "B", Selectable = true},
                new GradeOptions() {Name = "B-", Value = "B-", Selectable = true},
                new GradeOptions() {Name = "C+", Value = "C+", Selectable = true},
                new GradeOptions() {Name = "C", Value = "C", Selectable = true},
                new GradeOptions() {Name = "C-", Value = "C-", Selectable = true},
                new GradeOptions() {Name = "D+", Value = "D+", Selectable = true},
                new GradeOptions() {Name = "D", Value = "D", Selectable = true},
                new GradeOptions() {Name = "D-", Value = "D-", Selectable = true},
                new GradeOptions() {Name = "F", Value = "F", Selectable = true},
            });
            combobox.SelectedIndex = 0;
            combobox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            panel1.Controls.Add(combobox);

            //create textbox in form
            TextBox textbox2 = new TextBox();
            int count2 = panel2.Controls.OfType<TextBox>().ToList().Count;
            textbox2.Location = new System.Drawing.Point(40, 35 * count2);
            textbox2.Size = new System.Drawing.Size(125, 25);
            textbox2.Name = "txt2_" + (count + 1);
            textbox2.TextAlign = HorizontalAlignment.Left;
            panel2.Controls.Add(textbox2);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count == 0 || panel2.Controls.Count == 0)
            {
                return;
            }
            panel1.Controls.RemoveAt(panel1.Controls.Count - 1);
            panel1.Controls.RemoveAt(panel1.Controls.Count - 1);
            panel2.Controls.RemoveAt(panel2.Controls.Count - 1);
        }
    }

    public class GradeOptions
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public bool Selectable { get; set; }
    }
}
