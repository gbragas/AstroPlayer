using UnityEngine;

public class Scroll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void FixedUpdate()
    {

        if(ControlePlayer.isDead) return;
        this.transform.position += ControlePlayer.player.transform.forward * -0.1f;

        if(ControlePlayer.plataformaAtual == null) return;

        if (ControlePlayer.plataformaAtual.tag == "stairsUp")
            this.transform.Translate(0, -0.06f, 0);
        
        if (ControlePlayer.plataformaAtual.tag == "stairsDown")
            this.transform.Translate(0, 0.06f, 0);
        
        
    }
}
