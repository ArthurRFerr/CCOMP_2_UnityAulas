using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidade = 5;
    public float tempo = 0;
    public float delay = 1000;
    // Start is called before the first frame update
    void Start()
    {
      
        float x = Random.Range(0, 0) == 0 ? -1 : 1;

        //mesma coisa que o de cima
        /* 
         float x1 = Random.Range(0, 0);
        if (x1==0)
        {
            x1 = -1;
        }
        else
        {
            x1 = 1;
        }
        */

        float y = Random.Range(0, 0) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x, velocidade*y); //vai pegar um componente de onde o script estiver
        Debug.Log(GetComponent<Rigidbody>().velocity);

    }

    // Update is called once per frame
    void Update()
    {
        /*tempo += Time.deltaTime;
        if (tempo >= delay)
        {
            velocidade+=100000;
            //GetComponent<Rigidbody>().velocity *= velocidade;
            Debug.Log("aqui");
        }*/
     }

    private void OnCollisionEnter(Collision batida)

    {
       
        if ((batida.gameObject.name == "BEsquerda") || (batida.gameObject.name == "BDireita"))
        {
            /* float velocidade = 0.1f;
             float x = Random.Range(0, 0) == 0 ? -1 : 1;
             float y = Random.Range(0, 0) == 0 ? -1 : 1;
             transform.position = new Vector3(0, 5, 0);
             GetComponent<Rigidbody>().velocity = new Vector2(velocidade*x, velocidade*y); 
            */
            transform.position = new Vector3(0, 5, 0);
            Debug.Log("aqui2");
            Start();
        }

    }
}
