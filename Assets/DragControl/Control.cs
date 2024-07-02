using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class Control : MonoBehaviour
    {
        public Transform earthTransform;
        public float[] planetRadius;
        public float[] planetForce;
        private Rigidbody2D earthRigidbody2D;
        private Vector3 forceDirection;
        private float distance;
        private int vertexCount = 40;
        public LineRenderer lineRendererCircle1;
        public LineRenderer lineRendererCircle2;
        public LineRenderer lineRendererCircle3;
        private void Start()
        {
            earthRigidbody2D = earthTransform.GetComponent<Rigidbody2D>();
            lineRendererCircle1.positionCount = vertexCount;
            lineRendererCircle2.positionCount = vertexCount;
            lineRendererCircle3.positionCount = vertexCount;
        }
        public int DistanceCharge(float distance)
        {
            if (distance>= planetRadius[1])
            { return 2; }
            else if (distance >= planetRadius[0])
            { return 1; }
            else { return 0; }
        }
        private void Update() 
        {
            DrawCircle(lineRendererCircle1, planetRadius[0]);
            DrawCircle(lineRendererCircle2, planetRadius[1]);
            DrawCircle(lineRendererCircle3, planetRadius[2]);
            distance = Vector3.Distance(transform.position, earthTransform.position) - 1.3f;
            forceDirection = (transform.position - earthTransform.position).normalized;
            if (!(distance >= planetRadius[2]))
            {  earthRigidbody2D.AddForce(forceDirection * planetForce[DistanceCharge(distance)],ForceMode2D.Force);}
           
        }
        private void DrawCircle(LineRenderer lineRenderer,float radius)
        {
            for (int i = 0; i < vertexCount; i++)
            {
                float angle = i *2f*Mathf.PI/vertexCount;
                float x = transform.position.x+Mathf.Cos(angle)*radius;
                float y = transform.position.y + Mathf.Sin(angle) * radius;
                lineRenderer.SetPosition(i,new Vector3(x,y,0f));
            }
        }
    }
}

