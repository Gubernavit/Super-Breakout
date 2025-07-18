using UnityEngine;

public class impulso : MonoBehaviour
{
    Rigidbody2D Direcao;
    [SerializeField] private float Velocidade = 3f;
    void Start()
    {
        Direcao = GetComponent<Rigidbody2D>();
        Direcao.linearVelocity = new Vector2(Velocidade, Velocidade);
    }

    void Update(){}
}
