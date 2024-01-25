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
            //event yazmaya neden ihtiyacýmýz olsun ? formu kapaýcak, mesaj göndericek,urunun ekrandaki kaydý db ye göndericek, db den kayýt çekicek vs.  butona týklandýðýnda ne yapacaðýna karar verdiðim için event. týklanma eylemi.

            //tel çalmasý.
            ((Button)(sender)).BackColor = Color.Red;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            Product product = new Product { Name = "", Price = 2500 };
        }
        //event tetikleniyor ama karþýlýðnda yakalanmadýðý için birþey mi yapýlmýyor yoksa hiç tetiklenmiyro mu? click tretiklenmez

        private void ProductService_Created(object sender, ProductCreatedEventArgs e)
        {
            MessageBox.Show($"{e.User}kullnýcýsý {e.Product.Name} isimli urunu {e.CreatedDate} tarihinfre ekledni.");
        }
    }
}