using System.Runtime.CompilerServices;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    
    Vector3 pos = new Vector3(0f, 0f, 0f);
    Vector3 dir = new Vector3(1, 1, 0);
    bool validacaoy = true;
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float LimiteEsquerda = -5.68f;
    [SerializeField] private float LimiteDireita = 5.68f;
    [SerializeField] private float LimiteCima = 2.7f;
    [SerializeField] private float LimiteBaixo = -3.6f;

    void Start()
    {
        pos = transform.position;
        transform.position = pos;
    }
    void Update()
    {
        //=======================================AWSD===============================================

        //=================================DIREITA/EQUERDA==========================================
        if (Input.GetKey(KeyCode.D) && transform.position.x < LimiteDireita)
        {
            pos.x += dir.x * velocidade * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > LimiteEsquerda)
        {
            pos.x -= dir.x * velocidade * Time.deltaTime;
            transform.position = pos;
        }
        //===================================BAIXO/CIMA=============================================
         if (Input.GetKey(KeyCode.W) && transform.position.y < LimiteCima)
        {
            pos.y += dir.y * velocidade * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > LimiteBaixo)
        {
            pos.y -= dir.y * velocidade * Time.deltaTime;
            transform.position = pos;
        }

        //=====================================SETINHAS=============================================

        //=================================DIREITA/EQUERDA==========================================
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < LimiteDireita)
        {
            pos.x += dir.x * velocidade * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > LimiteEsquerda)
        {
            pos.x -= dir.x * velocidade * Time.deltaTime;
            transform.position = pos;
        }
        //===================================BAIXO/CIMA=============================================
         if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < LimiteCima)
        {
            pos.y += dir.y * velocidade * Time.deltaTime;
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > LimiteBaixo)
        {
            pos.y -= dir.y * velocidade * Time.deltaTime;
            transform.position = pos;
        }
    }
}
