using UnityEngine;

public class ControleAstro : MonoBehaviour
{

    void StopJumping()
    {
        anim.SetBool("isJumping", false);
    }

    void StopMagic()
    {
        anim.SetBool("isMagic", false);
    }

    Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
        } else if (Input.GetKeyDown(KeyCode.M))
        {
            anim.SetBool("isMagic", true);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up * 90);
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up * -90);
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-0.2f, 0, 0);
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(0.2f, 0, 0);
        }
    }
}
