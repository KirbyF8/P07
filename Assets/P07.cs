
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class P07 : MonoBehaviour
{

    private int numero = 0;
    private int total;
    [SerializeField] private int numeroMax = 100;

    private int randomNumber;
    private int randomNumberSum;
    private bool randomNumber5;

    [SerializeField] private string insertString = "I like videogames";
    private string stringToA = "";

    private string[] lettersArray = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
    private int howMany;

    void Start()
    {
        
        // Exercise 1
        while (numero > numeroMax)
        {
            total += numero;
            numero += 2;
        }
        Debug.Log(total);

        //Exercise 2
        foreach (string str in lettersArray)
        {
            if ("aeiouAEIOU".IndexOf(str) >= 0)
            {
                howMany++;
            }
        }
        Debug.Log(howMany);


            //Exercise 3
            {
        for (int i = 10; i >= 1; i--)
        {
            Debug.Log($"{i} green bottles\r\n" +
                      $"Hanging on the wall\r\n" +
                      $"{i} green bottles\r\n" +
                      $"Hanging on the wall\r\n" +
                      $"And if one green bottle\r\n" +
                      $"Should accidentally fall\r\n" +
                      $"There’ll be {i - 1} green bottles\r\n" +
                      $"Hanging on the wall");
        }
    }
        //Exercise 4
        {
            randomNumber5 = false;
            while (!randomNumber5)
            {
                randomNumber = Random.Range(1, 11);

                if (randomNumber != 5)
                {
                    randomNumberSum += randomNumber;
                }
                else
                {
                    randomNumber5 = true;
                }



            }
            if (randomNumberSum >= 100)
            {
                Debug.Log("El número es mayor o igual que 100 y es:" + randomNumberSum);
            }
            else
            {
                Debug.Log("El número es menor que 100 y es:" + randomNumberSum);
            }
       
            // Siempre sera solo un 5 
        }

        
        //Exercise 5
        {
            for (int i = 0; i < insertString.Length; i++)
            {
                char currentChar = insertString[i];

               
                if (currentChar == 'a')
                {
                    Debug.Log(stringToA);
                    break; 
                }

                
                stringToA += currentChar;
            }
        }

    }

   
}
