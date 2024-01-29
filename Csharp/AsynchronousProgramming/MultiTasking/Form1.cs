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
            //await counter(); //await : counterý bekle ve mesajbox ile göster
            MessageBox.Show("bitti");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("týklandý");

        }

        private  Task counter()
        {
            for (int i = 0; i < 50000; i++)
            {
               labelCounter.Text = i.ToString();
                progressBar1.Value = i/5000;
            }

            return Task.CompletedTask;
            //task thread yönetim mekanizmasýdýr.
            //async await bilikte kullanýlan yapý
            //burdaki
        }
    }
}