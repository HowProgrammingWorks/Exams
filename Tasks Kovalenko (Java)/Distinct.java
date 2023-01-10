// Step 0
// Translate 'distinct.js' to Java

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Distinct {
    public static Object[] distinct(Object[] data){
        System.out.println(Arrays.toString(data));
        List<Object> A = new ArrayList<>();
        int w = 0;
        for(Object a : data){
            if (A.contains(a)) {
                data[w] = null;
            } else {
                A.add(a);
            }
            w++;
        }
        return A.stream().filter(x -> Number.class.isAssignableFrom(x.getClass())).toArray(Object[]::new);
    }
}