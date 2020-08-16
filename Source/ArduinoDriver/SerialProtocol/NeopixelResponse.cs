namespace ArduinoDriver.SerialProtocol
{
    public class NeopixelResponse : ArduinoResponse
    {
        public byte Red { get; private set; }
        public byte Green { get; private set; }
        public byte Blue { get; private set; }

        public NeopixelResponse(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
