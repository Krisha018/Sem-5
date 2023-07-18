using System;  
public class longestWord
{  
    public static void Main() 
      {          
                    string line = "I am a Krisha Padaliya";
                    string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                        string word = "";
                        int ctr = 0;
                        foreach (String s in words)
                        {
                            if (s.Length > ctr)
                            {
                                word = s;
                                ctr = s.Length;
                            }
                        }
                   
                        Console.WriteLine(word);
                    
    }
}
