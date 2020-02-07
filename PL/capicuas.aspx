﻿<%@ Page Title="Capicuas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="capicuas.aspx.cs" Inherits="PL.Capicuas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!--HEADER START-->
    <div class="container">
        <h3>Validar Capicuas</h3>
    </div>
    <!--HEADER END-->

    <!--INPUT START-->
    <div class="jumbotron">
        <p style="font-size: large">Por favor ingrese un numero dentro de la caja de texto y presione el boton validar, que se encargara de validar si la palabra ingresada es o no es un capicua.</p>
        <br />
        <div class="row-cols-1">
            <input id="word" type="text" runat="server" class="col" placeholder="numero" onkeypress="return isNumber(event)" style="text-align: center; font-size: large; max-width: 50%; border-radius: 6px" />
        </div>
        <br />
        <div class="row-cols-1">
            <input id="validate" type="button" runat="server" value="Validar" class="btn btn-primary btn-lg" onserverclick="Validar_Click" style="width: 50%;font-size: large" />
        </div>
        <br />
        <div class="row-cols-1">
            <input id="reverse" type="text" runat="server" class="col" style="background-color: #282828; border: none; color: white; text-align: center; font-size: large; max-width: 50%; border-radius: 6px" />
        </div>
        <br />
        <div class="row-cols-1">
            <input id="result" type="text" runat="server" class="col" style="background-color: #282828; border: none; color: white; text-align: center; font-size: large; max-width: 50%; border-radius: 6px" />
        </div>
    </div>
    <!--INPUT END-->
</asp:Content>
