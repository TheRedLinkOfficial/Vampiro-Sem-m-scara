using UnityEngine;

public class Inimigo : Personagem
{
    public enum armaInimiga{ Estaca, fogo, magia}

    public enum armaduraInimiga{ Alho, Couro, aço}

    [SerializeField]
    private armaduraInimiga armadura;
    [SerializeField]
    private armaInimiga arma;

    public void setArmor(armaduraInimiga armadura){
        this.armadura = armadura;
    }

    public void setWeapon(armaInimiga arma){
        this.arma = arma;
    }

        public armaduraInimiga armor(){
            return this.armadura;
        }

        public armaInimiga weapon(){
            return this.arma;
        }


        public int MassiveDMG(){
            int dano = 0;

            switch (arma)
            {
                case armaInimiga.Estaca:
                dano = dano + 6;
                break;

                case armaInimiga.fogo:
                dano = dano + 12;
                break;

                case armaInimiga.magia:
                dano = dano + 8;
                break;
                
            
            }
            return dano;
        }
    


}
