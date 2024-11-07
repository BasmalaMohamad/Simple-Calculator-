namespace Calculator
{
    public partial class Form1 : Form
    {
        float[] nums;
        int j = 1;
        float num1;
        char op = ' ';
        float num2;
        int i = 0;
        float mem = 0;

        public Form1()
        {
            InitializeComponent();
            //Text = "Calculator";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnminus_Click(object sender, EventArgs e)
        {
            i = 0;
            Button Op = sender as Button;
            op = char.Parse((Op.Text));
            // txtScreen.Text += op;
            txtScreen.Text = " ";


        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float res;
            float num2 = float.Parse(txtScreen.Text);
            Button b = sender as Button;
            switch (op)
            {
                case ('+'):
                    txtScreen.Text = $" {num1 + num2}";
                    break;
                case ('/'):
                    txtScreen.Text = $"{num1 / num2}";
                    break;
                case ('-'):
                    txtScreen.Text = $"{num1 - num2}";
                    break;
                case ('*'):
                    txtScreen.Text = $"{num1 * num2}";
                    break;
            }
            //for (int k = 0; k < nums.Length; k++)
            //{


            //    switch (op)
            //    {
            //        case ('+'):
            //            txtScreen.Text = $" {nums[k] + nums[k+1]}";
            //            break;
            //        case ('/'):
            //            txtScreen.Text = $"{nums[k] / nums[k+1]}";
            //            break;
            //        case ('-'):
            //            txtScreen.Text = $"{nums[k] - nums[k+1]}";
            //            break;
            //        case ('*'):
            //            txtScreen.Text = $"{nums[k] * nums[k+1]}";
            //            break;
            //    }
            //}
            op = ' ';


        }

        private void btnerase_Click(object sender, EventArgs e)
        {
            txtScreen.Text = " ";
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == ".")
            {
                i++;
            }
            if (i <= 1)
            {

                txtScreen.Text += btn.Text;

                if (op != ' ')
                {
                    num2 = float.Parse((txtScreen.Text));
                    j++;
                    //switch (op)
                    //{
                    //    case ('+'):
                    //        txtScreen.Text = $" {num1 + num2}";
                    //        break;
                    //    case ('/'):
                    //        txtScreen.Text = $"{num1 / num2}";
                    //        break;
                    //    case ('-'):
                    //        txtScreen.Text = $"{num1 - num2}";
                    //        break;
                    //    case ('*'):
                    //        txtScreen.Text = $"{num1 * num2}";
                    //        break;
                    //}
                }
                else
                {
                    //nums[0] = float.Parse((txtScreen.Text));
                    num1 = float.Parse((txtScreen.Text));

                }
            }

        }

        private void btnm_Click(object sender, EventArgs e)
        {
            mem = float.Parse(txtScreen.Text);
        }

        private void btnmre_Click(object sender, EventArgs e)
        {
            txtScreen.Text = mem.ToString();
            if (op != ' ')
                num2 = float.Parse((txtScreen.Text));
            else
            {

                num1 = float.Parse((txtScreen.Text));
            }



        }

        //private void btn6_Click(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
            
        //    if (i <= 1)
        //    {

        //        txtScreen.Text += btn.Text;

        //        if (op != ' ')
        //            num2 = float.Parse((txtScreen.Text));
        //        else
        //        {

        //            num1 = float.Parse((txtScreen.Text));
        //        }
        //    }

        //}
    }
}
