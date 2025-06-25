using UnityEngine;

public class vampiro : Personagem
{
 public int sangue;
public string clã;
public int constante;
 public void setblood(int sangue){this.sangue = sangue;}
 public void setClan (string clã){this.clã = clã;}
public int blood(){return this.sangue;}
public string clan(){return this.clã;}


public void mordida (Personagem heroi){
    heroi.setVida (heroi.life() - 5);
    setblood (blood() + 5);
}

public void transformar (){
    if (clã == "LaSombra"){
        setClan ("Ventrue");
    }
    else if (clã == "Ventrue"){
        setClan ("LaSombra");
    }
    
}

 void OnTriggerEnter(Collider other){
    if(other.gameObject.tag == "humano"){
        Personagem personagem = other.gameObject.GetComponent<Personagem>();
        mordida(personagem);
        Debug.Log($"O personagem possui Pontos de vida: " + personagem.life ());
        Debug.Log($"O vampiro agora possui pontos de sangue:  " + blood ());
        
    }

    if (blood() > constante)
    {
        transformar();
        Debug.Log($"O vampiro irá se transformar em um " + clan());
        
    }
    
 }
    
}
