// Step 2
// Removed stream().filter(...)
// Renamed fields
// Reformatted code

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Distinct {
    public static List<Object> distinct(Object[] input) {
        System.out.println(Arrays.toString(input));
        List<Object> output = new ArrayList<>();
        for (Object element : input) {
            if (!output.contains(element)) output.add(element);
        }
        return output;
    }
}