<%@ Page Title="Ajouter un Departement" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddDepartement.aspx.cs" Inherits="MiniProjetDOTNET2020.DepartementControllers.AddDepartement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
            <div style="margin-top : 20px ; width : 60%" class="container">

                <h2>Ajouter un Departement</h2><br />
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Nom du departement :</label>

                    <asp:TextBox ID="textbox1" runat="server" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="form-group">

                    <label style="font-family :'Glacial Indifference' ; font-weight :bold">Budget :</label>

                    <asp:TextBox ID="textbox2" runat="server" CssClass="form-control"></asp:TextBox>

                </div><br />
                <div class="form-group">

                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" OnClick="Button1_Click" Text="Ajouter" />

                </div>
            </div>

        </form>
</asp:Content>
