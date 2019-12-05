using System;
using System.Windows.Forms;

namespace WindowsFormsDI
{
    public partial class Form1 : Form
    {
        private readonly IPlan _plan;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(IPlan plan)
        {
            _plan = plan;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //IPlan pl = new PlanA();
            //pl.GetPlanDetails();

            MessageBox.Show(_plan.GetPlanDetails());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_plan.GetPlanDetails());
        }
    }
}
