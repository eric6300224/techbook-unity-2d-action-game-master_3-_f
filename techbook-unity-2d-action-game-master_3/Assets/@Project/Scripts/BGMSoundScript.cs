using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMSoundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private static BGMSoundScript instance = null;

    public static BGMSoundScript Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);

        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
