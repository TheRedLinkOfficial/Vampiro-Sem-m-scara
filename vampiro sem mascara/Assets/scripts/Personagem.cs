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
  [SerializeField]
  private int velocidade;

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
  public void setSpeed(int velocidade){this.velocidade = velocidade;}
    public int life(){return this.vida;}
        public int speed(){return this.velocidade;}
    public string name(){return this.nome;}
    public bool weapon(){return this.armado;}
    public string eyes(){return this.corDosOlhos;}
    
}
