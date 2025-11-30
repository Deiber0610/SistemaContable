<%@ Page Title="Mayorizacion" Language="C#" MasterPageFile="~/Views/Site.Master" AutoEventWireup="true" CodeBehind="Mayor.aspx.cs" Inherits="SistemaContable.Views.Mayor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2> Mayor Contable</h2>

    <asp:GridView ID="gvMayor" runat="server" AutoGenerateColumns="false"
                    CssClass=" table table-bordered" HeaderStyle-BackColor=" #ccccc">

        <Columns>
            <asp:BoundField DataField="Codigo" HeaderText="Código" />
            <asp:BoundField DataField="Nombre" HeaderText="Cuenta" />
            <asp:BoundField DataField="Tipo" HeaderText="Tipo" />

            <asp:BoundField DataField="totalDebe" HeaderText="Debe" DataFormatString="{0:N2" />
            <asp:BoundField DataField="totalHaber" HeaderText="Haber" DataFormatString="{0:N2" />
            <asp:BoundField DataField="saldo" HeaderText="Saldo" DataFormatString="{0:N2" />


        </Columns>
    </asp:GridView>
</asp:Content>
