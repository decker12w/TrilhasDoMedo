using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI textDisplay;
    public string[] sentences;

    public float typingSpeed;
    private bool isTyping = false;

    private int index = 50;
    private Coroutine typingCoroutine = null;

    public Arvore arvore;

    public int GetIndex()
    {
        return index;
    }

    public void SetIndex(int newIndex)
    {
        index = newIndex;
    }
    void Start()
    {
        arvore = GameObject.FindObjectOfType<Arvore>();
       
        textDisplay.text = string.Empty;
        StartDialogue();
    }

    public void StartDialogue()
    {
        sentences = new string[] { arvore.GetDialogo(index) };
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        typingCoroutine = StartCoroutine(Type());
    }

    public IEnumerator Type()
    {
        isTyping = true;
        foreach (char letter in sentences[0].ToCharArray())
        {
            if (!isTyping) break;
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTyping = false;
    }

    public void StopTyping()
    {
        isTyping = false;
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
    }
}
