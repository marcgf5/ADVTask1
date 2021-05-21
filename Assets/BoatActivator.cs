using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class BoatActivator : MonoBehaviour
{

    [SerializeField] private PlayableDirector timeline;
    [SerializeField] private Text appleNumberText;
    [SerializeField] private AudioSource appleSound;

    private int appleNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("BoatActivator"))
        {
            if (appleNumber >= 5)
            {
                timeline.Play();
            }
        } else if (other.tag.Equals("Apple"))
        {
            appleNumber += 1;
            GameObject.Destroy(other.gameObject);
            appleNumberText.text = appleNumber.ToString();
            appleSound.Play();
        }
            
    }
}
