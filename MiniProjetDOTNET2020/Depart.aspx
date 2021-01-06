﻿<%@ Page Title="Listes des Departements" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Depart.aspx.cs" Inherits="MiniProjetDOTNET2020.Departement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
        <title>Listes des Departements</title>
    </head>
    
    <style>
        h2 
        {
            font-family: "Glacial Indifference";
            font-weight: bolder ;
            color : #042f66
        }
        table {
          font-family: "Glacial Indifference";
          width: 100%;
          box-shadow: 3px 3px 15px #2a2a2a22;
        }

        td, th {
          border: 1px solid #dddddd;
          text-align: left;
          padding: 8px;
        }

        tr:nth-child(even) {
          background-color: #dddddd;
        }
    </style>
    <body>
        <form id="form1" runat="server" style="margin-left : 20px" >
            <div style="margin-top : 20px" class="container">
                <h2>Listes des Departements</h2>
                <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateDeleteButton="True" DataKeyNames="Id" OnRowDeleting="GridView1_RowDeleting">
                </asp:GridView>
            </div>
            <div class="container"  style="margin-top : 20px" >
               <a href="DepartementControllers/AddDepartement.aspx" style="text-decoration : none ; color : #fff">
                       <button type="button" class="btn btn-primary">
                          Ajouter
                       </button>
                   </a>
               <a href="DepartementControllers/ModifierDepartement.aspx" style="text-decoration : none ; color : #fff">
                       <button type="button" class="btn btn-primary">
                          Modifier
                       </button>
               </a>
            </div>
        </form>
    </body>
    
</asp:Content>