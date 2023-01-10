// Step 2
// NUMERIC_REGEX is now meant as constant

import java.util.*;

public class Ip {

    public static Object[] parseIP (final String IP){
        final String NUMERIC_REGEX = "-?\\d+?";
        String[] splittedIP = IP.split("[.]");
        List<Object> result = new ArrayList<>();
        if (splittedIP.length==4) {
            for (String element : splittedIP) {
                if (element.matches(NUMERIC_REGEX))
                    result.add(Integer.parseInt(element));
            }
        }
        if (result.size()==4) return result.toArray();
        else return null;
    }
}