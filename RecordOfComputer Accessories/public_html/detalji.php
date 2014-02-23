<?php 

$id=$_GET['id'];
include('funkcije.php');

//function proba($id){

$dat = file_get_contents("http://localhost:8080/ORLab5/servlet");
  $dom = new DOMDocument();
  $dom->loadXML($dat);

  $xp = new DOMXPath($dom);
  
  $upit="/podaci/racunalo[contains(@id,'".$id."')]";

  $rezultat = $xp->query($upit);
  
	sleep(2);
  
  foreach($rezultat as $b)
  {
  echo "Podaci o odabranom računalu </br> </br>";
  echo "Proizvodac: ".$b->getElementsByTagName('proizvodac')->item(0)->nodeValue."</br>";
  echo "Procesor: </br>".$b->getElementsByTagName('naziv_procesora')->item(0)->nodeValue."</br>";
  echo "Frekvencija: ".$b->getElementsByTagName('frekvencija_procesora')->item(0)->nodeValue."</br>";
  echo "Broj procesora:  ".$b->getAttribute('broj_procesora')."</br>";
  echo "Tvrdi disk: </br>".$b->getElementsByTagName('hd_proizvodac')->item(0)->nodeValue."</br>";
  echo "kapacitet: ".$b->getElementsByTagName('kapacitet')->item(0)->nodeValue."</br>";
  echo "Kolicina RAM-a : ".$b->getElementsByTagName('kolicina_rama')->item(0)->nodeValue."</br>";
  echo "Datum kupnje: ".$b->getElementsByTagName('datum_kupnje')->item(0)->nodeValue."</br>";
  echo "Inventarski broj: ".$b->getAttribute('inv_broj')."</br>";
  echo "Grafička kartica: </br>".$b->getElementsByTagName('graficka_kartica')->item(0)->nodeValue."</br>";
  echo "Broj USB ulaza :".$b->getAttribute('broj_usb_ulaza')."</br></br>";
  
  
  
  
  
 
  }//echo getElement($trazeniRezultat,'naziv_procesora')->nodeValue;
  //echo getElement($trazeniRezultat,'frekvencija_procesora')->nodeValue;
  
  //}
  
  ?>



