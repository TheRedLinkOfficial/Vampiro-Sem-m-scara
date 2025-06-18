using UnityEngine;

public class Hero : Personagem
{
  int coragem;
  int hamon;

  public void setCourage(int coragem){this.coragem = coragem;}
  public void sethamon(int hamon){this.hamon = hamon;}
  public int ripple(){return this.hamon;}
  public int courage(){return this.coragem;}

}
