using System.Net;

namespace crivasFinal.Views;

public partial class vNuevo : ContentPage
{
   

    public vNuevo()
	{
		InitializeComponent(
			
			);
	}


    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("id", txtid.Text);
            parametros.Add("cedula", txtCedula.Text);
            parametros.Add("nombre", txtNombre.Text);
            parametros.Add("apellido", txtApellido.Text);

            cliente.UploadValues("http://localhost/moviles/webPersona.php", "POST", parametros);
        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message, "Cerrar");
            throw;
        }

    }

    private void btnBuscar_Clicked(object sender, EventArgs e)
    {


    }
}