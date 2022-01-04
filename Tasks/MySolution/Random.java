package Tasks.MySolution;

public class Random {
    public static void main(String[] args) {
        int result = randomProcess(1, 9);
        System.out.println(result);
    }

    public static int randomProcess(int min, int max) {
        int preResult = (int) (Math.floor(Math.random() * (max - min + 1)));
        return min + preResult;
    }

    public static int randomProcess(int max) {
        int preResult = (int) (Math.floor(Math.random() * (max + 1)));
        return preResult;
    }
}
