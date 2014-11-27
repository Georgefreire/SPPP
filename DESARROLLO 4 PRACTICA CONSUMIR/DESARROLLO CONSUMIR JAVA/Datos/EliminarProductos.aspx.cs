using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Datos_EliminarProductos : System.Web.UI.Page
{
    localhost.DMLService servicioJava = new localhost.DMLService();
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {
            lstCategorias.DataSource = servicioJava.SelectCategorias();
            lstCategorias.DataMember = "Categories";
            lstCategorias.DataValueField = "CategoryID";
            lstCategorias.DataTextField = "CategoryName";
            lstCategorias.DataBind();

            lstCategorias.Visible = false;

            //int id = Convert.ToInt32(lstCategorias.SelectedValue.ToString());
            dg1.DataSource = servicioJava.SelectProductosTotal();
            dg1.DataBind();
        }

     


    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked==true)
        {
            lstCategorias.Visible = true;

        }
        else
        {
            lstCategorias.Visible = false;
        
        }
    }
    protected void dg1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string ID = dg1.DataKeys[e.RowIndex].Value.ToString();
        int customerID = Convert.ToInt16(ID);


     int inserta = servicioJava.deleteProductos(customerID);

     if (inserta == 0)
     {
         Label1.Text = "NO SE PUDO ELIIMINAR EL DATO SOORRRRYYYY";
     }
        
        if (inserta == 0)
        {
            Response.Write("<script>window.Error('OCURRIO UN ERROR AL ELIMINAR EL DATO¡¡');</script>");
           
          
        }

        else
        {
            Response.Write("<script>window.alert('EL DATO SE ELIMINO CORRECTAMENTE');</script>");
            dg1.DataSource = servicioJava.SelectProductosTotal();
            dg1.DataBind();
            if (CheckBox1.Checked)
            {
                int id = Convert.ToInt32(lstCategorias.SelectedValue.ToString());
                dg1.DataSource = servicioJava.SelectProductos(id);
                dg1.DataBind();
            }
        }


    }
    protected void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(lstCategorias.SelectedValue.ToString());
        dg1.DataSource = servicioJava.SelectProductos(id);
        dg1.DataBind();
    }
}