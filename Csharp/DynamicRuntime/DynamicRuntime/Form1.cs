namespace DynamicRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load_1(object sender, EventArgs e)
        {
            dynamic name = "halkbank";
            MessageBox.Show(name.ToUpper());

            name = 8;
            dynamic dynoItem = getJson(name);
            MessageBox.Show(dynoItem.Info);
            MessageBox.Show(dynoItem.Value.ToString());
        }
        dynamic getJson(dynamic parametre)
        {
            return new
            {
                Info = "Bu tip anonimdir",
                Value = parametre
            };
        }

        private void InitializeComponent()
        {

        }
    }
}