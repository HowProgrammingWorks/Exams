public class day
{
  //create class
  public static int parseDay(String s)
  {
    //create daylist
    String D[] = {"sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday"};
    for(int i = 0; i < D.length; ++i)
    {
      //do check
      if(s==D[i])
      {
        return i + 1;
      }      
    }
    return -1;
  }
  public static void main(String[] args)
  {
    //do a test
    String word = "friday";
    System.out.println(parseDay(word));
  }
} 

