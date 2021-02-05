using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ゴールを制御するスクリプト
public class Goal : MonoBehaviour
{
	// ゴールした時に再生する SE
	public AudioClip m_goalClip;

    [Header("關卡"),Range(0, 10)]
    public int Set_Next_Stage;

    public GameObject Player;

    // ゴールしたかどうか
    private bool m_isGoal;

    private enum Stage_Level
    {
        Stage1,
        Stage2,
        Stage3,
    }

    private Dictionary<Stage_Level, Stage_Level> Transition_Target = 
        new Dictionary<Stage_Level, Stage_Level>()
    {
        { Stage_Level.Stage1, Stage_Level.Stage3},
        { Stage_Level.Stage2, Stage_Level.Stage1},
        { Stage_Level.Stage3, Stage_Level.Stage2},
    };

    private Dictionary<Stage_Level, Vector3> Start_Position =
        new Dictionary<Stage_Level, Vector3>()
        {
            { Stage_Level.Stage1, new Vector3()}
        };



	// 他のオブジェクトと当たった時に呼び出される関数
	private void OnTriggerEnter2D( Collider2D other )
	{
		// まだゴールしておらず
		if ( !m_isGoal )
		{
			// 名前に「Player」が含まれるオブジェクトと当たったら
			if ( other.name.Contains( "Player" ) )
			{
				// シーンに存在する CameraShaker スクリプトを検索する
				var cameraShake = FindObjectOfType<CameraShaker>();

				// CameraShaker を使用してカメラを揺らす
				cameraShake.Shake();

				// 何回もゴールしないように、ゴールしたことを記憶しておく
				m_isGoal = true;

				// ゴールのアニメーターを取得する
				var animator = GetComponent<Animator>();

				// ゴールした時のアニメーションを再生する
				animator.Play( "Pressed" );

				// ゴールした時の SE を再生する
				var audioSource = FindObjectOfType<AudioSource>();
				audioSource.PlayOneShot( m_goalClip );

                //Transite to next Stage
                int intlevel = SceneManager.GetActiveScene().buildIndex;
                //intlevel++;
                //SceneManager.LoadScene(intlevel);

                //Test Diction
                Stage_Level test = (Stage_Level)Set_Next_Stage;
                //int test1 = (int)Transition_Target[test];
                //SceneManager.LoadScene((int)Transition_Target[(Stage_Level)intlevel]);
                SceneManager.LoadScene(Set_Next_Stage);
            }
		}
	}
}