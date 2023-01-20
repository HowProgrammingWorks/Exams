import java.util.HashSet;
import java.util.Set;

public class distinct
{
    public static Set<Integer> dist(int[] data)
    {
        //create collection which deletes duplicates
        Set<Integer> s = new HashSet<Integer>();
        for(int i = 0; i < data.length; ++i)
        {
            s.add(data[i]);
        }
        return s;
    }
    public static void main(String[] args)
    {
        //tests
        System.out.println();
        int[] test1 = {1, 2, 1, 3, 1, 4};
        int[] test2 = {1, 2, -1, 3, 0, 4};
        int[] test3 = {1};
        int[] test4 = {1, 1, 1};
        int[] test5 = {0};
        int[] test6 = {0, 0};
        int[] test7 = {0, 0, 0};
        int[] test8 = {0, 0, 0, 0};
        int[] test9 = {};
        
        System.out.println(dist(test1));
        System.out.println(dist(test2));
        System.out.println(dist(test3));
        System.out.println(dist(test4));
        System.out.println(dist(test5));
        System.out.println(dist(test6));
        System.out.println(dist(test7));
        System.out.println(dist(test8));
        System.out.println(dist(test9));
    }
}
