package model.factory;
import java.io.IOException;
import java.io.Writer;
import java.util.StringTokenizer;

public class Procesor {

	public static model.Procesor fromText(String input)  {
		
		model.Procesor procesor = new model.Procesor();
		
		StringTokenizer tok = new StringTokenizer(input, ",");
		
		String naziv=tok.nextToken().trim();
		procesor.setNaziv(naziv);
		String frekvencija=tok.nextToken().trim();
		procesor.setFrekvencija(frekvencija);

		return procesor;
		}
	
	public static void toXML(model.Procesor procesor, Writer output) throws IOException {
		
		output.write("        <naziv_procesora>" + procesor.getNaziv() + "</naziv_procesora>\r\n");
		output.write("        <frekvencija_procesora>" + procesor.getFrekvencija()+"</frekvencija_procesora>\r\n");
		
	}
		


	}