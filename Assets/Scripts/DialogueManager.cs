using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text text;

    private Queue<string> sentences;
    private object sentence;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine("TypeSentance", sentence);
    }

    IEnumerator TypeSentance(string sentence)
    {
        text.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            text.text += letter;
            if (letter == '.' || letter == ',')
            {
                yield return new WaitForSecondsRealtime(0.45f);
            } else
            {
                yield return new WaitForSecondsRealtime(0.045f);
            }
        }
    }

    void EndDialogue()
    {
        Debug.Log("End");
    }
}
