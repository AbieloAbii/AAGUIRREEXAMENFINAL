namespace aaguirreexamen.Vistas;

public partial class resumen : ContentPage
{
	public resumen(string usuario)
	{
		InitializeComponent();
        lblUsuario.Text = usuario;
    }
}