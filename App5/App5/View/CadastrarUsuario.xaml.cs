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
	public partial class CadastrarUsuario : ContentPage
	{
		public CadastrarUsuario ()
		{
			InitializeComponent ();
		}

        public async void salvarUsuario()
        {
            Model.Usuario.Usuario s = new Model.Usuario.Usuario()
            {
                login = txtLogin.Text,
                name = txtNome.Text,
                senha = txtSenha.Text,

            };
            
            try
            {
               Sistema.Sistema.usuario =  await Sistema.Sistema.RESTAPI.postUsuariosAsync(s);

                await Navigation.PushModalAsync(new View.Login());

            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}