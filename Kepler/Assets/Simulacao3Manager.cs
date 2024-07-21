using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Simulacao3Manager : MonoBehaviour
{
    [SerializeField] private string telaAnterior;
    [SerializeField] private string telaTeoria;
    [SerializeField] private string telaProximaLei;
    [SerializeField] private GameObject painelMenuSimador;
    [SerializeField] private GameObject painelDefinicoes;

    public void Voltar()
    {
        SceneManager.LoadScene(telaAnterior);
    }
    public void AbrirDefinicoes()
    {
        painelDefinicoes.SetActive(true);
        painelMenuSimador.SetActive(false);
    }

    public void FecharDefinicoes()
    {
        painelDefinicoes.SetActive(false);
        painelMenuSimador.SetActive(true);
    }

    public void AbrirTeoria()
    {
        SceneManager.LoadScene(telaTeoria);
    }
    public void AbrirProximaLei()
    {
        SceneManager.LoadScene(telaProximaLei);
    }
}
