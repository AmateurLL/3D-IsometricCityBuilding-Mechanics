using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    
    private Vector3 cameraOriginPoint;
    private Vector3 offset;
    private bool cameraDragging;
    private float cameraSpeed = 8.0f;


    private void LateUpdate()
    {
        CameraZoomControl();
        CameraMove();
    }

    void CameraZoomControl(){
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * Camera.main.orthographicSize, 2.5f, 50.0f);
    }

    void CameraMove(){

        // Mouse Camera Drag controls
        /*
        if(Input.GetMouseButton(1)){
            offset = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            if(!cameraDragging){
                cameraDragging = true;
                cameraOriginPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }else{
            cameraDragging = false;
        }

        if(cameraDragging){
            transform.position = cameraOriginPoint - offset;
        }
        */
        //////////////////////////////////////////////////////////
        // WSAD control camera movement
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.up * (cameraSpeed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.down * (cameraSpeed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * (cameraSpeed * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * (cameraSpeed * Time.deltaTime));
        }

    }
}
