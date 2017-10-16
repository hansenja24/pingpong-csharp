using System.Collections.Generic;
// using System;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    // private int _number;
    // private static List<PingPongGenerator> _instances = new List<PingPongGenerator> {};

    public PingPongGenerator ()
    {
      // _number = number;
      // for(int i = 1; i <= number; i++)
      // {
      //   _instances.Add(i);
      // }
    }

    public List<string> GetResult(int number)
    {
      List<string> result =  new List<string> {};

      for (int i = 1; i <= number; i++)
      {
        if (i % 15 == 0)
        {
          result.Add("Ping-Pong");
        }
        else if (i % 3 == 0)
        {
          result.Add("Ping");
        }
        else if (i % 5 == 0)
        {
          result.Add("Pong");
        }
        else
        {
        result.Add(i.ToString());
        }
      }
      return result;
    }
  }
}
