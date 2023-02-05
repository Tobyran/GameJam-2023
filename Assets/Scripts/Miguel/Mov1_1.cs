using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mov1_1 : MonoBehaviour
{

    public GameObject[] PuntoInstlvl1;
    public GameObject[] PuntoInstlvl2;
    public GameObject[] PuntoInstlvl3;

    public GameObject[] Level2AlL;

    public GameObject[] Level3All;


    [Header("Encender Lvl")]
    public bool activarlvl1 = false;
    public bool activarlvl2 = false;
    public bool activarlvl3 = false;

    public GameObject PrefabMapa;


    public float TimeAnimEspera;

    public int RandomMap1;
    public int RandomMap2;
    public int RandomMap3;

    public float tiempoSpamLvl1;
    public float tiempoSpamLvl2;
    public float tiempoSpamLvl3;

    public int cantidadPantalla1;
    public int cantidadPantalla2;
    public int cantidadPantalla3;

    public bool evento;

    [Header("Apartado de Da�o")]

    public GameObject MaloPrefOn;
    public GameObject MalooPrefOff;


    public GameObject Puas;
    public float TiempoEspamPuas;

    public GameObject Raices;
    public float TiempoEspamRaices;

    public GameObject preBarril;
    public GameObject Barril;
    public GameObject partiBarril;
    public float TiempoEspamBarril;


    [Header("Bueno")]

    public GameObject BuenoPrefOn;
    public GameObject BuenoPrefOff;



    // Start is called before the first frame update
    void Start()
    {

        RandomMap2 = Random.RandomRange(0, Level2AlL.Length);
        RandomMap3 = Random.RandomRange(0, Level3All.Length);

        StartCoroutine(RandomLvl1());


    }

    // Update is called once per frame
    void Update()
    {
        if (activarlvl1)
        {
            SumarLvl1();
            activarlvl1 = false;
        }
        if (activarlvl2)
        {
            SumarLvl2();
            activarlvl2 = false;
        }
        if (activarlvl3)
        {
            SumarLvl3();
            activarlvl3 = false;
        }
    }

    IEnumerator generarlvl1()
    {
        yield return new WaitForSeconds(TimeAnimEspera);
        for (int i = 0; i < PuntoInstlvl1.Length; i++)
        {

            Instantiate(PrefabMapa, PuntoInstlvl1[i].transform.position, PuntoInstlvl1[i].transform.rotation);
            yield return new WaitForSeconds(TimeAnimEspera);
        }
    }
    IEnumerator generarlvl2()
    {
        yield return new WaitForSeconds(TimeAnimEspera);
        for (int i = 0; i < PuntoInstlvl2.Length; i++)
        {

            Instantiate(PrefabMapa, PuntoInstlvl2[i].transform.position, PuntoInstlvl2[i].transform.rotation);
            yield return new WaitForSeconds(TimeAnimEspera);
        }
    }
    IEnumerator generarlvl3()
    {
        yield return new WaitForSeconds(TimeAnimEspera);
        for (int i = 0; i < PuntoInstlvl3.Length; i++)
        {

            Instantiate(PrefabMapa, PuntoInstlvl3[i].transform.position, PuntoInstlvl3[i].transform.rotation);
            yield return new WaitForSeconds(TimeAnimEspera);
        }
    }

    private void SumarLvl1()
    {

        StartCoroutine(generarlvl1());
    }
    private void SumarLvl2()
    {

        StartCoroutine(generarlvl2());
    }
    private void SumarLvl3()
    {

        StartCoroutine(generarlvl3());
    }


    public void PrimerNivel()
    {



    }

    IEnumerator RandomLvl1()
    {
        print("entro random pinchos");
        yield return new WaitForSeconds(tiempoSpamLvl1);
        for (int i = 0; i < cantidadPantalla1; i++)
        {



            RandomMap1 = Random.RandomRange(0, PuntoInstlvl1.Length);

            Instantiate(Puas, PuntoInstlvl1[RandomMap1].transform.position, PuntoInstlvl1[RandomMap1].transform.rotation);
        

        }
        yield return new WaitForSeconds(tiempoSpamLvl1);
        if (!evento)
        {
            StartCoroutine(RandomLvl1());
        }
        else if (evento)
        {

        }

    }


    IEnumerable Desactivar(GameObject[] Obj, int NUM) 
    {
        yield return new WaitForSeconds(1);

        Obj[NUM].SetActive(false);
        
    }
    /*------------------------------Apartado da�o--------------------------------

    IEnumerator ActPuas()
    {
        Instantiate(prePuas, transform.position, transform.rotation);
        yield return new WaitForSeconds(TiempoEspamPuas);
        Instantiate(partiPuas, transform.position, transform.rotation);
        Instantiate(Puas, transform.position, transform.rotation);

    }
    IEnumerator ActRaices()
    {
        Instantiate(preRaices, transform.position, transform.rotation);
        yield return new WaitForSeconds(TiempoEspamRaices);
        Instantiate(partiRaiz, transform.position, transform.rotation);
        Instantiate(Raices, transform.position, transform.rotation);

    }
    IEnumerator ActBarril()
    {
        Instantiate(preBarril, transform.position, transform.rotation);
        yield return new WaitForSeconds(TiempoEspamBarril);
        Instantiate(partiBarril, transform.position, transform.rotation);
        Instantiate(Barril, transform.position, transform.rotation);
    }
    */
}

