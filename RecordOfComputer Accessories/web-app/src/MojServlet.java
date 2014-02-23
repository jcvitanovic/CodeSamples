import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


public class MojServlet extends HttpServlet {
	

	/**
	 * 
	 */
	private static final long serialVersionUID = 4702218928876027509L; //jer je kompajler tražio to :) 


	private String ulDat;

	@Override
	public void init() throws ServletException {
		super.init();
		ulDat = getServletConfig().getInitParameter("InputFile"); //dohvaćanje ulaznog parametra - ime datoteke
		//iz konfiguracije web.xml
	}

	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse resp) throws ServletException,
			IOException {


		BufferedReader reader = null;


		reader = new BufferedReader(new InputStreamReader(getServletConfig().getServletContext()
				.getResourceAsStream("/WEB-INF/" + ulDat))); //path do ulazne datoteke

		resp.setContentType("text/xml; charset=UTF-8");

		model.Podaci podaci = null;
		try {
			podaci = model.factory.Podaci.fromText(reader);
		} catch (Exception e) {
			System.out.println(e);
		}

		// deklaracija objekta koji piše podatke
		PrintWriter out = null;

		// pokušaj otvaranja datotke za pisanje
		try {
			out = resp.getWriter();
		} catch (IOException e) {
			System.out.println("Izlazna datoteka ne moze biti stvorena!\n" + e);
		}

		// serijalizacija podatkovne strukture u datoteku
		try {
			model.factory.Podaci.toXML(podaci, out);
		} catch (IOException e) {
			System.out.println("Greška u stvaranju XML dokumenta\n" + e);
		}

		System.out.println("Konverzija dovršena!");
		try {
			out.close();
		} catch (Exception ignorable) {
			System.out.println("Greska!");
		}
		try {
			reader.close();
		} catch (Exception ignorable) {
			System.out.println("Greska!");
		}
	}

}

