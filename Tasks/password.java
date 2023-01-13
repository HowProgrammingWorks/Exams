// Generate random password

package Password;


public class Password {

    public static void main(String[] args) {
        String alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        int length = 7;
        System.out.println("Password: " + GeneratePassword(alphabet, length));
    }
    public static String GeneratePassword(String alphabet, int length) {
        int MAX = alphabet.length();
        String key= "";
        for (int i = 0; i < length; i++) {
            int Index = (int) (Math.random() * MAX);
            key += alphabet.charAt(Index);
        }
        return key;
    }
}
