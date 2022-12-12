namespace PP2AndresNunez.MVVM.Views;

public partial class ANRecargasMain : ContentPage
{
	public ANRecargasMain()
	{
		InitializeComponent();
	}
    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (op1.IsChecked == true)
        {
            RecargaM.Text = "Ha seleccionado una recarga de 3$";
        }
        if (op2.IsChecked == true)
        {
            RecargaM.Text = "Ha seleccionado una recarga de 5$";
        }
        if (op3.IsChecked == true)
        {
            RecargaM.Text = "Ha seleccionado una recarga de 10$";
        }
        
    }
    
    private void Button_Clicked(object sender, EventArgs e)
    {
        var aja = DisplayAlert("Confirmación","¿Desea Recargar?","OK","Cancel");
        if (aja.IsCompleted)
        {
            DisplayAlert("Finalizado","Recarga Exitosa :D","OK");
        }
    }
}