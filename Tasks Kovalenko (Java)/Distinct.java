// Step 1
// Refactor variables and fields
// Make distinct() return List<Object> instead of Object[]
// Remove variable w

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Distinct {
    public static List<Object> distinct(Object[] dataInput){
        System.out.println(Arrays.toString(dataInput));
        List<Object> dataOutput = new ArrayList<>();
        for(Object dataUnit : dataInput){
            if (!dataOutput.contains(dataUnit)) dataOutput.add(dataUnit);
        }
        return dataOutput.stream().filter(element -> Number.class.isAssignableFrom(element.getClass())).toList();
    }
}