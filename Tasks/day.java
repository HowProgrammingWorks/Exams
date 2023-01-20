public class day
{
  //create class
  public static int parseDay(String s)
  {
    //create daylist
    String D[] = {"sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday"};
    for(int i = 0; i < D.length; ++i)
    {
      //upgrade check
      if(s.equals(D[i]))
      {
        return i + 1;
      }      
    }
    return -1;
  }
  public static void main(String[] args)
  {
    //tests from repo
    System.out.println(parseDay("friday"));
    System.out.println(parseDay("Friday"));
    System.out.println(parseDay("Fri"));
    System.out.println(parseDay("monday"));
    System.out.println(parseDay("abc"));
  }
} 

