namespace CalculadoraiMC_JAPD;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (PesoEntry.Text == "" || AlturaEntry.Text == "")
        {
            MensajeLabel.Text = "Llena todos los campos";
            return;
        }

        double peso = double.Parse(PesoEntry.Text);
        double altura = double.Parse(AlturaEntry.Text) / 100;

        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            ResultadoLabel.Text = "IMC: " + imc.ToString("0.0");
            MensajeLabel.Text = "Tienes peso bajo";
            ResultadoLabel.TextColor = Colors.Blue;
        }
        else if (imc < 25)
        {
            ResultadoLabel.Text = "IMC: " + imc.ToString("0.0");
            MensajeLabel.Text = "Tienes peso normal";
            ResultadoLabel.TextColor = Colors.Green;
        }
        else if (imc < 30)
        {
            ResultadoLabel.Text = "IMC: " + imc.ToString("0.0");
            MensajeLabel.Text = "Tienes sobre peso";
            ResultadoLabel.TextColor = Colors.Orange;
        }
        else
        {
            ResultadoLabel.Text = "IMC: " + imc.ToString("0.0");
            MensajeLabel.Text = "Tienes obesidad";
            ResultadoLabel.TextColor = Colors.Red;
        }
    }
}