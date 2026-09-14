namespace BTCh3_Bai17
{
    public partial class macdinh : Form
    {
        public macdinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (lstLopA.Items.Count > 0)
            {
                lstLopB.Items.Add(lstLopA.Items[0]);
                lstLopA.Items.RemoveAt(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
        }

        private void lstLopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            lstLopA.Items.Remove(lstLopA.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text))
            {
                lstLopA.Items.Add(txtTen.Text);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void btnChuyenA_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItem != null)
            {
                lstLopB.Items.Add(lstLopA.SelectedItem);
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
        }

        private void btnChuyenHetB_Click(object sender, EventArgs e)
        {
            while (lstLopB.Items.Count > 0)
            {
                lstLopA.Items.Add(lstLopB.Items[0]);
                lstLopB.Items.RemoveAt(0);
            }
        }

        private void btnXoaB_Click(object sender, EventArgs e)
        {
            lstLopB.Items.Remove(lstLopB.SelectedItem);
        }

        private void macdinh_Load(object sender, EventArgs e)
        {

        }

        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text))
            {
                lstLopB.Items.Add(txtTen.Text);
                txtTen.Clear();
                txtTen.Focus();
            }
        }

        private void chuyểnPhầnTửChọnSangLơpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
        }
    }
}
