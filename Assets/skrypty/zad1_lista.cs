using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        List<int> dane = new List<int> { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 2, 2, 1, 3 };
        List<int> jedynki = new List<int> {};
        List<int> dwojki = new List<int> { };
        List<int> trojki = new List<int> { };




        foreach(int i in dane)
        {

            if (i == 1)
            {

                jedynki.Add(i);
            
            }else if(i == 2)
            {

                dwojki.Add(i);

            }else if(i == 3)
            {

                trojki.Add(i);

            }


            

        }


        dane.Clear();

        Debug.Log(dane.Count);
        Debug.Log(jedynki.Count);
        Debug.Log(dwojki.Count);
        Debug.Log(trojki.Count);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
