/**
 * 
 */
package mastermind;

import java.util.ArrayList;

/**
 * @author czuniga10
 *
 */
public class MastermindApp {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		Player player1 = new Player("Fred");
		
		ArrayList<Codes> codes = player1.pickCode();
		
	}

}
