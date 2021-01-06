<%@ Page Title="Modifier un departement" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModifierDepartement.aspx.cs" Inherits="MiniProjetDOTNET2020.DepartementControllers.ModifierDepartement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <form id="form1" runat="server">
            <div style="margin-top : 20px ; width : 60%" class="container">

                <div style="margin-top : 20px" class="container">
                    <h2>Modifier un cours</h2>
                    <asp:GridView ID="DepView" runat="server"  BorderStyle="Solid" CaptionAlign="Top" AutoGenerateSelectButton="True" DataKeyNames="Id" OnSelectedIndexChanged="DepView_SelectedIndexChanged" >
                    </asp:GridView>

                </div>
                <div class="container"  style="margin-top : 20px" >
                    <div class="form-group">

                        <label style="font-family :'Glacial Indifference' ; font-weight :bold">Nom du departement :</label>

                        <asp:TextBox ID="textbox1" runat="server" CssClass="form-control"></asp:TextBox>

                    </div>
                    <div class="form-group">

                        <label style="font-family :'Glacial Indifference' ; font-weight :bold">Budget :</label>

                        <asp:TextBox ID="textbox2" runat="server" CssClass="form-control"></asp:TextBox>

                    </div><br />
                    <div class="form-group">
                        <asp:Button ID="EditButton" runat="server" Text="Modifer" CssClass="btn btn-primary" OnClick="EditButton_Click"   />
                    </div>

                </div>
                
            </div>

        </form>
    </body>

</asp:Content>
