package Tasks.MySolution;

import java.util.Arrays;

public class Shuffle {
    public static void main(String[] args) {
        Object[] array = { "a", "b", "c", "d", "e" };
        Object[] newArray = shuffleProcess(array);

        String arrayString = Arrays.toString(newArray);
        System.out.println(arrayString);
    }

    public static Object[] shuffleProcess(Object[] arr) {
        Object[] array = arr.clone();
        for (int i = 0; i < array.length; i++) {
            int firstIndex = (int) (Math.random() * array.length);
            int secondIndex = (int) (Math.random() * array.length);
            Object tmp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = tmp;
        }
        return array;
    }
}
