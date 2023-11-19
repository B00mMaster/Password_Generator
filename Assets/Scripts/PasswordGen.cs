using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class PasswordGen : MonoBehaviour
{
   public List<char> symbols = new List<char> { '!','@','#','$','%','&'};
  
    System.Random random = new System.Random();
    
    private void Start()
    {
        PasswordGenerator();
    }

    public void PasswordGenerator()
    {
        int minLenght = 12;
        int minNum = 3;
        int minSymbol = 2;
        int minMayus = 1;

        StringBuilder password = new StringBuilder();

        
        for (int i = 0; i < minMayus; i++)
        {
            password.Append(GetRandomMayus());
        }

        for (int i = 0; i < minNum; i++)
        {
            password.Append(GetRandomNum());
        }

        for(int i=0; i < minSymbol; i++)
        {
            password.Append(GetRandomSymbol());
        }

        while (password.Length <= minLenght)
        {
            password.Append(GetRandomChar());
        }

        Debug.Log("Contraseña generada:" +password.ToString());
    
    }
    char GetRandomLetter()
    {
        return (char)random.Next('a', 'z');
    }
    char GetRandomMayus()
    {
        return (char)random.Next('A', 'Z');
    }
    char GetRandomNum()
    {
        return (char)random.Next('0', '9');
    }
    char GetRandomSymbol()
    {
        return symbols[random.Next(symbols.Count)];
    }
    char GetRandomChar()
    {
        int opcion = random.Next(0, 4);
        char result='.';
        switch(opcion)
        {
            case 0:
                result= GetRandomLetter();
                break;
            case 1:
                result= GetRandomNum();
                break;
            case 2:
                result= GetRandomSymbol();
                break;
            case 3:
                result = GetRandomMayus();
                break;
            

           
        }
        return result;

    }
}
