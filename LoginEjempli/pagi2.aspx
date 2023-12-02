<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="pagi2.aspx.cs" Inherits="LoginEjempli.pagi2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                 <div class="text-center">
     <h1> ASIGNACIONES </h1>
 </div>

     <div>
     <br />
     <asp:GridView runat="server" ID="datagrid" PageSize="10" HorizontalAlign="Center"
         CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
         RowStyle-CssClass="rows" AllowPaging="True"    />
    <br />
</div>
    <div class="container text-center">
        AsignacionID:
        <asp:TextBox ID="TIdasignacion" CssClass="form-control" runat="server"></asp:TextBox>
        ReparacionID:
         <asp:TextBox ID="TIdReparacion" CssClass="form-control" runat="server"></asp:TextBox>
        TecnicoID:
         <asp:TextBox ID="TIdTecnico" CssClass="form-control" runat="server"></asp:TextBox>
        Fecha de asignacion:
        <asp:TextBox ID="TFechaAsig" CssClass="form-control" runat="server"></asp:TextBox>

    </div>

<div class="container text-center">
    <asp:Button ID="Button5" runat="server" class="btn btn-outline-primary" Text="Agregar"  />
    <asp:Button ID="Button1" runat="server" class="btn btn-outline-primary" Text="Borrar"  />
    <asp:Button ID="Button2" runat="server" class="btn btn-outline-primary" Text="Modificar"  />
    <asp:Button ID="Button3" runat="server" class="btn btn-outline-primary" Text="Consultar"  />
</asp:Content>
