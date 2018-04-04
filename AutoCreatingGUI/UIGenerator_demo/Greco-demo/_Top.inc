<html>
<head>
  <title><%=GetText("global.title")%></title>
  <link href="site.css" rel="stylesheet" type="text/css">
</head>

<body>
<h1><%=GetText("menu.admin")%></h1>
<hr>
<table width="100%" border="0" cellspacing="5">
  <tr>
    <td valign="top" width="140px">
      <div class="menu">
        <ucMenu:Menu id="menuControl" runat="server"></ucMenu:Menu>
      </div>
    </td>
    <td width="10px">&nbsp;</td>
    <td valign="top">

