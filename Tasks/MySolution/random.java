package Tasks.MySolution;

public class random {
    public static void main(String[] args) {
        int result = randomProcess(1, 9);
        System.out.println(result);
    }

    public static int randomProcess(int min, int max) {
        int preResult = (int)(Math.floor(Math.random() * (max - min + 1)));
        return 0;
    }

    public static int randomProcess(int max) {
        return 0;
    }
}
