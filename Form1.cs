namespace GyumolcsArazo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btLista = flowLayoutPanel1.Controls.OfType<Button>().ToList();
            foreach (var bt in btLista)
                KepetIgazit(bt);
        }

        private void KepetIgazit(Button bt)
        {
            Image AtmeretezettKep = new Bitmap(bt.Image, new Size(bt.Width - 5, bt.Height - 5));
            bt.Image = AtmeretezettKep;
        }

        private void BtKorte_Click(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            //Alternative solution: Button bt= sender as  Button
            if (double.TryParse(tbTomeg.Text, out double tomeg))
            {


                double ar = tomeg * double.Parse(bt.Text);
                llAr.Text = ar.ToString();


            };
        }
    }
}