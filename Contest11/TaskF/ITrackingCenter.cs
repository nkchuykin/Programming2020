public interface ITrackingCenter
{
    void AddCamera(int id, int maxSpeed);
    void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed);
    void GetData(string inFilePath);
}