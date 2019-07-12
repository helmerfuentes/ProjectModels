using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generar : MonoBehaviour
{
    
    public GameObject [] coches;
    public Component componente;
    private bool enablecoches=true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Throwcoches());

   

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    IEnumerator Throwcoches()
    {
        yield return new WaitForSeconds(2.0f);
        while (enablecoches)
        {
            
            hoMove ruta = new hoMove();
            

            GameObject coch = (GameObject) Instantiate(coches[Random.Range(0,coches.Length)], new Vector3 (235, 0.03616625f, 11.46f), Quaternion.identity);
            //coch.AddComponent<hoMove>();    
            //coch.GetComponent<hoMove>().speed = Random.Range(5,10);
            //coch.GetComponent<hoMove>().pathContainer = (PathManager)GameObject.Find("cariilDR");
            yield return new WaitForSeconds(5.0f);

            
        }

    }
}
