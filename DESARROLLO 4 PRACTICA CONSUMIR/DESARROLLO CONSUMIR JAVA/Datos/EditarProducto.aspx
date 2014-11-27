<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditarProducto.aspx.cs" Inherits="Datos_EditarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style7
        {
            font-size: x-large;
            color: #000066;
        }
        .style8
        {
            text-align: center;
        }
        .style9
        {
            width: 100%;
            background-color: #99CCFF;
        }
        .style11
        {
            width: 15px;
        }
        .style14
        {
            font-size: medium;
            color: #000000;
        }
        .style15
        {
            font-size: large;
            color: #000000;
        }
        .style16
        {
            height: 21px;
            width: 15px;
            color: #000000;
        }
        .style13
        {
            color: #000000;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <p class="style8">
        <strong><span class="style7">EDITAR </span></strong></p>
    <p class="style8">
        <asp:Image ID="Image5" runat="server" Height="72px" 
            ImageUrl="~/Images/nombreanimado (1).gif" Width="413px" />
    </p>
    <p class="style8">
        &nbsp;</p>
    <p class="style8">
        &nbsp;</p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <strong><span class="style14"><span class="style13">SELECCIONAR CATEGORIA:</span></span></strong><br />
            <strong><span class="style14">
            <asp:ListBox ID="lstCategorias" runat="server" AutoPostBack="True" 
                Height="67px" onselectedindexchanged="lstCategorias_SelectedIndexChanged" 
                style="font-size: medium; font-weight: 700" Width="273px"></asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <span class="style13"><span class="style15">LISTADO DE PRODUCTOS</span></span><table class="style9">
                <tr>
                    <td class="style11" rowspan="2">
                        <strong><span class="style14">CODIGO:</span></strong><br />
                        <asp:TextBox ID="txtProductoID" runat="server" ReadOnly="True" 
                            style="font-weight: 700; font-size: large; color: #000066"></asp:TextBox>
                        <br />
                        <br />
                        <strong><span class="style15">NOMBRE:<br />
                        <asp:TextBox ID="txtNombre" runat="server" 
                            style="font-weight: 700; font-size: large; color: #000066"></asp:TextBox>
                        <br />
                        CantidadUnidades&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></strong>
                        <br />
                        <strong><span class="style15">
                        <asp:TextBox ID="txtCanntidad" runat="server" 
                            style="font-weight: 700; font-size: large; color: #000066"></asp:TextBox>
                        </span></strong>
                        <br />
                        <br />
                        <strong><span class="style15">Categoria</span></strong><br /> <b>
                        <span class="style11"><strong>
                        <asp:DropDownList ID="ddlCategorias" runat="server" AutoPostBack="True" 
                            Height="34px" style="font-size: large" Width="192px">
                        </asp:DropDownList>
                        </strong></span></b>
                        <br />
                        <br />
                        <strong><span class="style15">Precio&nbsp;&nbsp;</span></strong><br /> <strong>
                        <span class="style15">
                        <asp:TextBox ID="txtPrecio" runat="server" 
                            style="font-weight: 700; font-size: large; color: #000066" Width="143px"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Stock&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtStock" runat="server" ReadOnly="True" 
                            style="font-weight: 700; font-size: large; color: #000066" Width="143px"></asp:TextBox>
                        </span></strong>
                        <br />
                        <br />
                        <span class="style14"><strong>Discontinuado<br /> <span class="style15">
                        <asp:TextBox ID="txtDisc" runat="server" ReadOnly="True" 
                            style="font-weight: 700; font-size: large; color: #000066" Width="26px"></asp:TextBox>
                        </span></strong></span>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="style8">
                            <strong><span class="style14"><br />
                            </span></strong>
                        </div>
                        <asp:GridView ID="dg1" runat="server" AllowSorting="True" 
                            AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" 
                            BorderStyle="Solid" BorderWidth="3px" CellPadding="4" DataKeyNames="ProductID" 
                            ForeColor="Black" Height="235px" 
                            onrowdeleting="dg1_RowDeleting" 
                            onselectedindexchanged="GridView1_SelectedIndexChanged" 
                            onselectedindexchanging="gvClientes_SelectedIndexChanging" PageSize="5" 
                            style="font-size: small; text-align: right;" Width="210px" CellSpacing="2">
                            <FooterStyle BackColor="#CCCCCC" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="CategoryID" SortExpression="CategoryID">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtCategoryID" runat="server" Enabled="False" 
                                            Text='<%# Eval("CategoryID") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("CategoryID")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Discontinued" SortExpression="Discontinued">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtDiscontinued" runat="server" Enabled="False" 
                                            Text='<%# Eval("Discontinued") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("Discontinued")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ProductID" SortExpression="ProductID">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProductID" runat="server" Text='<%# Eval("ProductID") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("ProductID")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ProductName" SortExpression="ProductName">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtProductName" runat="server" 
                                            Text='<%# Eval("ProductName") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("ProductName")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="QuantityPerUnit" 
                                    SortExpression="QuantityPerUnit">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtQuantityPerUnit" runat="server" 
                                            Text='<%# Eval("QuantityPerUnit") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("QuantityPerUnit")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UnitPrice" SortExpression="UnitPrice">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtUnitPrice" runat="server" Text='<%# Eval("UnitPrice") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("UnitPrice")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UnitsInStock" SortExpression="UnitsInStock">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="txtUnitsInStock" runat="server" 
                                            Text='<%# Eval("UnitsInStock") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <%#Eval("UnitsInStock")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Seleccionar">
                                    <ItemTemplate>
                                        <span>
                                        <asp:LinkButton ID="lkbEliminar" runat="server" CommandName="Delete">Seleccionar</asp:LinkButton>
                                        </span>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                            </Columns>
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
                        </span>
                    </td>
                </tr>
            </table>
            </strong>
            </td>
            </tr>
            </table>
            </strong>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:ImageButton ID="btnGuardar0" runat="server" 
                                ImageUrl="~/Images/guardar.png" ToolTip="Guardar" 
                                onclick="btnGuardar0_Click" />
                            <span class="style16"><strong><em>GUARDAR CAMBIOS</em></strong></span></p>
   
    </p>
    <p>
    </p>
    <p>
    </p>
    
</asp:Content>

