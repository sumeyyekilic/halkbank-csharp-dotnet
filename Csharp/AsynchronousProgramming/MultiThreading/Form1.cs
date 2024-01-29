namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        //single thread : üçüncü nesail kahveci de sadece bir kiþi çalýþmakta. tufan.
        //single thread kendisi. sabah dükkaný açýcak yerlere paspas yapýcak masalarý sericek, müþterilerin sipariþini alýcak. hepsini ard arda yapar
        //içeriye sekiz müþteri geldiðinde hepsi sýra beklicek
        //iþe barista alýrsa ikinci sipariþi alabilir. kahveleri hazýrlar. ayný anda iki þ yapabilir olurlar.
        Thread thread = null;
        private void buttonMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("týklandý");
        }

        private void buttonCounter_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(count));

            thread.Start();

            //thread iþi bittikten sonra çalýþn bi fonk olmalý
            thread.Join();

            MessageBox.Show("Sayým tamamlandý");
            //üstteki thread, beklemicek


        }

        void count()
        {
            for (int i = 0; i < 100000; i++)
            {
                labelCounter.Text = i.ToString();
                progressBar1.Value = i / 1000;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}