package model;

public class Procesor {
	
	private String naziv;
	private String frekvencija;
	
	public Procesor(){
		naziv="";
		frekvencija="";
	}
	
	public String getNaziv() {
		return naziv;
	}
	public void setNaziv(String naziv) {
		this.naziv = naziv;
	}
	public String getFrekvencija() {
		return frekvencija;
	}
	public void setFrekvencija(String frekvencija) {
		this.frekvencija = frekvencija;
	}
	

}
