using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    [System.Serializable]
    public class SinWave{
        public float freqency;
        public float amplitude;

        public float Update(){
            return Mathf.Sin(Time.time * freqency) * amplitude;
        }

        public static Vector3 ToVector(SinWave x, SinWave y, SinWave z){
            return new Vector3(
                x.Update(),
                y.Update(),
                z.Update()
            );
        }
    }
    
    public SinWave x;
    public SinWave y;
    public SinWave z;

    Vector3 defaultPosition;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = defaultPosition;
        newPosition += SinWave.ToVector(x, y, z);
        transform.position = newPosition;
    }
}
