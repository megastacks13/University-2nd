public class JavaA1 extends Java_basis {
	
	public static void main(String[] args) {
		try {
			(new JavaA1()).prime();
		}catch (Exception e) {
			
		}
	}
	
	public boolean isPrime(int n) {
		boolean p = true;
		for (int i = 2; i < n; i++) {
			if (n%i == 0) p = false;
		}
		return p;
	}
	
	
	
}
