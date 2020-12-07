using Cinemachine;

public static class GameSystemFacerd
{
    public static CinemachineBlendListCamera GetBlendListCameraObject
    {
        get { return _cinemachineBlendListCamera; }
    }
    private static CinemachineBlendListCamera _cinemachineBlendListCamera;

    public static void SetBlendListCamera(CinemachineBlendListCamera cinemachineBlendListCamera)
    {
        _cinemachineBlendListCamera = cinemachineBlendListCamera;
    }

}
 
