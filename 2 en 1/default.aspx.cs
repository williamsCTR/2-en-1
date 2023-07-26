using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_en_1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //desplegables que se utilizan en el convertidor
            if (!IsPostBack)
            {
                ddlUnidades.Items.Add("Milímetro(mm)");
                ddlUnidades.Items.Add("Centímetro(cm)");
                ddlUnidades.Items.Add("Decímetro(dm)");
                ddlUnidades.Items.Add("Metro(m)");
                ddlUnidades.Items.Add("Decámetro(dam)");
                ddlUnidades.Items.Add("Hectómetro(hm)");
                ddlUnidades.Items.Add("Kilómetro(km)");

                ddlUnidadesA.Items.Add("Milímetro(mm)");
                ddlUnidadesA.Items.Add("Centímetro(cm)");
                ddlUnidadesA.Items.Add("Decímetro(dm)");
                ddlUnidadesA.Items.Add("Metro(m)");
                ddlUnidadesA.Items.Add("Decámetro(dam)");
                ddlUnidadesA.Items.Add("Hectómetro(hm)");
                ddlUnidadesA.Items.Add("Kilómetro(km)");
            }
        }

        //------- CALCULADORA -----------
        private void agregarNumero(string numero)
        {
            if (txtPantalla.Text == "0" || txtPantalla.Text == "00")
            {
                txtPantalla.Text = "";
            }
            string aux = txtPantalla.Text;
            txtPantalla.Text = aux + numero;
        }

        //------NUMEROS Y COMA -------
        protected void btnCero_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnUno_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnDos_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnTres_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnCuatro_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnCinco_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnSeis_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnSiete_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnOcho_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnNueve_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnDobleCero_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        protected void btnComa_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        //------OPERADORES------
        protected void btnSuma_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            lblPantallaSecundariaOperador.Text = boton.Text;
            txtPantallaSecundariaNumero1.Text = txtPantalla.Text;
            txtPantalla.Text = "0";
            txtPantallaSecundariaNumero2.Text = "0";
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            lblPantallaSecundariaOperador.Text = boton.Text;
            txtPantallaSecundariaNumero1.Text = txtPantalla.Text;
            txtPantalla.Text = "0";
            txtPantallaSecundariaNumero2.Text = "0";
        }

        protected void btnResta_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            lblPantallaSecundariaOperador.Text = boton.Text;
            txtPantallaSecundariaNumero1.Text = txtPantalla.Text;
            txtPantalla.Text = "0";
            txtPantallaSecundariaNumero2.Text = "0";
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            lblPantallaSecundariaOperador.Text = boton.Text;
            txtPantallaSecundariaNumero1.Text = txtPantalla.Text;
            txtPantalla.Text = "0";
            txtPantallaSecundariaNumero2.Text = "0";
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtPantallaSecundariaNumero1.Text);
            double num2 = double.Parse(txtPantalla.Text);
            txtPantallaSecundariaNumero2.Text = num2.ToString();

            switch (lblPantallaSecundariaOperador.Text)
            {
                case "+":
                    double suma = num1 + num2;
                    txtPantalla.Text = suma.ToString();
                    break;

                case "-":
                    double resta = num1 - num2;
                    txtPantalla.Text = resta.ToString();
                    break;

                case "÷":
                    double dividir = num1 / num2;
                    txtPantalla.Text = dividir.ToString();
                    break;

                case "×":
                    double multiplicar = num1 * num2;
                    txtPantalla.Text = multiplicar.ToString();
                    break;
            }
        }

        protected void btnC_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            txtPantallaSecundariaNumero1.Text = "0";
            txtPantallaSecundariaNumero2.Text = "0";
            lblPantallaSecundariaOperador.Text = "+";
        }
        protected void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 1)
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
            }
            else
            {
                txtPantalla.Text = "0";
            }
        }
        //--------------------------------------------------------------------------
        //------ CONVERTIDOR ------

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text=="")
            {
                txtNumero.Text = "0";
                lblResultado.Text = "0";
            }

            double unidad = double.Parse(txtNumero.Text);
            double unidadEnM = 0;
            double unidadConvertida;
         //----- convertimos la unidad a metros  para luego convertirla a la unidad selecionada ---
            switch (ddlUnidadesA.Text)
            {
                case "Milímetro(mm)":
                    unidadEnM = unidad * 1000;
                    break;

                case "Centímetro(cm)":
                    unidadEnM = unidad * 100;
                    break;

                case "Decímetro(dm)":
                    unidadEnM = unidad * 10;
                    break;

                case "Metro(m)":
                    unidadEnM = unidad;
                    break;

                case "Decámetro(dam)":
                    unidadEnM = unidad / 10;
                    break;

                case "Hectómetro(hm)":
                    unidadEnM = unidad / 100;
                    break;

                case "Kilómetro(km)":
                    unidadEnM = unidad / 1000;
                    break;

            }
        //---- convertimos el valor en metros a la unidad seleccionada
            if (ddlUnidades.Text == "Metro(m)")
            {
                unidadConvertida = unidadEnM;
                lblResultado.Text = unidadConvertida.ToString();

            }
            else
            {
                switch (ddlUnidades.Text)
                {
                    case "Milímetro(mm)":
                        unidadConvertida = unidadEnM / 1000;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;

                    case "Centímetro(cm)":
                        unidadConvertida = unidadEnM / 100;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;

                    case "Decímetro(dm)":
                        unidadConvertida = unidadEnM / 10;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;

                    case "Metro(m)":
                        unidadConvertida = unidadEnM;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;

                    case "Decámetro(dam)":
                        unidadConvertida = unidadEnM * 10;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;

                    case "Hectómetro(hm)":
                        unidadConvertida = unidadEnM * 100;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;

                    case "Kilómetro(km)":
                        unidadConvertida = unidadEnM * 1000;
                        lblResultado.Text = unidadConvertida.ToString();
                        break;
                }
            }

        }
    }
}