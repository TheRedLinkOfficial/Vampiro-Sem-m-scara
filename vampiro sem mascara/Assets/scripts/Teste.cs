using UnityEngine;

public class Teste : MonoBehaviour
{
   new Personagem Jonathan;
   new vampiro DIO;

   string compareVida(){
    if (Jonathan.life() > DIO.life()){
        return Jonathan.name();
        Debug.Log("Jonathan possui mais vida");
    }
    else if (DIO.life() > Jonathan.life()){
        return DIO.name();
         Debug.Log("DIO possui mais vida");
    }
    else{return "Ambos são iguais";
     Debug.Log("Ambos possuem a mesma vida");}
     Debug.Log(compareVida());
    
   }
}
