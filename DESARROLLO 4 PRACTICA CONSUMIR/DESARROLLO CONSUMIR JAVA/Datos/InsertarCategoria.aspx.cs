using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Datos_InsertarCategoria : System.Web.UI.Page
{
    localhost.DMLService servicioJava = new localhost.DMLService();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void limpiar() {
        txtDescripcionCategoria.Text = "";
        txtNombreCategoria.Text = "";
    }
    protected void btnGuardar0_Click(object sender, ImageClickEventArgs e)
    {
        bool inserta;
        string nombre, deescripcion;
        nombre = txtNombreCategoria.Text.ToUpper();
       
      
        deescripcion = txtDescripcionCategoria.Text.ToUpper();
        inserta = servicioJava.InsertarCategorias(nombre, deescripcion);
        if (inserta == true)
        {
            Response.Write("<script>window.alert('EL DATO SE INSERTO CORRECTAMENTE');</script>");
            // Label1.Text = "EL DATO SE INSERTO CORRECTAMENTE";
            limpiar();
        }

        else
        {
            Response.Write("<script>window.Error('OCURRIO UN ERROR AL INSERTAR EL DATO¡¡');</script>");
        }
    }
    protected void btnNuevo0_Click(object sender, ImageClickEventArgs e)
    {
        limpiar();
    }
}