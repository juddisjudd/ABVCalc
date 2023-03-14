namespace ABVCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtOG.Text, out double og) && double.TryParse(txtFG.Text, out double fg))
            {
                double abv = CalculateABV(og, fg);
                MessageBox.Show($"The Alcohol By Volume (ABV) is {abv:0.00}%.", "ABV Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter valid gravity values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateABV(double originalGravity, double finalGravity)
        {
            return (originalGravity - finalGravity) * 131.25;
        }
    }
}