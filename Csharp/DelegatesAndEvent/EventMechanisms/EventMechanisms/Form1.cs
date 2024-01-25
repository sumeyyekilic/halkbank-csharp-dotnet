namespace EventMechanisms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //event yazmaya neden ihtiyac�m�z olsun ? formu kapa�cak, mesaj g�ndericek,urunun ekrandaki kayd� db ye g�ndericek, db den kay�t �ekicek vs.  butona t�kland���nda ne yapaca��na karar verdi�im i�in event. t�klanma eylemi.

            //tel �almas�.
            ((Button)(sender)).BackColor = Color.Red;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            Product product = new Product { Name = "", Price = 2500 };
        }
        //event tetikleniyor ama kar��l��nda yakalanmad��� i�in bir�ey mi yap�lm�yor yoksa hi� tetiklenmiyro mu? click tretiklenmez

        private void ProductService_Created(object sender, ProductCreatedEventArgs e)
        {
            MessageBox.Show($"{e.User}kulln�c�s� {e.Product.Name} isimli urunu {e.CreatedDate} tarihinfre ekledni.");
        }
    }
}