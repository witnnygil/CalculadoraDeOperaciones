namespace CalculadoraDeOperaciones
{
    public partial class FrmCalculatorOperations : Form
    {
        public FrmCalculatorOperations()
        {
            InitializeComponent();
            ApplyAppearance();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtFirstNumber.Text != string.Empty && TxtSecondNumber.Text != string.Empty)
            {
                var result = Calculator.Add(double.Parse(TxtFirstNumber.Text), double.Parse(TxtSecondNumber.Text));
                TxtResult.Text = result.ToString();
            }
            
        }

        private void BtnSubstract_Click(object sender, EventArgs e)
        {
            if (TxtFirstNumber.Text != string.Empty && TxtSecondNumber.Text != string.Empty)
            {
                var result = Calculator.Subtract(double.Parse(TxtFirstNumber.Text), double.Parse(TxtSecondNumber.Text));
                TxtResult.Text = result.ToString();
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (TxtFirstNumber.Text != string.Empty && TxtSecondNumber.Text != string.Empty)
            {
                var result = Calculator.Multiply(double.Parse(TxtFirstNumber.Text), double.Parse(TxtSecondNumber.Text));
                TxtResult.Text = result.ToString();
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (TxtFirstNumber.Text != string.Empty && TxtSecondNumber.Text != string.Empty)
            {
                var result = Calculator.Divide(double.Parse(TxtFirstNumber.Text), double.Parse(TxtSecondNumber.Text));
                TxtResult.Text = result.ToString();
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtFirstNumber.Clear();
            TxtSecondNumber.Clear();
            TxtResult.Clear();
        }
    }
}