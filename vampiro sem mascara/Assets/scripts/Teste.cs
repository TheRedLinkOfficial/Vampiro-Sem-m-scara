using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem Jonathan = new Personagem();
    vampiro DIO =  new vampiro();

   
   


    void Start(){ 
        
        Jonathan.setVida(45);
        Jonathan.setnome("JoJo");
        Jonathan.seteyes("castanhos");
        Jonathan.setweapon(true);
        
        DIO.setVida(90);
        DIO.setnome("DIO");
        DIO.setweapon(false);
        DIO.seteyes("castanhos");
        DIO.setblood(10);
        DIO.setClan("LaSombra");

        string compareVida = "";
        
        
        if (Jonathan.life() > DIO.life())
        {
           Jonathan.name();
        Debug.Log("Jonathan possui mais vida");
        }
        
        else if (DIO.life() > Jonathan.life())
        {
           compareVida = DIO.name();
         Debug.Log("DIO possui mais vida");
        }
        else
        {
           compareVida = "Ambos são iguais";
        }

        Debug.Log(compareVida);
    
   }
   
}
