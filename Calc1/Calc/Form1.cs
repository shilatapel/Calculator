using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1    //my first solution without order of operations
{
    public partial class Form1 : Form
    {
        //Creating variables
        private double resNum=0;
        private string Op="";
        private bool isOpClicked = false;


        public Form1()
        {
            InitializeComponent();
        }


        //click button c- clear  (all be cleared)
        private void btnC_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            resNum = 0;
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

        //number or .(btnfloat) clicked
        private void btnClick(object sender, EventArgs e)
        {
            if ((txtScreen.Text == "0") || (isOpClicked))
                txtScreen.Clear();
            isOpClicked = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtScreen.Text.Contains("."))
                    txtScreen.Text += button.Text;
            }
            else
                txtScreen.Text += button.Text;
        }

        //operator button clicked
        private void btnOperClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //if not number is 0. Which means that you have clicked on one of the operator buttons again
            if (resNum != 0)
            {
                btnEqu.PerformClick();//turn on equal button
                Op = button.Text;    //saves which operation is clicked
                lbl1.Text = $"{resNum} {Op}";
                isOpClicked = true;
            }
            else 
            {
                Op = button.Text;  //saves which operation is clicked
                resNum = Convert.ToDouble(txtScreen.Text);  // saves the number that is in the screen
                lbl1.Text = $"{resNum} {Op}";
                isOpClicked = true;
            }
        }

        // equal button clicked
        private void btnEqu_Click(object sender, EventArgs e)
        {
            switch (Op)
            {

                case "+":
                    txtScreen.Text = (resNum + Convert.ToDouble(txtScreen.Text)).ToString();
                    break;
                case "-":
                    txtScreen.Text = (resNum - Convert.ToDouble(txtScreen.Text)).ToString();
                    break;
                case "X":
                    txtScreen.Text = (resNum * Convert.ToDouble(txtScreen.Text)).ToString();
                    break;
                case "/":
                    if (Convert.ToDouble(txtScreen.Text) != 0)
                    {
                        txtScreen.Text = (resNum / Convert.ToDouble(txtScreen.Text)).ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Can not be divided by zero!!!");
                        break;
                    }
                default:
                    break;


            }
            resNum = Convert.ToDouble(txtScreen.Text);
            lbl1.Text = "";
            Op = "";
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