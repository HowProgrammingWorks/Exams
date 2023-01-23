import java.util.Random;
public class RandomElementFromArray {
    public static void main(String[] args) {
        Random random = new Random();
        int[] array = new int[6];
        for (int i = 0; i <= 5; i++) {
            array[i] = random.nextInt(6);
        }
        int randomElement = (int) Math.floor(Math.random() * array.length);
        System.out.println(array[randomElement]);
    }
}
