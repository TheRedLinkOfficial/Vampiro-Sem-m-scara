using UnityEngine;

public class vampiro : Personagem
{
 public int sangue;
public string clã;
 public void setblood(int sangue){this.sangue = sangue;}
 public void setClan (string clã){this.clã = clã;}
public int blood(){return this.sangue;}
public string clan(){return this.clã;}


public void mordida (Personagem heroi){
    heroi.setVida (heroi.life() - 5);
    setblood (blood() + 5);
}

public void transformar (vampiro Dio){
    if (clã == "LaSombra"){
        Dio.setClan ("Ventrue");
    }
    else if (clã == "Ventrue"){
        Dio.setClan ("LaSombra");
    }
    
}

}
