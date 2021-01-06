<%@ Page Title="Ajouter cours" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AjouterCours.aspx.cs" Inherits="MiniProjetDOTNET2020.AjouterCours" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <form id="form1" runat="server">
            <div style="margin-top : 20px ; width : 60%" class="container">

                <h2>Ajouter un cours</h2><br />
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Nom du cours :</label>

                    <asp:TextBox ID="NomCours" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Module :</label>

                    <asp:TextBox ID="NomModule" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Description :</label>

                    <asp:TextBox ID="Descr" runat="server" CssClass="form-control"></asp:TextBox>

                </div>

                 <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Professeurs :</label>

                    <asp:DropDownList ID="Proff" runat="server" CssClass="form-control" OnSelectedIndexChanged="Proff_SelectedIndexChanged"  >
                    </asp:DropDownList>

                </div>
                <div class="form-group">

                    <asp:Button ID="AddButton" runat="server" Text="Ajouter" CssClass="btn btn-primary" OnClick="AddButton_Click" />

                </div>
            </div>

        </form>
    </body>
   
    
   
</asp:Content>
