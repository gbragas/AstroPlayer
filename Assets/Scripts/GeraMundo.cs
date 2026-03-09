using UnityEngine;

public class GeraMundo : MonoBehaviour
{


    public GameObject[] plataformas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject falsoPlayer = new GameObject("falso");
        for (int i = 0; i < 30; i++)
        {
            int numeroDePlataforma = Random.Range(0, plataformas.Length);
            if (plataformas[numeroDePlataforma].tag == "platformZ" || 
                        plataformas[numeroDePlataforma].tag == "platformZThin" || 
                        plataformas[numeroDePlataforma].tag == "platformZSplit")
            {
                int repete = Random.Range(0, 4);

                for (int j = 0; j < repete; j++)
                {
                    GameObject p2 = Instantiate(plataformas[numeroDePlataforma], 
                            falsoPlayer.transform.position, 
                            falsoPlayer.transform.rotation);
                    falsoPlayer.transform.Translate(Vector3.forward * -10);
                }
            }

            // if (i == 0 && (plataformas[numeroDePlataforma].tag == "stairsDown" || plataformas[numeroDePlataforma].tag == "stairsUp"))
            // {
            //     falsoPlayer.transform.Translate(Vector3.forward * -10);
            // }

            GameObject p = Instantiate(plataformas[numeroDePlataforma], falsoPlayer.transform.position, falsoPlayer.transform.rotation);

            if (plataformas[numeroDePlataforma].tag == "stairsUp")
            {
                falsoPlayer.transform.Translate(0, 5, 0);
            }
            else if (plataformas[numeroDePlataforma].tag == "stairsDown")
            {

                falsoPlayer.transform.Translate(0, -5, 0);
                p.transform.Rotate(new Vector3(0, 180, 0));
                p.transform.position = falsoPlayer.transform.position;
            }
            else if (plataformas[numeroDePlataforma].tag == "platformTSection")
            {
                if (Random.Range(0, 2) == 0)
                {
                    falsoPlayer.transform.Rotate(new Vector3(0, 90, 0));
                }
                else
                {
                    falsoPlayer.transform.Rotate(new Vector3(0, -90, 0));
                }
                falsoPlayer.transform.Translate(Vector3.forward * -10);
            }

            falsoPlayer.transform.Translate(Vector3.forward * -10);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
