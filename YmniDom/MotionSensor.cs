public class MotinSensor {
    public event MotionEventHandler OnMotionDetected;

    public void DetectMotion(bool isMotion) {
        if (isMotion) {
            OnMotionDetected?.Invoke("! Обнаружено движение в коридоре!");
        }
    }
}