using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppS3JNarvaez.Modelos;

namespace AppS3JNarvaez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                List<Usuario> usuarios = obtenerUsuarios();
                string usuario = txtUsuario.Text;
                string clave = txtPassword.Text;
                Usuario usu = null;
                //permite abrir la ventana
                for (int i = 0; i < usuarios.Count;i++){
                    if (usuarios[i].correo.Equals(usuario) && usuarios[i].password.Equals(clave)){
                         usu = usuarios[i];
                    }
                }

                if (usu!=null)
                {
                    await Navigation.PushAsync(new PageHome(usu));
                }
                else
                {
                    limpiarCampos();
                    await DisplayAlert("Mensaje", "Usuario o contraseña son incorrectos", "OK");
                }
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }

        }

        private List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario uno = new Usuario("estudiante2021", "estudiante2021", "Juan", "Narváez");
            Usuario dos = new Usuario("pedro@algo.com", "123456", "Pedro", "Ortiz");
            Usuario tres = new Usuario("luis@algo.com", "123456", "Luis", "Tufiño");
            Usuario cuatro = new Usuario("edison@algo.com", "123456", "Edison", "Espin");

            usuarios.Add(uno);
            usuarios.Add(dos);
            usuarios.Add(tres);
            usuarios.Add(cuatro);
            return usuarios;
        }

        private void limpiarCampos()
        {
            txtUsuario.Text ="";
            txtPassword.Text = "";
        }
    }
}
