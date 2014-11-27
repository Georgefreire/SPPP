using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Datos_InsertarProductos : System.Web.UI.Page
{



    localhost.DMLService servicioJava = new localhost.DMLService();
    DataSet categorias = new DataSet();

    public void limpiar() {
        txtNombre.Text = "";
        txtCantidad.Text = "";    
    }

    protected void Page_Load(object sender, EventArgs e)
    {

      if (!Page.IsPostBack)
        {

            ddlCategorias.DataSource = servicioJava.SelectCategorias(); 
            ddlCategorias.DataValueField = "CategoryID";
            ddlCategorias.DataTextField = "CategoryName";
            ddlCategorias.DataBind();
        
        }
    }




    protected void btnGuardar0_Click(object sender, ImageClickEventArgs e)
    {
        String Nombre, Cantidad;

        bool inserta;
        Nombre = txtNombre.Text.ToUpper();
        Cantidad = txtCantidad.Text.ToUpper();

       int  codigoCategoria=Convert.ToInt32(ddlCategorias.SelectedValue.ToString());
       inserta = servicioJava.InsertarProductos(Nombre, codigoCategoria, Cantidad);
       if (inserta == true)
       {
           Response.Write("<script>window.alert('EL DATO SE INSERTO CORRECTAMENTE');</script>");
          // Label1.Text = "EL DATO SE INSERTO CORRECTAMENTE";
           limpiar();
       }

       else {
           Response.Write("<script>window.Error('OCURRIO UN ERROR AL INSERTAR EL DATO¡¡');</script>"); 
       }

    }
    protected void btnNuevo0_Click(object sender, ImageClickEventArgs e)
    {
        limpiar();
    }
}
