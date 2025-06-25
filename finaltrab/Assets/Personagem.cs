using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private int nivel;
    private int vida;
    private int mana;
    private Vector3 posicao;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }

    public Vector3 Posicao
    {
        get { return posicao; }
        set
        {
            posicao = value;
            // Atualiza a posição real do GameObject no mundo 3D
            transform.position = posicao;
        }
    }

    // Inicializa valores padrão
    protected virtual void Start()
    {
        nome = "Sem Nome";
        nivel = 1;
        vida = 100;
        mana = 50;
        Posicao = Vector3.zero;
    }

    // Método para comparar dois personagens — exemplo compara nível e vida
    public bool CompararPersonagens(Personagem outro)
    {
        return (this.nivel == outro.nivel) && (this.vida == outro.vida);
    }
}