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
                string.IsNullOrWhiteSpace(txtLitros.Text))
             
            {
                DisplayAlert("Erro", "Preencha todos os campos.", "OK");
                return;
            }
            try
            {
                double alcool = Convert.ToDouble(txtAlcool.Text);
                double gasolina = Convert.ToDouble(txtGasolina.Text);
                double kmInicial = Convert.ToDouble(txtKmInicial.Text);
                double kmFinal = Convert.ToDouble(txtKmFinal.Text);
                double litros = Convert.ToDouble(txtLitros.Text);
               

                
                double distancia = kmFinal - kmInicial;

                if (distancia <= 0)
                {
                    DisplayAlert("Erro", "A quilometragem final deve ser maior que a inicial.", "OK");
                    return;
                }

               
                double consumoMedio = distancia / litros;
                double indice = alcool / gasolina;

                if (indice <= 0.70)
                {
                    lblRegra70.Text = "Compensa abastecer com álcool.";
                }
                else
                {
                    lblRegra70.Text = " Compensa abastecer com gasolina.";
                }
                string mensagem;

                
                lblConsumo.Text = "Consumo médio: " + consumoMedio.ToString("F2") + " km/L";
                
               
            }
            catch
            {
                 DisplayAlert("Erro", "Digite apenas números válidos.", "OK");
            }
        }
    }

}
    
