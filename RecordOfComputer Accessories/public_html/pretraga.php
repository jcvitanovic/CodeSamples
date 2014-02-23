<?php

	include('funkcije.php');
//	include('detalji.php');
	error_reporting( E_ALL);


  $dat = file_get_contents("http://localhost:8080/ORLab5/servlet");
  $dom = new DOMDocument();
  $dom->loadXML($dat);

  $xp = new DOMXPath($dom);
  $upit = genUpit();
  $rezultat = $xp->query($upit);
  
?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN"
"http://www.w3.org/TR/html4/strict.dtd">

<html>

<head>
	<link rel="stylesheet" type="text/css" href="dizajn.css" >
	<title>Evidencija računalne opreme</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<script type="text/javascript" src="detalji.js"></script>
</head>
<body>
<script type="text/javascript" src="wz_tooltip.js"></script>
<div id="container">
<div id="header">
	<h1 >Računalna oprema Fakulteta elektrotehnike i računarstva</h1>
	<div id="picture"> <a href="index.html">
	<img src="slika1.jpg" alt="Slika"> </a> </div>
</div>

<div id="wrapper">
<div id="sidebar" >
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
<div id="info" >
Detalji o računalu
</div>
</div>


<div id="content" >
<br />
<h3>  Vaša pretraga rezultirala je sljedećim podacima:</h3>
<?php
	#echo "$upit";
	?>
<br />
<br />
      <table class="d" border=1 summary="">
        <tr>
          <th>Naziv računala</th>
          <th>ID računala</th>
          <th>Lokacija</th>
          <th>Namjena računala</th>
          <th>Glavni OS</th>
		  <th>Dodatne specifikacije</th>
        </tr>
		<?php
			foreach ($rezultat as $item){
		?>
	
		
		<tr onmouseover="Tip('<?php tooltipText($item)?>')" onmouseout="UnTip()">
	
		<td>
		
		<?php
		echo getElement($item,'naziv')->nodeValue
		?>
		</td>
		<td>
		<?php
		echo $item->getAttribute('id');
		?>
		</td>
		<td>
		<?php
		echo $item->getAttribute('lokacija');
		?>
		</td>
		<td>
		<?php
		echo $item->getAttribute('namjena_racunala');
		?>
		</td>
		<td>
		<?php
		echo $item->getAttribute('glavni_os');
		?>
		</td>
		<td>
		</br>
		<button onclick="loadXMLDoc('<?php echo $item->getAttribute('id');?>')">Prikaži više</button>
		</br>
		</br>
		
		</td>
		</tr>
        <?php
          }
        ?>
     </table>		

</div>


<div id="footer" >
<p>Jelena Cvitanović </p>
<p>Akademska godina 2011./2012. </p>
</div>
</div>
<body/>
</html>


