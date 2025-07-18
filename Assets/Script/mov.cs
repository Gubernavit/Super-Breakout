using Unity.Mathematics;
using UnityEngine;

public class mov : MonoBehaviour
{
    Vector3 pos = new Vector3(0f, 0f, 0f);
    bool validacaoy = true;
    bool validacaox = true;
   
    [SerializeField] private float Velocidade = 0.006f;
    [SerializeField] private float LimiteEsquerda = -6.5f;
    [SerializeField] private float LimiteDireita = 6.5f;
    [SerializeField] private float LimiteCima = 2.7f;
    [SerializeField] private float LimiteBaixo = -2.36f;
    [SerializeField] private float VaLimiteEsquerda = -6.48f;
    [SerializeField] private float VaLimiteDireita = 6.48f;
    [SerializeField] private float VaLimiteCima = 2.5f;
    [SerializeField] private float VaLimiteBaixo = -2.34f;

    void Start() { }
    void Update()
    {
                //==================================EIXO Y========================================
                if (transform.position.y <= LimiteCima && validacaoy == true)
                {
                    pos.y -= Velocidade;
                    transform.position = pos;
                    if (transform.position.y < VaLimiteBaixo)
                    {
                        validacaoy = false;
                    }
                }
                if (transform.position.y >= LimiteBaixo && validacaoy == false)
                {
                    pos.y += Velocidade;
                    transform.position = pos;
                    if (transform.position.y > VaLimiteCima)
                    {
                        validacaoy = true;
                    }
                }

                //==================================EIXO X========================================
                if (transform.position.x <= LimiteDireita && validacaox == true)
                {
                    pos.x -= Velocidade;
                    transform.position = pos;
                    if (transform.position.x < VaLimiteEsquerda)
                    {
                        validacaox = false;
                    }
                }
                if (transform.position.x >= LimiteEsquerda && validacaox == false)
                {
                    pos.x += Velocidade;
                    transform.position = pos;
                    if (transform.position.x > VaLimiteDireita)
                    {
                        validacaox = true;
                    }
                }
    }

}