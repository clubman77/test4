using UnityEngine;
//using System.Collections;


public class JumpScript : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip JumpSound;
    [SerializeField] private AudioClip Jump01Sound;
    [SerializeField] private AudioClip Jump0BSound;
    [SerializeField] private AudioClip WinSound;
    [SerializeField] private AudioClip LoseSound;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        //audioSource.PlayOneShot(JumpSound);

    }

    void Update()
    {
        Animator anim = GetComponent<Animator>();   // ...(1)
        AnimatorStateInfo state = anim.GetCurrentAnimatorStateInfo(0);   // ...(3)

        //anim.SetBool("is_Lose", true);

        //止まってるときと動いてる時でSpaceキーの動作割り当てを変えたいけどうまくできなかった。
       // if (Input.GetKey(KeyCode.Space))   // ...(2)
          if (Input.GetKeyDown(KeyCode.Space))   // ...(2)
        {

            if (state.IsName("Locomotion.WalkRun"))
            {
                Debug.Log(state.IsName("WalkRun"));
                anim.SetBool("is_jumping", true);
                audioSource.PlayOneShot(JumpSound);

            }
            else
            {
                Debug.Log("Idle or not");
                Debug.Log(state.IsName("Locomotion.Idle"));
               //    anim.SetBool("is_jumping0B", true);
            }   // ...(4)
        }
        
        if (state.IsName("Locomotion.Jump"))   // ...(4)
            {
            anim.SetBool("is_jumping", false);
            //anim.SetBool("is_jumping01", false);
        }
        else
            {
           //     anim.SetBool("is_jumping0B", false);
            }

        //Qで音声
        if (Input.GetKeyDown(KeyCode.Q))   // ...(2)
        {
            audioSource.PlayOneShot(JumpSound);
            Debug.Log("JumpSound_Q");
        }

        //Zで勝利ポーズ
        if (Input.GetKeyDown(KeyCode.Z))   // ...(2)
        {
          anim.SetBool("is_Win", true);
          audioSource.PlayOneShot(WinSound);

        }

        if (state.IsName("Locomotion.Win"))   // ...(4)
        {
            anim.SetBool("is_Win", false);
        }

        //CでJump01
        if (Input.GetKeyDown(KeyCode.C))   // ...(2)
        {
            anim.SetBool("is_jumping01", true);
            audioSource.PlayOneShot(Jump01Sound);
        }

        if (state.IsName("Locomotion.Jump01"))   // ...(4)
        {
            anim.SetBool("is_jumping01", false);
        }

        //XでJump0B
        if (Input.GetKeyDown(KeyCode.X))   // ...(2)
        {
            anim.SetBool("is_jumping0B", true);
            audioSource.PlayOneShot(Jump0BSound);
        }

        if (state.IsName("Locomotion.Jump0B"))   // ...(4)
        {
            anim.SetBool("is_jumping0B", false);
        }

        //LでLose
        if (Input.GetKeyDown(KeyCode.L))   // ...(2)
        {
            anim.SetBool("is_Lose", true);
            audioSource.PlayOneShot(LoseSound);
        }

        if (state.IsName("Locomotion.Lose"))   // ...(4)
        {
            anim.SetBool("is_Lose", false);
        }

    }
}