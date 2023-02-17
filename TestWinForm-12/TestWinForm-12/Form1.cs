using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;

namespace TestWinForm_12
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }
        List<Person> persons = new List<Person>();
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            string gander = "";
            string name = "";
            string middleName = "";
            string lastName = "";
            string fieldОfШork = "";
            //public int Digits_While(int n)
            //{
            //    int eGN = n < 0 ? 2 : 1;
            //    while ((n /= 10) != 0) ++eGN;
            //    return eGN;
            //}
            //public static int Digits_String(this int n) =>
            //  n.ToString().Length;

            //    // STRING CONVERSION:
            //    public static int Digits_String(this int n) =>
            //        n.ToString().Length;
            //}
            //    //fieldWork = cmbFieldОfШork.Text;

            if (rbMan.Checked)
            {
                gander= rbMan.Text;
            }
            if (rbWomann.Checked)
            {
            }
            if (gander == "")
            {
                MessageBox.Show("Не си избрал пол");
                cmbFieldОfШork.Focus();
                return;
            }
            DialogResult r = MessageBox.Show($"Вие въведохте {name} {middleName} {lastName} с , {gander},{fieldОfШork}. Потвърждавате ли ","",MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Person p = new Person(name,middleName,lastName,gander, fieldОfШork);
                persons.Add(p);


            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("", persons));
        }
    }
}