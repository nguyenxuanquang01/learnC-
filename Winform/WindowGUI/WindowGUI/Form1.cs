namespace WindowGUI
{
    public partial class Form1 : Form
    {
        WebBrowser wb;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wb = new WebBrowser();
            wb.Width = 900;
            wb.Height = 400;
            wb.DocumentCompleted += Wb_DocumentCompleted;
            panel1.Controls.Add(wb);
        }

        private void Wb_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = textBox1.Text;
            wb.Navigate(link);
        }
    }
}
