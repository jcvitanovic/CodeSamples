package model.factory;

import java.io.IOException;
import java.io.Writer;
import java.util.StringTokenizer;



public class TvrdiDisk {


public static model.TvrdiDisk fromText(String input)  {
		
		model.TvrdiDisk disk = new model.TvrdiDisk();
		
		StringTokenizer tok = new StringTokenizer(input, ",");
		
		
		String naziv=tok.nextToken().trim();
		disk.setNaziv(naziv);
		
		String kapacitet=tok.nextToken().trim();
		disk.setKapacitet(kapacitet);
		
		return disk;
	}
	
	
	
	public static void toXML(model.TvrdiDisk disk, Writer output) throws IOException {
		output.write("        <hd_proizvodac>" + disk.getNaziv() + "</hd_proizvodac>\r\n");
		output.write("        <kapacitet>" + disk.getKapacitet()+"</kapacitet>\r\n");
		
	}
}
