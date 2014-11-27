<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditarCategoria.aspx.cs" Inherits="Datos_EditarCategoria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style7
        {
            font-size: x-large;
            color: #0000CC;
        }
        .style8
        {
            text-align: center;
        }
        .style9
        {
            width: 100%;
            border-color: #FFFF99;
            background-color: #99CCFF;
        }
        .style10
        {
            width: 460px;
        }
        .style11
        {
            color: #000099;
            font-size: large;
        }
        .style12
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p class="style8">
        <strong><span class="style7">EDITAR </span></strong>
    </p>
    <p class="style8">
        <asp:Image ID="Image3" runat="server" Height="65px" 
            ImageUrl="~/Images/nombreanimado (2).gif" Width="406px" />
    </p>
    <p class="style8">
        <br />
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
<br />
            <table class="style9">
                <tr>
                    <td class="style10" rowspan="4">
                        <asp:Image ID="Image2" runat="server" Height="154px" ImageAlign="Right" 
                            ImageUrl="~/Images/CATEIGORIAS.jpg" Width="156px" />
                    </td>
                    <td class="style11">
                        <b><span class="style11"><strong>SELECCIONE CATEGORIA:<br />
                        <asp:DropDownList ID="ddlCategorias" runat="server" AutoPostBack="True" 
                            Height="34px" onselectedindexchanged="ddlCategorias_SelectedIndexChanged" 
                            style="font-size: large" Width="192px">
                        </asp:DropDownList>
                        </strong></span>
                        <br />
                        <br />
                        Nombre de Categoria:<br />
                        <br />
                        </b>
                        <asp:TextBox ID="txtNombreCategoria" runat="server" style="font-size: medium" 
                            Width="215px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <strong>Descripcion</strong> <b>de Categoria:<br />
                        <br />
                        <asp:TextBox ID="txtDescripcionCategoria" runat="server" Height="65px" 
                            style="font-size: large" TextMode="MultiLine" Width="282px"></asp:TextBox>
                        </b>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style12">
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="btnGuardar0" runat="server" 
                                ImageUrl="~/Images/guardar.png" ToolTip="Guardar" 
                                onclick="btnGuardar0_Click" />
                            <span class="style11"><strong><em>GUARDAR CAMBIOS</em></strong></span></p>
    <p>
    </p>
</asp:Content>

