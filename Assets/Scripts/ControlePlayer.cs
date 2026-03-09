using UnityEngine;

public class ControlePlayer : MonoBehaviour
{
    Animator anim;
    Rigidbody rb;
    public static GameObject player;
    public static bool isDead = false;
    public static GameObject plataformaAtual;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = this.GetComponent<Animator>();
        player = this.gameObject;
        rb = this.GetComponent<Rigidbody>();
        
        plataformaAtual = null;
    }

    void StopJumping()
    {
        anim.SetBool("isJumping", false);
    }

    void StopMagic()
    {
        anim.SetBool("isMagic", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
            rb.AddForce(Vector3.up * 400);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            anim.SetBool("isMagic", true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) // Roda o Caractere para direita
        {
            this.transform.Rotate(Vector3.up * 90);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) // Roda o Caractere para esquerda
        {
            this.transform.Rotate(Vector3.up * -90);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-0.1f, 0, 0); // Passo para esquerda
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(0.1f, 0, 0); // Passo para direita
        }
    }

    void OnCollisionEnter(Collision outro)
    {
        if (outro.gameObject.tag == "platform" || 
            outro.gameObject.tag == "stairsUp" || 
            outro.gameObject.tag == "stairsDown" || 
            outro.gameObject.tag == "platformZ" || 
            outro.gameObject.tag == "platformZThin" || 
            outro.gameObject.tag == "platformZSplit" ||
            outro.gameObject.tag == "platformTSection")
        {
            plataformaAtual = outro.gameObject;
        }

        if (outro.gameObject.tag == "Fogo")
        {
            anim.SetTrigger("isDead");
            isDead = true;
        }
    }
}
