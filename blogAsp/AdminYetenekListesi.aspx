<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminYetenekListesi.aspx.cs" Inherits="blogAsp.AdminYetenekListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">

    
    <table class="table table-bordered">
        <tr>
            <th>Yetenek</th>
            <th>İşlem</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

               
            <tr>
                <td><%#Eval("YETENEK") %></td>
                <td>
                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "AdminYetenekSil.aspx?ID=" + Eval("ID")%>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink> <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"AdminYetenekGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink>
                </td>
            </tr>
             </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <asp:Button ID="Button1" runat="server" Text="Yetenek Ekle" CssClass="btn btn-success" OnClick="Button1_Click" />
        </form>
</asp:Content>
