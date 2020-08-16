﻿namespace ArduinoDriver.SerialProtocol
{
    public class NeopixelRequest : ArduinoRequest
    {
        public NeopixelRequest(byte red, byte green, byte blue)
            : base(CommandConstants.NeopixelIn)
        {
            Bytes.Add(red);
            Bytes.Add(green);
            Bytes.Add(blue);
        }
    }
}
