<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ArkadhiaSoulsHunters.Presentacion.Login" %>
<asp:Content ID="Encabezado" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Cuerpo" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanelLogin" runat="server">
        <ContentTemplate>
            <asp:Label runat="server" Text="Nick: ">
                <asp:TextBox ID="nick" runat="server" Text="nick..."></asp:TextBox></asp:Label>
            <br />
            <asp:Label runat="server" Text="Clave: ">
                <asp:TextBox ID="clave" runat="server" Text="***" TextMode="Password"></asp:TextBox></asp:Label>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            <br />
            <asp:Label ID="mensaje" runat="server" Text="" CssClass="label_error" ></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
