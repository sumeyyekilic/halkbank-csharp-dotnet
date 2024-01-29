namespace MultiTasking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonCounter_Click(object sender, EventArgs e)
        {
            await Task.Run(counter);
            //await counter(); //await : counter� bekle ve mesajbox ile g�ster
            MessageBox.Show("bitti");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("t�kland�");

        }

        private  Task counter()
        {
            for (int i = 0; i < 50000; i++)
            {
               labelCounter.Text = i.ToString();
                progressBar1.Value = i/5000;
            }

            return Task.CompletedTask;
            //task thread y�netim mekanizmas�d�r.
            //async await bilikte kullan�lan yap�
            //burdaki
        }
    }
}