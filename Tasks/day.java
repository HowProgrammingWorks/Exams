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
        String[] D = {"Sun", "Mon", "Tue", "Wed", " Thu", "Fri", "Sat"};
        int i;
        for (i = 0; i < D.length; i++) {
            if (s.startsWith(D[i].toLowerCase())) {
                return i + 1;
            }
        }
        return -1;
    }
} 
