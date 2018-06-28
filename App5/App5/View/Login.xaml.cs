using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
    {
		public Login ()
		{
			InitializeComponent ();
		}

        public async void logar()
        {
            try
            {
                if ((this.txtLogin.Text.Trim().Equals("") ) && (this.txtSenha.Text.Trim().Equals("")) ){
                   await DisplayAlert("","Preencha todos os campos","ok");
                   return;
                }
                Sistema.Sistema.usuario =  await Sistema.Sistema.RESTAPI.getLoginAsync(this.txtLogin.Text.Trim(),this.txtSenha.Text.Trim());
                if (Sistema.Sistema.usuario != null)
                {
                    await Navigation.PushModalAsync(new View.Menu());
                }
                else
                {
                    await DisplayAlert("", "Login ou senha inválido", "ok");
                }
               

            }
            catch (Exception e)
            {

                await DisplayAlert("", "Erro ao efetuar login " + e.Message, "ok");
            }
        }

        public async void cadastrar()
        {
            try
            {
                await Navigation.PushModalAsync(new View.CadastrarUsuario());

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}