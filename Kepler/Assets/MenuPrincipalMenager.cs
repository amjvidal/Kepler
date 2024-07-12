using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalMenager : MonoBehaviour
{
    [SerializeField] private string nomeDaTela;


    public void AbrirTela()
    {
        SceneManager.LoadScene(nomeDaTela);
    }

}
