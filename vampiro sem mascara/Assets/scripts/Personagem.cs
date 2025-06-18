using UnityEngine;

public class Personagem :  MonoBehaviour
{
  [SerializeField]
     int vida;
  [SerializeField]
   string nome;
  [SerializeField]
  bool armado;
  [SerializeField]
   string corDosOlhos;


  public void setVida(int vida){
    this.vida = vida;
  }

  public void setnome(string nome){
    this.nome = nome;
  }
  public void setweapon(bool armado){
    this.armado = armado;
  }

public void seteyes(string corDosOlhos){
    this.corDosOlhos = corDosOlhos;
  }

    public int life(){return this.vida;}
        
    public string name(){return this.nome;}
    public bool weapon(){return this.armado;}
    public string eyes(){return this.corDosOlhos;}
    
}
