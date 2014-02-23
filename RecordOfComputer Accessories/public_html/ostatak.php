		Proizvoðaè raèunala:
		<?php
		echo getElement($item,'proizvodac')->nodeValue;
		?>
		<br />
		Naziv procesora:
		<?php
		echo getElement($item,'naziv_procesora')->nodeValue;
		?>
		<br />
		Frekvencija procesora:
		<?php
		echo getElement($item,'frekvencija_procesora')->nodeValue;
		?>
		<br />
		Broj procesora:
		<?php
		echo $item->getAttribute('broj_procesora');
		?>
		<br />
		<?php
            foreach($item->getElementsByTagName('tvrdi_disk') as $hd)
              {
				echo "Proizvodaè tvrdog diska: ";
				$p=getElement($hd,'hd_proizvodac');
				if (!empty($p)){
                echo getElement($hd, 'hd_proizvodac')->nodeValue;}
				else{
				echo "<br />";}
				echo "<br />";
				echo "Kapacitet tvrdog diska:";
                echo getElement($hd, 'kapacitet')->nodeValue;
				echo "<br />";
              }		
		?>
		Kolièina RAM-a:
		<?php
		echo getElement($item,'kolicina_rama')->nodeValue;
		?>
		<br />
		Datum kupnje:
		<?php
		$datum=getElement($item,'datum_kupnje');
		if(!empty($datum)){
		echo getElement($item,'datum_kupnje')->nodeValue;
		echo "<br />"	;	
		}
		else{
		echo "nepoznat <br />";}
		?>
		Inventarski broj:
		<?php
		echo $item->getAttribute('inv_broj');
		?>
		<br />
		Grafièka kartica:
		<?php
		echo getElement($item,'graficka_kartica')->nodeValue;
		?>
		<br />
		Broj USB ulaza:
		<?php
		echo $item->getAttribute('broj_usb_ulaza');
		?>
		<br />