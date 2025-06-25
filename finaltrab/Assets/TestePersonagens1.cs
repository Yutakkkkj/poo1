using UnityEngine;

public class TestePersonagens : MonoBehaviour
{   [SerializeField]
    private Personagem personagemGenerico;
    [SerializeField]
    private Gladiador gladiador1;
    [SerializeField]
    private Gladiador gladiador2;

    void Start()
    {
        
        GameObject objPersonagem = new GameObject("PersonagemGenerico");
        personagemGenerico = objPersonagem.AddComponent<Personagem>();
        personagemGenerico.Nome = "Arqueiro";
        personagemGenerico.Nivel = 5;
        personagemGenerico.Vida = 80;
        personagemGenerico.Mana = 40;
        personagemGenerico.Posicao = new Vector3(0, 0, 0);

        
        GameObject objGladiador1 = new GameObject("Gladiador1");
        gladiador1 = objGladiador1.AddComponent<Gladiador>();
        gladiador1.Nome = "Maximus";
        gladiador1.Nivel = 10;
        gladiador1.Vida = 150;
        gladiador1.Mana = 60;
        gladiador1.Posicao = new Vector3(2, 0, 0);

        
        GameObject objGladiador2 = new GameObject("Gladiador2");
        gladiador2 = objGladiador2.AddComponent<Gladiador>();
        gladiador2.Nome = "Spartacus";
        gladiador2.Nivel = 12;
        gladiador2.Vida = 180;
        gladiador2.Mana = 70;
        gladiador2.ArmaPrincipal = "Tridente";
        gladiador2.ArmaSecundaria = "Rede";
        gladiador2.HabilidadeEspecial = "Rede de Captura";
        gladiador2.Posicao = new Vector3(4, 0, 0);

        
        Debug.Log($"Personagem: {personagemGenerico.Nome}, Nível: {personagemGenerico.Nivel}, Vida: {personagemGenerico.Vida}, Mana: {personagemGenerico.Mana}, Posição: {personagemGenerico.Posicao}");

        Debug.Log($"Gladiador 1: {gladiador1.Nome}, Nível: {gladiador1.Nivel}, Vida: {gladiador1.Vida}, Mana: {gladiador1.Mana}, Pos: {gladiador1.Posicao}");
        Debug.Log($"Arma Principal: {gladiador1.ArmaPrincipal}, Arma Secundária: {gladiador1.ArmaSecundaria}, Habilidade Especial: {gladiador1.HabilidadeEspecial}");

        Debug.Log($"Gladiador 2: {gladiador2.Nome}, Nível: {gladiador2.Nivel}, Vida: {gladiador2.Vida}, Mana: {gladiador2.Mana}, Pos: {gladiador2.Posicao}");
        Debug.Log($"Arma Principal: {gladiador2.ArmaPrincipal}, Arma Secundária: {gladiador2.ArmaSecundaria}, Habilidade Especial: {gladiador2.HabilidadeEspecial}");

        
        bool saoIguais = gladiador1.CompararPersonagens(gladiador2);
        Debug.Log($"Gladiador 1 e Gladiador 2 têm o mesmo nível e vida? {saoIguais}");
    }
}
