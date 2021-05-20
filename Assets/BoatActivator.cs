using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class BoatActivator : MonoBehaviour
{

    [SerializeField] private PlayableDirector timeline;

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
        if(other.tag.Equals("BoatActivator"))
            timeline.Play();
    }
}
