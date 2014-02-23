<?php

  function getElement($node, $elementName)
  {
    return $node->getElementsByTagName($elementName)->item(0);
  }
 
  function upitAtJednak($atname) #generira dio upita za uneseno polje atributa zadanog naziva, s  vrijednošću unesenom u polje obrasca
  {
  if (!empty($_REQUEST[$atname]))
	{
	return "@".$atname."='".$_REQUEST[$atname]."'" ;  
	}
	else
	{
	return "";
	}
  }
  
  function atPodniz($atname) #generira dio upita koji provjerava sve koji sadrže podniz unesen u zadano polje u obrascu
  {
  if(!empty($_REQUEST[$atname]))
	  {
	  return "containts(@".$atname."'".$_REQUEST[$atname]."')" ;
	  }
  else
	  {
	  return "";
	  }
  }

     function upitAtsJednaki($atName) #funkcija za pretragu po checkboxovima - atributi
  {
    if (!empty($_REQUEST[$atName]))
    {
      foreach ($_REQUEST[$atName] as $attribute)
      {
        $fUpit[] = "@" . $atName . "='" . $attribute . "'";
      }
      return "(" . implode(" or ", $fUpit) . ")"; #budući da su checkboxovi za višestruki odabir, imploadamo ih sa or kao predikate
    }
    else
      return "";
  }
  
    function elPodniz($elName) #funkcija za textboxove i elemente
  {
    if(!empty($_REQUEST[$elName]))
      return "contains(" . $elName . ",'" . $_REQUEST[$elName] . "')"; #generira dio upita koji zadovoljava određeni kriterij
    return "";
  }
  
 function isEmpty($v) #funkcija koja se poziva kod filtriranja - uklanjamo prazne stringove
	{
	if ($v==="")
	  {
	  return false;
	  }
	return true;
	} 
  
    
  function genUpit()
  {
	$upit[]=upitAtJednak('id');
	$upit[]=upitAtJednak('inv_broj');
	$upit[]=upitAtsJednaki('namjena_racunala');
	$upit[]=upitAtsJednaki('lokacija');
	$upit[]=elPodniz('proizvodac');
	$upit[]=elPodniz('naziv');
	$upit[]=elPodniz('graficka_kartica');
	$upit[]=elPodniz('kolicina_rama');
	$upit[]=elPodniz('datum_kupnje');
	$upit[]=elPodniz('trajanje_jamstva');
	$upit[]=elPodniz('naziv_procesora');
	$upit[]=elPodniz('frekvencija_procesora');
	$upit[]=elPodniz('hd_proizvodac');
	$upit[]=elPodniz('kapacitet');
	$upit[]=upitAtJednak('broj_procesora');
	$upit[]=upitAtJednak('broj_usb_ulaza');
	$upit[]=upitAtJednak('glavni_os');
	
	
	$upit=array_filter($upit,"isEmpty"); #filtrira prazne dijelove upita
	$strUpit = implode(" and ", $upit); #kreira string za uput
	unset($upit);#resetira polje upita
	
	
	if (empty($strUpit))
      return '/podaci/racunalo'; #ako ništa nije postavljeno, vraćamo sve elementre iz xml-a

    $strUpit = '/podaci/racunalo[' . $strUpit . ']'; #inače upisujemo izgenerirani predikat
    return $strUpit;
	
	
	
	}
	function tooltipText ($item) {
		
		
		echo "Proizvodac: ".getElement($item,'proizvodac')->nodeValue."</br>Naziv procesora:".getElement($item,'naziv_procesora')->nodeValue."</br>Frekvencija procesora:".getElement($item,'frekvencija_procesora')->nodeValue;;
		
	
	}
	?>