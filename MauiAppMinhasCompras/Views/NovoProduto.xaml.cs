using MauiAppMinhasCompras.Models;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto produto = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(produto);
			await DisplayAlert("SUCESSO!", "REGISTRO INSERIDO", "OK");
		}
		catch (Exception ex)
		{

			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}