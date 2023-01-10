// Step 0
// Translate 'ip.js' to Java

public class Ip {
    public static Object[] parseIP (String i){
        Object[] a = new Object[i.split("[.]").length];
        if (i == "") return null;
        else {
            String[] B = i.split("[.]");
            if (B.length != 4) return null;
            int j = 0;
            for(String b : B){
                a[j] = Integer.parseInt(b);
                if (!Number.class.isAssignableFrom(a[j].getClass())) return null;
                j++;
            }
        }
        return a;
    }
}
