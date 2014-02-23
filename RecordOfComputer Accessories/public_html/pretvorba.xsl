<?xml  version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html" encoding="UTF-8" standalone="no" 
doctype-system="http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" 
doctype-public="-//W3C//DTD XHTML 1.0 Strict//EN"/> 

<xsl:template match="/">
  <html>

<head>
	<link rel="stylesheet" type="text/css" href="dizajn.css" >
	<title>Evidencija računalne opreme</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"></meta>
</link></head>
<body>
<div id="container">
<div id="header">
	<h1 >Računalna oprema Fakulteta elektrotehnike i računarstva</h1>
	<div id="picture"> <a href="index.html">
	<img src="slika1.jpg" alt="Slika"> </img></a></div>
</div>

<div id="sidebar" >
	<br></br>
	<br></br>
	<ul class = "b">
		<li><a href="index.html">Početna stranica</a></li>
		<li><a href="obrazac.html">Pretraga</a></li>
		<li><a href="podaci.xml">Tablica - primjer</a></li>
		<li><a href="http://www.fer.unizg.hr/rasip">RASIP</a></li>
		<li><a href="http://www.fer.unizg.hr/" target="_blank">FERweb</a></li>
		<li><a href="mailto:jelena.cvitanovich@gmail.com?Subject=Upit">Kontakt</a></li>
	</ul>
</div>

<div id="content" >
	
	<h2>Primjer bilježenja relevantnih podataka o opremi</h2>
	<br></br>
	
    <table border="1">
      <tr>
        
        <th>Naziv računala</th>
		<th>Identifikacijski broj</th>
		<th>Naziv procesora</th>
		<th>Frekvencija procesora</th>
		<th>Količina RAM-a</th>
		<th>Kapacitet memorije tvrdog diska</th>
      </tr>
      <xsl:for-each select="podaci/racunalo">
      <tr>
        
        <td><xsl:value-of select="naziv"/></td>
		<td><xsl:value-of select="@id"/></td>		
		<td><xsl:value-of select="procesor/naziv_procesora"/></td>
		<td><xsl:value-of select="procesor/frekvencija_procesora"/></td>
		<td><xsl:value-of select="kolicina_rama"/></td>
		<td><xsl:value-of select="tvrdi_disk/kapacitet"/></td>
		
      </tr>
      </xsl:for-each>
    </table>
	
	
</div>


<div id="footer" >
<p>Jelena Cvitanović </p>
<p>Akademska godina 2011./2012. </p>
</div>
</div>
</body></html>
</xsl:template>

</xsl:stylesheet>
