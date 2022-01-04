package Tasks.MySolution;

import java.util.Arrays;

public class shuffle {
    public static void main(String[] args) {
        Object[] array = { "a", "b", "c", "d", "e" };
        shuffleProcess(array);
        String arrayString = Arrays.toString(array);
        System.out.println(arrayString);
    }

    public static void shuffleProcess(Object[] array) {
        for (int i = 0; i < array.length; i++) {
            int firstIndex = (int) (Math.random() * array.length);
            int secondIndex = (int) (Math.random() * array.length);
            Object tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }
    }
}
