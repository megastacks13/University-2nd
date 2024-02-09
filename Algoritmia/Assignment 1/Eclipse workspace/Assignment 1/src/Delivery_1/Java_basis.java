package Delivery_1;
import java.util.ArrayList;
import java.util.List;

public abstract class Java_basis {
	
	public void prime() {
		int n = 10000;
		for (int i = 0; i < 7; i++) {
			long t1 = System.currentTimeMillis();
			primesList(n);
			long t2 = System.currentTimeMillis();
			System.out.println("n = " + n + " *** time = " + (int)(t2-t1) + " milliseconds");
			n*=2;
		}
	}
	
	public Object[] primesList(int n) {
		List<Integer> primes = new ArrayList<Integer>();
		
		for (int i = 2; i<n+1; i++) {
			if (isPrime(i)) primes.add(i);
		}
		return primes.toArray();
	}
	
	public abstract boolean isPrime(int n);
}
