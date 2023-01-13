// Step 5
// Updated regex

import java.util.ArrayList;
import java.util.List;

public class Ip {

    private static final String NUMERIC_REGEX = "^\\d+$"; // checks if String contains basic numbers only
    public static Object[] parseIP(final String ip) {
        String[] splittedIp = ip.split("[.]");
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