import java.util.Scanner;

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
    //upgraded tests v2
    System.out.print("Enter day: ");
    Scanner scanner = new Scanner(System.in);
    String user_day = scanner.nextLine();
    System.out.println(parseDay(user_day));
  }
} 

