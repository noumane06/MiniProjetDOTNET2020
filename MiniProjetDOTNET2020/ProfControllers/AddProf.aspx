<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddProf.aspx.cs" Inherits="MiniProjetDOTNET2020.ProfControllers.AddProf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <body>
        <form id="form1" runat="server">
            <div style="margin-top : 20px ; width : 60%" class="container">

                <h2>Ajouter un cours</h2><br />
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Nom du Proffesseur :</label>
                    <asp:TextBox ID="NomProf" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Prenom du Proffesseur :</label>
                    <asp:TextBox ID="prenomProf" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Email :</label>
                    <asp:TextBox ID="Email" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Telephone :</label>
                    <asp:TextBox ID="Tel" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">CIN :</label>
                    <asp:TextBox ID="Cin" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Departements :</label>

                    <asp:DropDownList ID="Depart" runat="server" CssClass="form-control" OnSelectedIndexChanged="Depart_SelectedIndexChanged"  >
                    </asp:DropDownList>

                </div><br />

                <div class="form-group">

                    <asp:Button ID="AddButton" runat="server" Text="Ajouter" CssClass="btn btn-primary"  />

                </div>
            </div>

        </form>
    </body>
</asp:Content>
