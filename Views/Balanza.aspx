<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Balanza.aspx.cs" Inherits="SistemaContable.Views.Balanza" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Balanza de Comprobación</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Balanza de Comprobación</h2>

        <asp:GridView ID="gridBalanza" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Código" />
                <asp:BoundField DataField="Nombre" HeaderText="Cuenta" />
                <asp:BoundField DataField="Debe" HeaderText="Debe" />
                <asp:BoundField DataField="Haber" HeaderText="Haber" />
                <asp:BoundField DataField="Saldo" HeaderText="Saldo" />
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>