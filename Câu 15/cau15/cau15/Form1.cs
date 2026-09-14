namespace cau15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbColor_Click(object sender, EventArgs e)
        {

        }

        private void dudColor_SelectedItemChanged(object sender, EventArgs e)
        {
            //Typecast the object to DomainUpDown
            DomainUpDown dudColor = (DomainUpDown)sender;
            //Change color of lblsampleText to selected color
            lblSampleText.ForeColor = Color.FromName(dudColor.Text);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            //Typecast the object to NumericUpDown
            NumericUpDown nudSize = (NumericUpDown)sender;
            //Change the font of lblSampleText to selected font
            lblSampleText.Font = new
           Font(lblSampleText.Font.FontFamily, (float)nudSize.Value);
        }
    }
}
