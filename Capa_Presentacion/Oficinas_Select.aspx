<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Oficinas_Select.aspx.cs" Inherits="Capa_Presentacion.Oficinas_Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <h1>Oficinas</h1>

    <p>
        <a href="Oficina_Insert.aspx">Ingresar Nueva oficina</a>
    </p>

    <table border="1">
        <thead>
            <tr>
                <th>Id Oficina</th>
                <th>Nombre</th>
                <th>Telefono</th>
                <th colspan="2">Opciones</th>
            </tr>
        </thead>

        <tbody id="tabla_body" runat="server">
         
        </tbody>

    </table>


    <p>
        <a href="index.html">Volver al Inicio</a>
    </p>
</body>
</html>
