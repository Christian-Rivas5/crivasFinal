using crivasFinal.Modelos;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace crivasFinal.Views;

public partial class vListar : ContentPage
{

    private const string url = "http://localhost/moviles/webPersona.php";
    private readonly HttpClient cliente = new HttpClient();
    private ObservableCollection<Persona> person;
    public vListar()
    {
        ObtenerDatos();

	}

    public async void ObtenerDatos()
    {
        System.Diagnostics.Debug.WriteLine("This is a log");
        var contetnt = await cliente.GetStringAsync(url);
        System.Diagnostics.Debug.WriteLine("asdasdsadasdsadas " + contetnt);
        List<Persona> mostrar = JsonConvert.DeserializeObject<List<Persona>>(contetnt);
        person = new ObservableCollection<Persona>(mostrar);
        listPersonas.ItemsSource = person;
    }
}