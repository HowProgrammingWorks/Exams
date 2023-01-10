// Step 1
// Refactored code
// Renamed variables
// Accepted parameter IP is now constant
// Separated IP is now written into an ArrayList instead of Array
// Changed numeric filtration (it now uses a numeric regex)

import java.util.*;

public class Ip {

    public static Object[] parseIP (final String IP){
        String[] splittedIP = IP.split("[.]");
        List<Object> result = new ArrayList<>();
        if (splittedIP.length==4) {
            for (String element : splittedIP) {
                if (element.matches("-?\\d+?"))
                    result.add(Integer.parseInt(element));
            }
        }
        if (result.size()==4) return result.toArray();
        else return null;
    }
}