using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject EndScreen;
    public GameObject FinishScreen;
    public AudioSource Au;
    public AudioClip Clip;
    bool GameHasEnded = false;
    bool GameHasFinished = false;
    public Material renk;
    public  bool GameIsPaused = false;
    public GameObject pauseMenuUI;
   

    public float cubeSize = 0.2f;
    public int cubeInRow = 5;
    public float explosinRadius = 0.5f;
    public float explosionForce = 100f;
    public float explosinUpward = 0.2f;
    public int LittleCubes=0;
    public int collacted=0;
    

    public void Start()
    {
        PlayerPrefs.GetInt("LO");
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
        if(GameHasFinished==true)
        {
            Time.timeScale = 0f;
        }
        
        
    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            Explode();
            EndGame();
           
       

        }else if (collisioninfo.collider.tag== "Finish")
        {
            finish();
        }
        if (collisioninfo.collider.tag=="Collactable")
        {
            Au.PlayOneShot(Clip);
            LittleCubes += 1;
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
        LittleCubes = 0;

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
    void finish ()
    { 
        FinishScreen.SetActive(true);
       
        GameHasFinished = true;
        if(GameHasFinished==true&&LittleCubes>0)
        {
            collacted = PlayerPrefs.GetInt("LO") + LittleCubes;
            PlayerPrefs.SetInt("LO", collacted);
          

        }
    }
    public void Menuscreen()
    {
        SceneManager.LoadScene("Menu");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 1f;

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
    public void LoadingMenu()
    {

        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    

}
