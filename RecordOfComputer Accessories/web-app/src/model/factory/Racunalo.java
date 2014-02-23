package model.factory;

import java.io.IOException;
import java.io.Writer;
import java.util.Iterator;
import java.util.StringTokenizer;

public class Racunalo {

	public static model.Racunalo fromText(String input) {
		
		model.Racunalo racunalo = new model.Racunalo();
		
		//tokenizacija stringa
		StringTokenizer st = new StringTokenizer(input, "|");
		
		//id racunala
		racunalo.setId(st.nextToken().trim()); //Počinje od nultog
		
		//broj procesora
		int br=Integer.parseInt(st.nextToken().trim());
		racunalo.setBroj_procesora(br);
		
		//broj usb ulaza
		br=Integer.parseInt(st.nextToken().trim());
		racunalo.setBroj_usb_ulaza(br);
		
		//namjena
		racunalo.setNamjena(st.nextToken().trim());
		
		//inventarski broj
		br=Integer.parseInt(st.nextToken().trim());
		racunalo.setInv_broj(br);
		
		//lokacija
		racunalo.setLokacija(st.nextToken().trim());
		
		//glavni operacijski sustav
		racunalo.setGlavni_os(st.nextToken().trim());
		
		//naziv računala		
		racunalo.setNaziv(st.nextToken().trim());
		
		//proizvođač
		racunalo.setProizvodac(st.nextToken().trim());
		//procesor
		
		String procesorPodaci=st.nextToken().trim(); 
		model.Procesor proc = model.factory.Procesor.fromText(procesorPodaci);
		racunalo.setProcesor(proc);
		
		//lista tvrdih diskova (brojnost je n)
		
		String listaTvrdiDiskovi=st.nextToken().trim();		
		StringTokenizer st2 = new StringTokenizer(listaTvrdiDiskovi,";");		
		while(st2.hasMoreElements() == true) {
			
			String disk = (String) st2.nextElement();
			model.TvrdiDisk tDisk = model.factory.TvrdiDisk.fromText(disk);
			if(tDisk != null)
				racunalo.addTvrdiDisk(tDisk);
		}
		//kolicina RAM-a
		racunalo.setKolicina_rama(st.nextToken().trim());
		//datum kupnje
		racunalo.setDatum_kupnje(st.nextToken().trim());
		//grafička kartica
		racunalo.setGraficka_kartica(st.nextToken().trim());		
		return racunalo;
	}
	
	public static void toXML(model.Racunalo racunalo, Writer output) throws IOException {
		
		
		output.write("<racunalo id=\"" + racunalo.getId() + "\" broj_procesora=\""+ racunalo.getBroj_procesora()+"\" broj_usb_ulaza=\""+racunalo.getBroj_usb_ulaza()+"\" namjena_racunala=\""+racunalo.getNamjena()+"\" inv_broj=\"" + racunalo.getInv_broj()+"\" lokacija= \""+racunalo.getLokacija()+"\" glavni_os=\""+racunalo.getGlavni_os()+"\">\r\n");
		output.write("     <naziv>"+racunalo.getNaziv()+"</naziv>\r\n");
		output.write("     <proizvodac>"+racunalo.getProizvodac()+"</proizvodac>\r\n");
		output.write("     <procesor>\r\n");
		model.factory.Procesor.toXML(racunalo.getProcesor(), output);
		output.write("     </procesor>\r\n");
		output.write("     <tvrdi_disk>\r\n");		
		Iterator<model.TvrdiDisk> diskovi = racunalo.tvrdiDiskovi();
		while(diskovi.hasNext())
			model.factory.TvrdiDisk.toXML(diskovi.next(), output);
		output.write("    </tvrdi_disk>\r\n");
		output.write("     <kolicina_rama>"+racunalo.getKolicina_rama()+"</kolicina_rama>\r\n");
		output.write("     <datum_kupnje>"+racunalo.getDatum_kupnje()+"</datum_kupnje>\r\n");
		output.write("     <graficka_kartica>"+racunalo.getGraficka_kartica()+"</graficka_kartica>\r\n");
		output.write("</racunalo>\r\n");
		
		

	}
}
