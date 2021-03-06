using System.Collections;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;
    
    [SerializeField]
    private Animator crossfade;
   
    [SerializeField]
    private GameObject start_btn;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitUntilAudio());
    }

    IEnumerator WaitUntilAudio()
    {
        yield return new WaitWhile(() => start_btn.activeSelf);
        yield return new WaitWhile(() => source.isPlaying);

        crossfade.SetTrigger("Fade_out");
    }

    public void FadeOut()
    {
        start_btn.SetActive(false);
    }
}
