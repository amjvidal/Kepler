using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalMenager : MonoBehaviour
{
    [SerializeField] private string lei1Simulacao;
    [SerializeField] private string lei1Teoria;
    [SerializeField] private string lei2Simulacao;
    [SerializeField] private string lei2Teoria;
    [SerializeField] private string lei3Simulacao;
    [SerializeField] private string lei3Teoria;
    [SerializeField] private string planetas;
    [SerializeField] private string simulacao;
    [SerializeField] private string creditos;


    public void AbrirSimulacaoLei1()
    {
        SceneManager.LoadScene(lei1Simulacao);
    }

    public void AbrirSimulacaoLei2()
    {
        SceneManager.LoadScene(lei2Simulacao);
    }

    public void AbrirSimulacaoLei3()
    {
        SceneManager.LoadScene(lei3Simulacao);
    }

    public void AbrirTeoriaLei1()
    {
        SceneManager.LoadScene(lei1Teoria);
    }

    public void AbrirTeoriaLei2()
    {
        SceneManager.LoadScene(lei2Teoria);
    }

    public void AbrirTeoriaLei3()
    {
        SceneManager.LoadScene(lei3Teoria);
    }

    public void AbrirPlanetas()
    {
        SceneManager.LoadScene(planetas);
    }
    public void AbrirSimulacao()
    {
        SceneManager.LoadScene(simulacao);
    }

    public void AbrirCreditos()
    {
        SceneManager.LoadScene(creditos);
    }
}
