using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppS3JNarvaez.Modelos;

namespace AppS3JNarvaez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageHome : ContentPage
    {
        public PageHome(Usuario usuario)
        {
            InitializeComponent();
            lblBienvenido.Text = "Bienvenido " + usuario.nombre + " " + usuario.apellido;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double porcentajeUno = 0.3;
                double porcentajeDos = 0.2;

                double notaUno = Convert.ToDouble(txtNotaUno.Text);
                double notaDos = Convert.ToDouble(txtNotaUno.Text);

                double notaParcial = (notaUno * porcentajeUno) + (notaDos * porcentajeDos);

                txtResultadoUno.Text = notaParcial.ToString();

                double notaTres = Convert.ToDouble(txtNotaTres.Text);
                double notaCuatro = Convert.ToDouble(txtNotaCuatro.Text);

                double notaParcialDos = (notaTres * porcentajeUno) + (notaCuatro * porcentajeDos);

                txtResultadoDos.Text = notaParcialDos.ToString();

                double notaFinal = notaParcial + notaParcialDos;

                txtResultadoTotal.Text = notaFinal.ToString();

                if (notaFinal >= 7)
                {
                    txtEstado.Text = "Aprobado";
                }
                else if (notaFinal >= 5 && notaFinal <= 6.9)
                {
                    txtEstado.Text = "Complementario";
                }
                else
                {
                    txtEstado.Text = "REPROBADO";
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta ", ex.Message, "ok");
            }
        }
    }
}