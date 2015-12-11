<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="panier.aspx.cs" Inherits="Devoir_Librairy_v2.panier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">

    <div>


        <h1>Liste des ouvrages</h1>
        
        <hr />

        <nav>
            <asp:Menu ID="Menu1" runat="server" DataSourceID="XmlDataSource1" OnMenuItemClick="Menu1_MenuItemClick">
                <DataBindings>
                    <asp:MenuItemBinding DataMember="Catégorie" TextField="Nom" ValueField="url" />
                </DataBindings>
            </asp:Menu>            
        </nav>

        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Catégories.xml" XPath="Catégories/Catégorie"></asp:XmlDataSource>     
    
    </div>

        <br />
        <hr />
        <br />

    <div style="background-color: lightslategrey">

        <asp:Label ID="labelSearchValue" Text="Recherche :" AssociatedControlID="searchValue" runat="server">
            <asp:TextBox ID="searchValue" runat="server" />
        </asp:Label>

        <asp:DropDownList ID="comboSearchBy" runat="server">
            <asp:ListItem Text="Auteur" Value="Auteur"></asp:ListItem>
            <asp:ListItem Text="Titre" Value="Titre"></asp:ListItem>
        </asp:DropDownList>
 
        <asp:Button ID="SearchButton" runat="server" Text="Submit" OnClick="SearchButton_Click" />

        <asp:Label ID="labelCategorie" Text="Catégorie :" AssociatedControlID="comboCategorie" runat="server">
            <asp:DropDownList ID="comboCategorie" DataSourceID="XmlDataSource1" runat="server" DataMember="Catégorie" DataTextField="Nom" DataValueField="code">
            </asp:DropDownList>    
        </asp:Label>

    </div>

    <br />
    <hr />
    <br />

    <div>

        <h5>
            Votre panier
        </h5>

        <asp:GridView ID="CartView" runat="server" OnRowCommand="CartView_RowCommand" AutoGenerateColumns="False">
            <columns>

                <asp:boundfield datafield="ISBN" headertext="ISBN"/>
                <asp:boundfield datafield="Titre" headertext="Titre"/>
                <asp:boundfield datafield="Prix" headertext="Prix"/>
                <asp:buttonfield buttontype="Button" commandname="Supprimer" headertext="" text="Supprimer"/>

            </columns>
        </asp:GridView>

        <br />     
        
    </div>

        <div id="affichageBtOrder">

            <asp:Label ID="lblTotal" Text="Total :" AssociatedControlID="orderTotalPrice" runat="server">
                <asp:TextBox ID="orderTotalPrice" runat="server" />
            </asp:Label>
 
            <asp:Button ID="btnOrder" runat="server" Text="Commander" OnClick="btnOrder_Click" />

        </div>     

    </form>

</body>

</html>
