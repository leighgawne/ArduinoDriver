namespace ArduinoDriver.SerialProtocol
{
    public class NozzlePressureRequest : ArduinoRequest
    {
        public NozzlePressureRequest()
            : base(CommandConstants.NozzlePressure)
        {
        }
    }
}
