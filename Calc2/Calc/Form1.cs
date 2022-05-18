using System;
using System.Windows.Forms;

  //10**2-5

//Another solution is to use stacks with the importance of order of operations

namespace Calc2
{
    public partial class Form1 : Form
    {
        private bool isOpClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        //click button c- clear  (all be cleared)
        private void btnC_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            lbl1.Text= "";
        }

        //click button ce- clear entry 
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";

        }
        //click on cancel remove the last value
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 0)
            {
                txtScreen.Text = txtScreen.Text.Remove(txtScreen.Text.Length - 1, 1);
            }
            if (txtScreen.Text == "")
            {
                txtScreen.Text = "0";
            }
        }

        //number clicked
        private void btnClick(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
              txtScreen.Clear();
            isOpClicked = false;
            Button button = (Button)sender;
                txtScreen.Text += button.Text;
        }

        //operator button clicked   or ()
        private void btnOperClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!isOpClicked)               //  if clicked on one of the operator buttons again, op only show 1 time in screen  
            {
                txtScreen.Text += button.Text;
                isOpClicked = true;
            }
        }

        // equal button clicked
        private void btnEqu_Click(object sender, EventArgs e)
        {
            int res = 0;
            lbl1.Text = txtScreen.Text;
            res =calculator.Calculation(txtScreen.Text);
            txtScreen.Text = Convert.ToString(res);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

       
     }
    
}





//I have another soluion  if code libraries are allowed to be used
/*
 * using System;
using System.Data;
public class Calc
{
    public static void Main(string[] args)
    {
        var res = new DataTable().Compute("10*2+5", null);
        Console.WriteLine(res);
    }
}


//DataTable represents a single table in memory. Used for data storage
//The DataTable.Compute method is used to perform operations on DataTable data. It can be used to perform cumulative operations on line data. For example calculation
//syntax public Object Compute (String expression,String filter)
   */