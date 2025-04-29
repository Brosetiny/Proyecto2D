using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{

    public AudioClip bandaSonora;

    public AudioClip fxButton;

    public AudioClip fxCoin;

    public AudioClip fxDead;

    public AudioClip fxFire;

    AudioSource _audioSource;

    public static AudioManagerScript Instance;

    public GameObject musicObj;

    AudioSource audioMusic;

    void Awake(){
        
        if(Instance != null && Instance != this){
            Destroy(this.gameObject);
        }
        else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
        _audioSource = this.GetComponent<AudioSource>();
      
        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = bandaSonora;
        audioMusic.loop = true;
        audioMusic.Play();
        audioMusic.volume = 0.1f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SonarClip(AudioClip ac){
        _audioSource.PlayOneShot(ac);
    }
}
