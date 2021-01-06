<%@ Page Title="Modifier un cours" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ModifierCours.aspx.cs" Inherits="MiniProjetDOTNET2020.ModifierCours" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <body>
        <form id="form1" runat="server">
            <div style="margin-top : 20px ; width : 60%" class="container">

                <div style="margin-top : 20px" class="container">
                    <h2>Modifier un cours</h2>
                    <asp:GridView ID="CoursView" runat="server"  BorderStyle="Solid" CaptionAlign="Top" OnSelectedIndexChanged="CoursView_SelectedIndexChanged" AutoGenerateSelectButton="True" DataKeyNames="Id"  >
                    </asp:GridView>

                </div>
                <div class="container"  style="margin-top : 20px" >
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

                        <%--<asp:DropDownList ID="Proff" runat="server" CssClass="form-control" OnSelectedIndexChanged="Proff_SelectedIndexChanged1">
                        </asp:DropDownList>--%>

                         <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" OnPreRender="DropDownList1_PreRender">
                         </asp:DropDownList>

                    </div>
                    <div class="form-group">
                        <asp:Button ID="EditButton" runat="server" Text="Modifer" CssClass="btn btn-primary" OnClick="EditButton_Click"  />
                    </div>

                </div>
                
            </div>

        </form>
    </body>
</asp:Content>
