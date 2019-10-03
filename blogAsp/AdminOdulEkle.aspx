<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminOdulEkle.aspx.cs" Inherits="blogAsp.AdminOdulEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Ödül Ekle"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Odul Ekle" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
