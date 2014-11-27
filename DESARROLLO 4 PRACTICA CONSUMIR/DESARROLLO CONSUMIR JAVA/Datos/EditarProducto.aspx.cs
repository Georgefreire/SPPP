using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Datos_EditarProducto : System.Web.UI.Page
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
            //int id =Convert.ToInt32( lstCategorias.SelectedValue.ToString());
            //dg1.DataSource = servicioJava.SelectProductos(id);
            //dg1.DataBind();

            ddlCategorias.DataSource = servicioJava.SelectCategorias();
            ddlCategorias.DataValueField = "CategoryID";
            ddlCategorias.DataTextField = "CategoryName";
            ddlCategorias.DataBind();
          

        }
    }
    protected void lstCategorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(lstCategorias.SelectedValue.ToString());
        dg1.DataSource = servicioJava.SelectProductos(id);
        dg1.DataBind();
    }
  
    protected void gvClientes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {

        GridViewRow row = dg1.Rows[e.NewSelectedIndex];

        TextBox customerid = (TextBox)row.FindControl("txtProductID");

        txtProductoID.Text = customerid.Text;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void gvDs_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void gvClientes_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void gvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    protected void gvClientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
    protected void gvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void gvClientes_Sorting(object sender, GridViewSortEventArgs e)
    {

    }
    protected void dg1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    protected void dgv1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

     

     
    }
    protected void lkbEliminar_Click(object sender, EventArgs e)
    {
       
    }
    protected void dg1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string ID = dg1.DataKeys[e.RowIndex].Value.ToString();
        int customerID = Convert.ToInt16(ID);
        txtProductoID.Text = "" + customerID;

        string[] productos = new string[6];

        productos = servicioJava.SelectProductosPK(customerID);

        txtNombre.Text=productos[0];
        txtCanntidad.Text = productos[1];
        txtPrecio.Text = productos[2];
        txtStock.Text = productos[3];
        txtDisc.Text =productos[4];
        ddlCategorias.SelectedValue= (productos[5]);
     
    }
    protected void btnGuardar0_Click(object sender, ImageClickEventArgs e)
    {


        String texto = txtProductoID.Text;
              
        if (texto !="")
        {
            int idpro = Convert.ToInt32(texto);
            bool inserta;

            string nombre, quantiti;
            int CategoryID;
            double precio;
            nombre = txtNombre.Text;
            quantiti = txtCanntidad.Text;
            CategoryID = Convert.ToInt32(ddlCategorias.SelectedValue.ToString());
            precio = Convert.ToDouble(txtPrecio.Text);
            inserta = servicioJava.UpdateProductos(nombre,CategoryID,quantiti,precio,idpro);
           
          
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
        else  
        {

            Response.Write("<script>window.Error('ASEGURECE DE TOMAR UN DATO A ACTUALIZAR PORFAVOR¡¡');</script>");
        }
    
    }
    protected void ddlDiscontinuado_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
}