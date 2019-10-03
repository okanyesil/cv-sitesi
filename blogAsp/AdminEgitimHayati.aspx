<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminEgitimHayati.aspx.cs" Inherits="blogAsp.AdminEgitimHayati" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" id="form1">
    <table   class="table table-bordered">
        <tr>
            <th>Başlık</th>
            <th>Alt Başlık</th>
            <th>Açıklama</th>
            <th>Gnot</th>
            <th>Tarih</th>
            <th>İşlem</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
            <tr>
                <td><%# Eval("BASLIK") %></td>
                <td><%# Eval("ALT_BASLIK") %></td>
                <td><%# Eval("ACIKLAMA") %></td>
                <td><%# Eval("GNOT") %></td>
                <td><%# Eval("TARIH") %></td>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"AdminEgitimSil.aspx?ID=" + Eval("ID")%>' CssClass="btn btn-danger">Sil</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"AdminEgitimGuncelle.aspx?ID="+ Eval("ID") %>' CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
          
    </table>
    <asp:Button ID="Button1" runat="server" Text="Egitim  Ekle" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
