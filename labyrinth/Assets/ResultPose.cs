using UnityEngine;
public class ResultPose : MonoBehaviour
{
    bool flg = true;

    private AudioSource audioSource;
    [SerializeField] private AudioClip WinSound;
    [SerializeField] private AudioClip LoseSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioSource.PlayOneShot(JumpSound);
    }

    void Update()
    {
        Animator anim = GetComponent<Animator>();   // ...(1)
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);   // ...(3)

       // anim.SetBool("is_Lose", true);

        if (Timer.time <= 1)
        {
            if (flg == true)
            {
                Debug.Log("is_Lose true set");

                anim.SetBool("is_Lose", true);
                Debug.Log(anim.GetBool("is_Lose"));
                
                if (state.IsName("Locomotion.Lose"))   // ...(4)
                {
                    audioSource.PlayOneShot(LoseSound);
                    anim.SetBool("is_Lose", false);
                    Debug.Log("is_Lose  false set");
                    flg = false;
                }
            }
        }
        else {
            if (Goal.goal)
            {
               // Debug.Log(Goal.goal);
               // Debug.Log(flg);

                if (flg == true) {
                    Debug.Log("is_Win true set");

                    anim.SetBool("is_Win", true);
                    //audioSource.PlayOneShot(WinSound);

                    //anim.SetBool("is_Lose", true);
                    Debug.Log(anim.GetBool("is_Win"));


                 if (state.IsName("Locomotion.Win"))   // ...(4)
                //if (state.IsName("Locomotion.Lose"))   // ...(4)
                    {
                        audioSource.PlayOneShot(WinSound);

                        anim.SetBool("is_Win", false);
                    //anim.SetBool("is_Lose", false);
                        Debug.Log("is_Win  false set");
                        flg = false;
                    }
                }
            }

        }

    }
}