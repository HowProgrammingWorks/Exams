import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;
public class CreateThePassword {
    public static void main(String[] args) {
        System.out.println("Please, enter password length");
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        final String alphabet = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        System.out.println("Here's your password:");
        for (int i = 0; i < n; i++) {
            System.out.print(alphabet.charAt(ThreadLocalRandom.current().nextInt(0, alphabet.length())));
        }
    }
}
