package model.factory;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.Writer;
import java.util.Iterator;

import model.Racunalo;

public class Podaci {

	
	public static model.Podaci fromText(BufferedReader input) {

		//stvori objekt - listu kartica
		model.Podaci listaRacunala = new model.Podaci();
		
		//string koji sadr�i pro�itani redak datoteke
		String line = null;
		
		//trenutni redak datoteke
		int currentLine = 0;
		
		try {
		
			//do zadnjeg retka u datoteci ...
			while( (line = input.readLine()) != null ) {
				
				//povecavanje brojaca trenutne linije
				currentLine++;
				
				//odbaci prazne znakove na početku i kraju retka
				line = line.trim();
				
				//preskoci prazne retke
				if( line.length() == 0 ) 
					continue;
				
				//presko�i retke ako počinju sa znakom # (komentari)
				if( line.startsWith("#") )
					continue;
				
				model.Racunalo racunalo = null;
				
				//predaj stvoreni string tvornici objekata Kartica
				racunalo = model.factory.Racunalo.fromText(line);
			
				//dodaj novostvoreni objekt u listu objekata (ako nije null)
				if( racunalo != null )
					listaRacunala.add(racunalo);
			}
		} catch(Exception e) {
			System.out.println("Greska u retku " + currentLine);
			return null;
		}
		//vrati novostvorenu listu kartica
		return listaRacunala;
	}
	
	public static void toXML(model.Podaci racunala, Writer output) throws IOException {
		
		if( racunala == null ) return;
		
		output.write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\r\n");
		output.write("<!DOCTYPE podaci SYSTEM \"gramatika.dtd\">\r\n");		
		output.write("<podaci>\r\n");
		Iterator<Racunalo> it = racunala.racunala();
		while(it.hasNext())
			model.factory.Racunalo.toXML(it.next(), output); 
		output.write("</podaci>\r\n");
		output.flush();
	}
}
