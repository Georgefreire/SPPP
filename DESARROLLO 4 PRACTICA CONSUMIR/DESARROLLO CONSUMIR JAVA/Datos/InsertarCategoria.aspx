<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InsertarCategoria.aspx.cs" Inherits="Datos_InsertarCategoria" %>

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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p class="style8">
        <span class="style7"><strong>INSERTAR </strong></span>
    </p>
    <p class="style8">
        <asp:Image ID="Image3" runat="server" Height="70px" 
            ImageUrl="~/Images/nombreanimado (2).gif" Width="416px" />
        &nbsp;<br />
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
<br />
            <br />
            <table class="style9">
                <tr>
                    <td class="style10" rowspan="4">
                        <asp:Image ID="Image2" runat="server" Height="154px" ImageAlign="Right" 
                            ImageUrl="~/Images/CATEIGORIAS.jpg" Width="156px" />
                    </td>
                    <td class="style11">
                        <b>Nombre de Categoria:<br />
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
                        <asp:TextBox ID="txtDescripcionCategoria" runat="server" 
                            style="font-size: medium" Width="215px"></asp:TextBox>
                        </b>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
            <asp:Panel ID="Panel3" runat="server" BorderColor="Black" 
                            BorderStyle="Outset" BorderWidth="10px" Height="83px" HorizontalAlign="Center" 
                            style="margin-left: 197px" Width="665px">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:ImageButton 
                                ID="btnNuevo0" runat="server" Height="49px" 
                                ImageUrl="~/Images/nuevo.png" ToolTip="Nuevo" Width="56px" 
                                onclick="btnNuevo0_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="btnGuardar0" runat="server" 
                                ImageUrl="~/Images/guardar.png" ToolTip="Guardar" 
                                onclick="btnGuardar0_Click" />
                            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Nuevo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Guardar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </asp:Panel>
        </asp:Content>

