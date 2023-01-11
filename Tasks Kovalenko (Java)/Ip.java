// Step 4
// 'else' statement removed
// Renamed fields
// Changed imports
// Reformatted code
// List 'result' now accepts only Integer values

import java.util.ArrayList;
import java.util.List;

public class Ip {

    public static Object[] parseIP(final String IP) {
        final String NUMERIC_REGEX = "^\\d+$"; // checks if String contains basic numbers only
        String[] splittedIp = IP.split("[.]");
        List<Integer> result = new ArrayList<>();
        if (splittedIp.length == 4) {
            for (String element : splittedIp) {
                if (element.matches(NUMERIC_REGEX))
                    result.add(Integer.parseInt(element));
            }
            if (result.size() == 4) return result.toArray();
        }
        return null;
    }
}