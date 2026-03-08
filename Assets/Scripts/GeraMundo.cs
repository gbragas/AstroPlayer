using UnityEngine;

public class GeraMundo : MonoBehaviour
{


    public GameObject[] plataformas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 pos = new Vector3(0, 0, 0);
        for (int i = 0; i < 10; i++)
        {
            int numeroDePlataforma = Random.Range(0, plataformas.Length);
            
            GameObject p = Instantiate(plataformas[numeroDePlataforma], pos, Quaternion.identity);

            if(plataformas[numeroDePlataforma].tag == "stairsUp")
            {
                pos.y += 5;
            }
            else if(plataformas[numeroDePlataforma].tag == "stairsDown")
            {
                pos.y -= 5;
                p.transform.Rotate(new Vector3(0, 180, 0));
                p.transform.position = pos;
            }
  
            pos.z -= 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
