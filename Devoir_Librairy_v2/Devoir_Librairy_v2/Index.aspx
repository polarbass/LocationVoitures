<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Devoir_Librairy_v2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ouvrages</title>
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

        <%--    
        <asp:Label ID="labelCategorie" Text="Catégorie :" AssociatedControlID="comboCategorie" runat="server">
            <asp:DropDownList ID="comboCategorie" runat="server">
                <asp:ListItem Text="Informatique" Value="0"></asp:ListItem>
                <asp:ListItem Text="Science et techniques" Value="1"></asp:ListItem>
                <asp:ListItem Text="Audiovisuel" Value="2"></asp:ListItem>
                <asp:ListItem Text="Bâtiments et travaux publics" Value="3"></asp:ListItem>
                <asp:ListItem Text="Vie pratique" Value="4"></asp:ListItem>
            </asp:DropDownList>    
        </asp:Label>
        --%>

    </div>

    <br />
    <hr />
    <br />

        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False">
            <columns>
                <asp:boundfield datafield="ISBN" headertext="ISBN"/>
                <asp:boundfield datafield="Titre" headertext="Titre"/>
                <asp:boundfield datafield="Auteur" headertext="Auteur"/>
                <asp:boundfield datafield="Prix" headertext="Prix"/>
                <asp:boundfield datafield="Date" headertext="Date de parution"/>
                <asp:boundfield datafield="NbPages" headertext="Nb Pages"/>
                <asp:buttonfield buttontype="Button" commandname="Select" headertext="Commande" text="Ajouter au panier"/>
            </columns>
        </asp:GridView>


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
