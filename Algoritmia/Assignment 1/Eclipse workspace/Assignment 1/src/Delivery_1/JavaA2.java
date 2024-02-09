package Delivery_1;

public class JavaA2 extends Java_basis {
	
	public static void main(String[] args) {
		try {
			(new JavaA2()).prime();
		}catch (Exception e) {
			
		}
	}
	
	
	public boolean isPrime(int n) {
		for (int i = 2; i < n; i++) {
			if (n%i == 0) return false;
		}
		return true;
	}

	
}
