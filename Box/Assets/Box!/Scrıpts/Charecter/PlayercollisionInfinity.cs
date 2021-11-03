using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayercollisionInfinity: MonoBehaviour
{
    public AudioSource Au;
    public AudioClip Clip;
    public GameObject EndScreen;
    bool GameHasEnded = false;
    public Material renk;
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Text fragments;
    public Text fragments1;
    public GameObject score;

    public float cubeSize = 0.2f;
    public int cubeInRow = 5;
    public float explosinRadius = 0.5f;
    public float explosionForce = 2000f;
    public float explosinUpward = 0.2f;
    public int LittleCubes;
    public int collected;
   


    public void Start()
    {
        PlayerPrefs.GetInt("LO");
        LittleCubes = 0;
        score.SetActive(true);


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                Time.timeScale = 1f;
            }
            else
            {
                Pause();
                Time.timeScale = 0f;
            }
        }
        fragments.text = LittleCubes.ToString();
        fragments1.text = LittleCubes.ToString();

    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Explode();
            EndGame();



        }
        if (collisioninfo.collider.tag == "Collactable")
        {
            LittleCubes += 1;
            Au.PlayOneShot(Clip);
        }


    }
    public void Explode()
    {
        gameObject.SetActive(false);
        for (int x = 0; x < cubeInRow; x++)
        {
            for (int y = 0; y < cubeInRow; y++)
            {
                for (int z = 0; z < cubeInRow; z++)
                {
                    CreatePiece(x, y, z);
                }
            }
        }
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosinRadius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosinRadius, explosinUpward);


            }

        }


    }
    void CreatePiece(int x, int y, int z)
    {
        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);
        piece.transform.position = transform.position + new Vector3(cubeSize * x, cubeSize * y, cubeSize * z);
        piece.transform.localScale = new Vector3(cubeSize, cubeSize, cubeSize);
        piece.AddComponent<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize / 2;
        piece.GetComponent<MeshRenderer>().material.color = renk.color;
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
        }
        Invoke("Getscreen", 1f);
        collected = LittleCubes + PlayerPrefs.GetInt("LO", 0);
        PlayerPrefs.SetInt("LO", collected);
        score.SetActive(false);

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;

    }
    void Getscreen()
    {
        EndScreen.SetActive(true);
    }
    
    public void Menuscreen()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
