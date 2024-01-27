using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip music1;
    public AudioClip music2;
    public AudioClip music3;
    public AudioClip music4;
    public AudioClip music5;
    private AudioSource audioSource;

    private Dialogue dialogue;

    void Start()
    {
        // Obtenha o AudioSource deste GameObject
        audioSource = GetComponent<AudioSource>();

        // Inicie com a primeira música
        audioSource.clip = music1;
        audioSource.Play();

        // Encontre o componente Dialogue
        dialogue = GameObject.FindObjectOfType<Dialogue>();
    }

  void Update()
{
    int dialogueIndex = dialogue.GetIndex();
    Debug.Log("Dialogue Index: " + dialogueIndex);
    if (dialogueIndex >= 90 && dialogueIndex <= 100)
    {
        Debug.Log("Changing to music2");
        ChangeMusic(music2);
    }

    else if ((dialogueIndex > 40 && dialogueIndex <= 45)||(dialogueIndex < 40 && dialogueIndex  >= 29 && dialogueIndex != 30))
    {
        Debug.Log("Changing to music2");
        ChangeMusic(music3);
    }
    else if(dialogueIndex >= 5 && dialogueIndex <= 22){
        ChangeMusic(music5);
    }
    else if(dialogueIndex == 28 || dialogueIndex == 30){
        ChangeMusic(music4);
    }
    
    
}

void ChangeMusic(AudioClip newMusic)
{
  
    if (audioSource.clip != newMusic)
    {
        
        audioSource.Stop();

       
        audioSource.clip = newMusic;

       
        audioSource.Play();
    }
}
}