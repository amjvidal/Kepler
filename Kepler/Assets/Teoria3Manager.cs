using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teoria3Manager : MonoBehaviour
{
    [SerializeField] private string telaSimulacao;
    [SerializeField] private string telaProximaLei;
    [SerializeField] private string menu;

    public void AbrirSimulacao()
    {
        SceneManager.LoadScene(telaSimulacao);
    }

    public void AbrirProximaLei()
    {
        SceneManager.LoadScene(telaProximaLei);
    }

    public void Voltar()
    {
        SceneManager.LoadScene(menu);
    }
}
