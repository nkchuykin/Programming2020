using System;
using System.Collections.Generic;
public class RoadCenter : ITrackingCenter
{
    private List<Camera> cameras = new List<Camera>();
    public void AddCamera(int id, int maxSpeed)
    {
        throw new NotImplementedException();
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        throw new NotImplementedException();
    }

    public void GetData(string inFilePath)
    {
        throw new NotImplementedException();
    }
}