
public class JavaA3 extends Java_basis {
	
	public static void main(String[] args) {
		try {
			(new JavaA3()).prime();
		}catch (Exception e) {
			
		}
	}
	
	
	public boolean isPrime(int n) {
		for (int i = 2; i < Math.floorDiv(n, 2) + 1; i++) {
			if (n%i == 0) return false;
		}
		return true;
	}
	
}
