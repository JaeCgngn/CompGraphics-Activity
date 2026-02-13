using UnityEngine;
using UnityEngine.VFX;
using System.Collections;

public class LevelUp : MonoBehaviour
{
    [SerializeField] private VisualEffect levelUpVFX;
    private Animator anim;

    private bool lvlUp;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !lvlUp)
        {
            anim.SetTrigger("PowerUp");
            levelUpVFX.Play();
            lvlUp = true;

            StartCoroutine(ResetBool(0.5f));
        }
    }

    IEnumerator ResetBool(float delay = 0.1f)
    {
        yield return new WaitForSeconds(delay);
        lvlUp = false;
    }
}
