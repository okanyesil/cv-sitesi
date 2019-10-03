﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimGuncelle.aspx.cs" Inherits="blogAsp.AdminEgitimGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
 
        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="Başlık"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Text='<%# Eval("BASLIK") %>'></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label2" runat="server" Text="Alt Başlık"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Text='<%# Eval("ALT_BASLIK") %>'></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label3" runat="server" Text="Açıklama"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="MultiLine" Text='<%# Eval("ACIKLAMA") %>'></asp:TextBox>
            </div>
             <div>
                <asp:Label ID="Label5" runat="server" Text="GNOT"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" Text='<%# Eval("GNOT") %>'></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label4" runat="server" Text="Tarih"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Text='<%# Eval("TARIH") %>'></asp:TextBox>
            </div>
            <br />
            <br />
            <br />
            
            <asp:Button ID="Button1" runat="server" Text="Eğitim Güncelle" CssClass="btn btn-warning" OnClick="Button1_Click" />
        
        </div>
    </form>

</asp:Content>
