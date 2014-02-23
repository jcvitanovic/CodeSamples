package model;

import java.util.Iterator;
import java.util.Vector;

public class Podaci {
	
	private Vector<Racunalo> racunala=new Vector<Racunalo>();
	
	public void add(Racunalo racunalo){
		racunala.add(racunalo);
	}
	
	public void remove(Racunalo racunalo){
		racunala.remove(racunalo);
	}
	public Iterator<Racunalo> racunala(){
		return racunala.iterator();
	}

}
