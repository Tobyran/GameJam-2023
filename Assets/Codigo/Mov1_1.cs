using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov1_1 : MonoBehaviour
{
    public int TamaņoPlataforma = 3;
    
    public Vector3 limiteCrea;
 
    
    
    public GameObject PrefabMapa;
  

    // Start is called before the first frame update
    void Start()
    {
  
        

    }

    // Update is called once per frame
    void Update()
    {
        if (limiteCrea.x != TamaņoPlataforma && limiteCrea.y != TamaņoPlataforma)
        {
            for (int i = 0; i < TamaņoPlataforma; i++)
            {
                limiteCrea = new Vector3(i, 0, 0);
                if (i >= TamaņoPlataforma)
                {
                    for (int a = 0; a < TamaņoPlataforma; a++)
                    {
                        limiteCrea = new Vector3(0, 0, a);
                        Instantiate<GameObject>(PrefabMapa, limiteCrea, PrefabMapa.transform.rotation);
                    }
                }
                else
                {
                    Instantiate<GameObject>(PrefabMapa, limiteCrea, PrefabMapa.transform.rotation);
                }


            }
        }

        if (Input.GetKeyDown("r"))
        {

        }
    }
}
