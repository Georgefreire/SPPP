<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style7
        {
            width: 100%;
        }
        .style8
        {
        }
        .style9
        {
            width: 486px;
        }
    </style>
</asp:Content>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>

    <script language="javascript" >
        function abrir() {
            window.open("~Datos/InsertarProductos.aspx", settings)
        }
</script>
        &nbsp;</p>
    <table class="style7">
        <tr>
            <td class="style8">

          
        <asp:Image ID="Image2" runat="server" Height="374px" ImageAlign="Left" 
            style="text-align: center; margin-left: 5px; margin-top: 11px;" 
            Width="396px" />


                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />


        <asp:SlideShowExtender ID="SlideShowExtender1" runat="server"  TargetControlID="Image2"
                SlideShowServiceMethod="GetImages"      AutoPlay="true" Loop="true" >



        </asp:SlideShowExtender>

            </td>
            <td class="style9">
                <asp:Button ID="btnNuevo" runat="server" BorderStyle="Ridge" ForeColor="Black" 
                    Height="39px"   style="font-weight: 700"  
                    Text="NUEVO PRODUCTO" Width="253px" onclick="btnNuevo_Click1"
                   
                     />
                <br />
                <br />
                <asp:Button ID="btnActualizar" runat="server" BorderStyle="Ridge" 
                    ForeColor="Black" Height="39px" style="font-weight: 700" 
                    Text="ACTUALIZAR PRODUCTO" Width="253px" onclick="btnActualizar_Click" />
                &nbsp;<br />
                <br />
                <asp:Button ID="btnEliminar" runat="server" BorderStyle="Ridge" 
                    ForeColor="Black" Height="37px" style="font-weight: 700" 
                    Text="ELIMINAR PRODUCTO" Width="252px" onclick="btnEliminar_Click" />
                <br />
                <br />
                <asp:Button ID="btnListano" runat="server" BorderStyle="Ridge" 
                    ForeColor="Black" Height="36px" style="font-weight: 700" 
                    Text="LISTADO DE PRODUCTOS" Width="251px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style9">
                <asp:Image ID="Image3" runat="server" Height="304px" 
                    ImageUrl="~/Images/animated_delivery_man_with_boxes_zps4afe1e75.gif" 
                    Width="314px" />
            </td>
        </tr>
        <tr>
            <td class="style8" colspan="3">
                
                  <marquee heighht="52%" scrolldelay="100" 
                      style="font-weight: 700; font-size: x-large; color: #000099; font-style: italic">
            <font> TRABAJO DE DESARROLLO DE SOFTWARE IV , PAGINA WEB ASPNET USANDO WEBSERVICES DE JAVA ¡¡¡ INTEGRANTES: ESMERALDA ALENCASTRO , JORGE FREIRE , MIGUEL LOPEZ, ROSANA RUILOVA </font></marquee>

                &nbsp;</td>
        </tr>
    </table>

    <p>
        &nbsp;</p>
<p>
        </p>
</asp:Content>
