// Get day number
package parseDay;


import java.util.Scanner;

public class parseDay {
    public static void main(String[] args) {
        System.out.println("day?");
        Scanner scanner = new Scanner(System.in);
        String Days = scanner.next();
        System.out.println(parseDay(Days));
    }

    public static int parseDay(String s) {
        String[] D = {"sunday", "monday", "tuesday", "wednesday", " thursday", "friday", "saturday"};
        int i;
        for (i = 0; i < D.length; i++) {
            if (s.equals(D[i])) {
                return i + 1;
            }
        }
        return -1;
    }
} 
