<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ListadoCompletoProductos.aspx.cs" Inherits="Datos_EliminarProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style7
        {
            font-size: x-large;
            color: #0000CC;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <span class="style7"><strong>LISTADO COMPLETO</strong></span><br />
&nbsp;
        <asp:Image ID="Image5" runat="server" Height="58px" 
            ImageUrl="~/Images/nombreanimado (1).gif" Width="413px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
            
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            &nbsp;<br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" 
                    oncheckedchanged="CheckBox1_CheckedChanged" 
                    style="font-weight: 700; font-size: large; color: #000000" 
                    Text="Filtrar por Categorias" />
                <br />
                <asp:ListBox ID="lstCategorias" runat="server" AutoPostBack="True" 
                    Height="95px" onselectedindexchanged="lstCategorias_SelectedIndexChanged" 
                    style="font-size: medium; font-weight: 700" Width="273px"></asp:ListBox>
                <br />
            <asp:GridView ID="dg1" runat="server"
             AutoGenerateColumns="False" AutoPostBack="True"  
                BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                AllowPaging="True" AllowSorting="True"   CellPadding="4" 
        CellSpacing="2" DataKeyNames="ProductID" ForeColor="Black" 
                Height="235px" onrowdeleting="dg1_RowDeleting" PageSize="5" 
                style="font-size: small; text-align: right;" Width="210px" 
        AutoGenerateEditButton="True" AutoGenerateSelectButton="True" 
        onpageindexchanging="dg1_PageIndexChanging" onsorting="dg1_Sorting">
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
                    <asp:TemplateField HeaderText="Eliminar">
                        <ItemTemplate>
                            <span onclick="return confirm('Desea seleccionar este CLIENTE?')">
                            <asp:LinkButton ID="lkbEliminar" runat="server" CommandName="Delete">Eliminar</asp:LinkButton>
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
    <br />
    <br />
</asp:Content>

