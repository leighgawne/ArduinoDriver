namespace ArduinoDriver.SerialProtocol
{
    public class NozzlePressureResponse : ArduinoResponse
    {
        public byte Byte1 { get; private set; }
        public byte Byte2 { get; private set; }
        public byte Byte3 { get; private set; }
        public byte Byte4 { get; private set; }

        public NozzlePressureResponse(
            byte byte1, 
            byte byte2, 
            byte byte3, 
            byte byte4)
        {
            Byte1 = byte1;
            Byte2 = byte2;
            Byte3 = byte3;
            Byte4 = byte4;
        }
    }
}
