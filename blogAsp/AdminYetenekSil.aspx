<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekSil.aspx.cs" Inherits="blogAsp.AdminYetenekSil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <asp:label runat="server" text="Silinecek Yetenek"></asp:label><br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Yetenek Sil" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
