package model;

import java.util.Iterator;
import java.util.Vector;

public class Racunalo {
	
	private String id="";
	private int broj_procesora;
	private int broj_usb_ulaza;
	private String namjena;
	private int inv_broj;
	private String lokacija;
	private String glavni_os;
	private String naziv;
	private String proizvodac;
	private String kolicina_rama;
	private String datum_kupnje;
	private String graficka_kartica;
	private Vector<TvrdiDisk> tvrdiDiskovi=new Vector<TvrdiDisk>();
	private Procesor procesor=  new Procesor();
	
	public int getBroj_procesora() {
		return broj_procesora;
	}

	public void setBroj_procesora(int broj_procesora) {
		this.broj_procesora = broj_procesora;
	}

	public int getBroj_usb_ulaza() {
		return broj_usb_ulaza;
	}

	public void setBroj_usb_ulaza(int broj_usb_ulaza) {
		this.broj_usb_ulaza = broj_usb_ulaza;
	}

	public String getNamjena() {
		return namjena;
	}

	public void setNamjena(String namjena) {
		this.namjena = namjena;
	}

	public int getInv_broj() {
		return inv_broj;
	}

	public void setInv_broj(int inv_broj) {
		this.inv_broj = inv_broj;
	}

	public String getLokacija() {
		return lokacija;
	}

	public void setLokacija(String lokacija) {
		this.lokacija = lokacija;
	}

	public String getGlavni_os() {
		return glavni_os;
	}

	public void setGlavni_os(String glavni_os) {
		this.glavni_os = glavni_os;
	}

	public String getNaziv() {
		return naziv;
	}

	public void setNaziv(String naziv) {
		this.naziv = naziv;
	}

	public String getProizvodac() {
		return proizvodac;
	}

	public void setProizvodac(String proizvodac) {
		this.proizvodac = proizvodac;
	}

	public String getKolicina_rama() {
		return kolicina_rama;
	}

	public void setKolicina_rama(String kolicina_rama) {
		this.kolicina_rama = kolicina_rama;
	}

	public String getDatum_kupnje() {
		return datum_kupnje;
	}

	public void setDatum_kupnje(String datum_kupnje) {
		this.datum_kupnje = datum_kupnje;
	}

	public String getGraficka_kartica() {
		return graficka_kartica;
	}

	public void setGraficka_kartica(String graficka_kartica) {
		this.graficka_kartica = graficka_kartica;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public Vector<TvrdiDisk> getTvrdiDiskovi() {
		return tvrdiDiskovi;
	}

	public void setTvrdiDiskovi(Vector<TvrdiDisk> tvrdiDiskovi) {
		this.tvrdiDiskovi = tvrdiDiskovi;
	}

	public Procesor getProcesor() {
		return procesor;
	}

	public void setProcesor(Procesor procesor) {
		this.procesor = procesor;
	}


	public void addTvrdiDisk(TvrdiDisk tvrdiDisk){
		tvrdiDiskovi.add(tvrdiDisk);
	}
	
	public void removeTvrdiDisk(TvrdiDisk tvrdiDisk){
		tvrdiDiskovi.remove(tvrdiDisk);
	}
	
	public Iterator<TvrdiDisk> tvrdiDiskovi(){
		return tvrdiDiskovi.iterator();
	}



}
