namespace PizzaOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           
            string type = "";
            string size = "";
            string toppings = "";
            type = comboPizzaType.Text;

            if(radioLarge.Checked)
            {
                size = radioLarge.Text;
            }
            if (radioSmall.Checked)
            {
                size = radioSmall.Text;
            }
            if (radioMedium.Checked)
            {
                size = radioMedium.Text;
            }
            if(cB1M.Checked)
            {
                toppings += cB1M.Text;
            }
            if (cB2Ch.Checked)
            {
                toppings += cB2Ch.Text;
            }
            if (cB3G.Checked)
            {
                toppings +=cB3G.Text;
            }
            if (cB4K.Checked)
            {
                toppings +=cB4K.Text;
            }
            if (cB5ChS.Checked)
            {
                toppings += cB5ChS.Text;
            }
            if (toppings == "")
            {
                MessageBox.Show("Не си избрал добавки");
                comboPizzaType.Focus();
                
            }
            if (type=="")
            {
                MessageBox.Show("Не си избрал вид");
                comboPizzaType.Focus();
                return;
            }
            if (size=="")
            {
                MessageBox.Show("Не си избрал размер");
                radioLarge.Focus();
                return;
            }
            
            MessageBox.Show($"Ти избра {size} {type} с {toppings}.");
            //if (lboxToppings.CheckedItems.Count != 0)
            //{
            //    // If so, loop through all checked items and print results.
            //    string s = "";
            //    for (int x = 0; x < lboxToppings.CheckedItems.Count; x++)
            //    {
            //        s = s + "Checked Item " + (x + 1).ToString() + " = " + lboxToppings.CheckedItems[x].ToString() + "\n";
            //    }
            //    MessageBox.Show(s);

            //}
        }
    }
}