using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public astro_hareket BirdScript;
    public float fark;   
    public GameObject Borular;
    public float yEkseni;
    public float time;
    public float xEkseni,xEkseni2;
    public static Renderer sr2;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
        sr2 = GetComponent<Renderer>();
    }
   
   
    public IEnumerator SpawnObject(float time)
    {
        while(!BirdScript.isDead){

            Instantiate(Borular, new Vector3(Random.Range(xEkseni,xEkseni2), Random.Range(-yEkseni, yEkseni), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
            xEkseni +=fark;
            xEkseni2 +=fark;
            
        }
    }
}

