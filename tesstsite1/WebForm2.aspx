<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="tesstsite1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        
        body{
            background-color:dimgrey;
        }
        table{
            align-items:center;
        }
        tr{
            max-height:30px;
        }
        table, td{
            background-color:dodgerblue;
            color: black;
            padding-right:30px;
            padding-top:5px;
            padding-bottom:5px;
            font-family:'Hobo Std';
            font-size: 14px;
            

        }
    </style>

    <table>
        <tr>
            <td><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
            <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><asp:Label ID="lblConfirm" runat="server" Text=""></asp:Label></td>
            <td></td>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td><asp:Label ID="lblAge" runat="server" Text="Age"></asp:Label></td>
            <td><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td><asp:Label ID="lblAgeConfirm" runat="server" Text=""></asp:Label></td>
            <td></td>
            <td>&nbsp;</td>

        </tr>
        <tr>
            <td><asp:Label ID="lblFinal" runat="server" Text=""></asp:Label></td>
        </tr>
        <tr>
            <td>

                <asp:Button ID="btnGo" runat="server" Text="Confirm" OnClick="btnGo_Click" />

            </td>
        </tr>
        </table>

</asp:Content>
