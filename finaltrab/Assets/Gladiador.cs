using UnityEngine;

public class Gladiador : Personagem
{
    [SerializeField]
    private string armaPrincipal;
    [SerializeField]
    private string armaSecundaria;
    [SerializeField]
    private string habilidadeEspecial;

    public string ArmaPrincipal
    {
        get { return armaPrincipal; }
        set { armaPrincipal = value; }
    }

    public string ArmaSecundaria
    {
        get { return armaSecundaria; }
        set { armaSecundaria = value; }
    }

    public string HabilidadeEspecial
    {
        get { return habilidadeEspecial; }
        set { habilidadeEspecial = value; }
    }

    protected override void Start()
    {
        base.Start();
        armaPrincipal = "Tridente";
        armaSecundaria = "Rede";
        habilidadeEspecial = "Rede de Captura";
    }
}