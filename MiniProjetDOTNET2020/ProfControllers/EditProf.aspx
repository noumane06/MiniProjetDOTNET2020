<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditProf.aspx.cs" Inherits="MiniProjetDOTNET2020.ProfControllers.EditProf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <form id="form1" runat="server">
            <div style="margin-top : 20px ; width : 60%" class="container">

                <div style="margin-top : 20px" class="container">
                    <h2>Modifier un Prof</h2>
                    <asp:GridView ID="ProfView" runat="server"  BorderStyle="Solid" CaptionAlign="Top" AutoGenerateSelectButton="True" DataKeyNames="Id" OnSelectedIndexChanged="ProfView_SelectedIndexChanged"   >
                    </asp:GridView>

                </div>
                <div class="container"  style="margin-top : 20px" >
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

                        <asp:DropDownList ID="Depart" runat="server" CssClass="form-control"  OnPreRender="Depart_PreRend"  >
                        </asp:DropDownList>

                    </div><br />

                    <div class="form-group">

                        <asp:Button ID="AddButton" runat="server" Text="Modifier" CssClass="btn btn-primary" OnClick="AddButton_Click"  />

                    </div>
                
                </div>

        </form>
    </body>
</asp:Content>
