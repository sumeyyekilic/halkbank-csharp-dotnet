namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        //single thread : ���nc� nesail kahveci de sadece bir ki�i �al��makta. tufan.
        //single thread kendisi. sabah d�kkan� a��cak yerlere paspas yap�cak masalar� sericek, m��terilerin sipari�ini al�cak. hepsini ard arda yapar
        //i�eriye sekiz m��teri geldi�inde hepsi s�ra beklicek
        //i�e barista al�rsa ikinci sipari�i alabilir. kahveleri haz�rlar. ayn� anda iki � yapabilir olurlar.
        Thread thread = null;
        private void buttonMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("t�kland�");
        }

        private void buttonCounter_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(count));

            thread.Start();

            //thread i�i bittikten sonra �al��n bi fonk olmal�
            thread.Join();

            MessageBox.Show("Say�m tamamland�");
            //�stteki thread, beklemicek


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