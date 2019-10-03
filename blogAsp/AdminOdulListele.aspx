<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminOdulListele.aspx.cs" Inherits="blogAsp.AdminOdulListele" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <table class="table table-bordered">
                    <tr>
                        <th>Yetenek</th>
                        <th>İşlem</th>
                    </tr>
                    <tbody>
                        <tr>
                            <td><%#Eval("ODULLER")%></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"AdminOdulSil.aspx?ID=" + Eval("ID") %>' CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"AdminOdulGuncelle.aspx?ID="+Eval("ID") %>' CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink>

                            </td>
                        </tr>
                    </tbody>
                </table>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Button ID="Button1" runat="server" Text="Odul Ekle" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
