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
            try
            {
                double alcool = Convert.ToDouble(txtAlcool.Text);
                double gasolina = Convert.ToDouble(txtGasolina.Text);
                double kmInicial = Convert.ToDouble(txtKmInicial.Text);
                double kmFinal = Convert.ToDouble(txtKmFinal.Text);
                double litros = Convert.ToDouble(txtLitros.Text);
                double consumoAlcool = Convert.ToDouble(txtConsumoAlcool.Text);
                double consumoGasolina = Convert.ToDouble(txtConsumoGasolina.Text);

                if (litros == 0 || consumoAlcool == 0 || consumoGasolina == 0)
                {
                     DisplayAlert("Erro", "Os valores não podem ser zero.", "OK");
                    return;
                }
                double distancia = kmFinal - kmInicial;

                if (distancia <= 0)
                {
                    DisplayAlert("Erro", "A quilometragem final deve ser maior que a inicial.", "OK");
                    return;
                }

               
                double consumoMedio = distancia / litros;
                double custoAlcool = alcool / consumoAlcool;
                double custoGasolina = gasolina / consumoGasolina;
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
                lblCustoAlcool.Text = "Custo por km Álcool: R$ " + custoAlcool.ToString("F2");
                lblCustoGasolina.Text = "Custo por km Gasolina: R$ " + custoGasolina.ToString("F2");
               
            }
            catch
            {
                 DisplayAlert("Erro", "Digite apenas números válidos.", "OK");
            }
        }
    }

}
    
