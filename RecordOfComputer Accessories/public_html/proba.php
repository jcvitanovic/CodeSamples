<?php
$str = "Mary Had A Little Lamb and She LOVED It So ŽÐÆŠÈ";
$str = strtolower($str);
echo $str; // Prints mary had a little lamb and she loved it so


	include('funkcije.php');
	error_reporting( E_ALL);


  $dom = new DOMDocument();
  $dom->load('podaci.xml');

  $xp = new DOMXPath($dom);
  $query = genUpit();
  echo $query

?>