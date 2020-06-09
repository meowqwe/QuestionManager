<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="FavoriteInfo.aspx.cs" Inherits="User_FavoriteInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="odsFavoriteInfo" Height="213px" Width="549px">
        <Columns>
            <asp:BoundField DataField="QBname1" HeaderText="题库名" SortExpression="QBname1" />
            <asp:BoundField DataField="QBqnum1" HeaderText="题目数量" SortExpression="QBqnum1" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" CommandArgument='<%Eval("QBname1") %>' CommandName="Btn" Text="开始做题" OnClick="LinkButton1_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    <asp:ObjectDataSource ID="odsFavoriteInfo" runat="server" SelectMethod="GetAllQuestionBank" TypeName="QBBLL.FavoriteManager">
        <SelectParameters>
            <asp:SessionParameter Name="Favorite" SessionField="CurFavorite" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

