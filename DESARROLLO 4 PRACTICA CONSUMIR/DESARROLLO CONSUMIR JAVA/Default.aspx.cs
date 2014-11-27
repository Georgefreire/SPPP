using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;
using AjaxControlToolkit;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    [WebMethod]
    [ScriptMethod]
    public static Slide[] GetImages()
    {
        List<Slide> slides = new List<Slide>();
        string path = HttpContext.Current.Server.MapPath("~/ImageDeslizante/");
        if (path.EndsWith("\\"))
        {
            path = path.Remove(path.Length - 1);
        }
        Uri pathUri = new Uri(path, UriKind.Absolute);
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            Uri filePathUri = new Uri(file, UriKind.Absolute);
            slides.Add(new Slide
            {
                Name = Path.GetFileNameWithoutExtension(file),
                Description = Path.GetFileNameWithoutExtension(file) + " Description.",
                ImagePath = pathUri.MakeRelativeUri(filePathUri).ToString()
            });
        }
        return slides.ToArray();
    }


    protected void Page_Load(object sender, EventArgs e)
    { 
       

    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {

        Server.Transfer("");
    }
    protected void btnNuevo_Click1(object sender, EventArgs e)
    {
        string str;
        str = "window.open('Datos/InsertarProductos.aspx','Titulo','width=1800,height=700,sc rollbars=no,resizable=no')";
        Response.Write("<script languaje=javascript>" + str + "</script>");
    }
    protected void btnActualizar_Click(object sender, EventArgs e)
    {
        string str;
        str = "window.open('Datos/EditarProducto.aspx','Titulo','width=1800,height=700,sc rollbars=no,resizable=no')";
        Response.Write("<script languaje=javascript>" + str + "</script>");
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        string str;
        str = "window.open('Datos/EliminarProductos.aspx','Titulo','width=1800,height=700,sc rollbars=no,resizable=no')";
        Response.Write("<script languaje=javascript>" + str + "</script>");
    }
}
