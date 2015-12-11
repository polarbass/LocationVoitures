<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Commande.aspx.cs" Inherits="Devoir_Librairy_v2.Commande" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">

    <div>

        <h1>Commande</h1>
        
        <hr />

        <div>

            <h3>Vos information</h3>

            <asp:Label ID="lblNom" Text="Nom : " AssociatedControlID="txtNom" runat="server">
                <asp:TextBox ID="txtNom" runat="server" />
            </asp:Label>

            <br />

            <asp:Label ID="lblPrenom" Text="Prenom : " AssociatedControlID="txtPrenom" runat="server">
                <asp:TextBox ID="txtPrenom" runat="server" />
            </asp:Label>

            <br />

            <asp:Label ID="lblAdresse" Text="Adresse : " AssociatedControlID="txtAdresse" runat="server">
                <asp:TextBox ID="txtAdresse" runat="server" />
            </asp:Label>

            <br />

            <asp:Label ID="lblPostalCode" Text="Code Postal : " AssociatedControlID="txtCodePostal" runat="server">
                <asp:TextBox ID="txtCodePostal" runat="server" />
            </asp:Label>
    
            <br />

             <asp:Label ID="lblCouriel" Text="Courriel : " AssociatedControlID="txtCouriel" runat="server">
                <asp:TextBox ID="txtCouriel" runat="server" />
            </asp:Label>

        </div>     

        <hr />
    
    </div>

    <div>

        <h5>
            Votre commande
        </h5>

        <asp:GridView ID="CartView" runat="server" AutoGenerateColumns="False">
            <columns>

                <asp:boundfield datafield="ISBN" headertext="ISBN"/>
                <asp:boundfield datafield="Titre" headertext="Titre"/>
                <asp:boundfield datafield="Prix" headertext="Prix"/>

            </columns>
        </asp:GridView>

        <br />     
        
    </div>

        <div>

            <asp:Label ID="lblTotal" Text="Total :" AssociatedControlID="orderTotalPrice" runat="server">
                <asp:TextBox ID="orderTotalPrice" runat="server" />
            </asp:Label>
 
            <asp:Button ID="btnOrder" runat="server" Text="Placer la commande" OnClick="btnOrder_Click" />

        </div>     

    </form>

</body>

</html>
