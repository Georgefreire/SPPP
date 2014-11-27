using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Datos_EditarCategoria : System.Web.UI.Page
{
    localhost.DMLService servicioJava = new localhost.DMLService();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            

            ddlCategorias.DataSource=servicioJava.SelectCategorias();
            ddlCategorias.DataValueField="CategoryID";
            ddlCategorias.DataTextField ="CategoryName";
            ddlCategorias.DataBind();
            txtNombreCategoria.Text = ddlCategorias.SelectedItem.ToString();
            txtDescripcionCategoria.Text = servicioJava.SELECTCATEGORIASPK(Convert.ToInt32(ddlCategorias.SelectedValue.ToString()));


        }
    }
    protected void btnGuardar0_Click(object sender, ImageClickEventArgs e)
    {
        int codigo = 0;
       

        codigo=Convert.ToInt32( ddlCategorias.SelectedValue.ToString());
        if (codigo != 0)
        {
            bool inserta;
       
        string nombre, deescripcion;
        nombre  =  txtNombreCategoria.Text.ToUpper();
        
        deescripcion = txtDescripcionCategoria.Text.ToUpper();

       
            inserta = servicioJava.UpdateCategorias(nombre, deescripcion, codigo);
            if (inserta == true)
            {
                Response.Write("<script>window.alert('EL DATO SE ACTUALIZO CORRECTAMENTE');</script>");
                // Label1.Text = "EL DATO SE INSERTO CORRECTAMENTE";

            }

            else
            {
                Response.Write("<script>window.Error('OCURRIO UN ERROR AL ACTUALIZAR EL DATO¡¡');</script>");
            }
        }
        else {
            
            Response.Write("<script>window.Error('ASEGURECE DE TOMAR UN DATO A ACTUALIZAR PORFAVOR¡¡');</script>");
        }
    
    }
    protected void ddlCategorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtNombreCategoria.Text = ddlCategorias.SelectedItem.ToString();
        txtDescripcionCategoria.Text = servicioJava.SELECTCATEGORIASPK(Convert.ToInt32(ddlCategorias.SelectedValue.ToString()));

        
    }
}