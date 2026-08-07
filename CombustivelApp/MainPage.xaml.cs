namespace CombustivelApp
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {

            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtAlcool.Text) ||
                string.IsNullOrWhiteSpace(txtGasolina.Text) ||
                string.IsNullOrWhiteSpace(txtKmInicial.Text) ||
                string.IsNullOrWhiteSpace(txtKmFinal.Text) ||
                string.IsNullOrWhiteSpace(txtLitros.Text) ||
                string.IsNullOrWhiteSpace(txtConsumoAlcool.Text) ||
                string.IsNullOrWhiteSpace(txtConsumoGasolina.Text))
            {
                DisplayAlert("Erro", "Preencha todos os campos.", "OK");
                return;
            }

            }
    }

}
