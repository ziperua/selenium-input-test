using System;

class SpaceShipStatusDecoder
{
    public static void DecodeHexMessage(string hexMessage)
    {
        try
        {
            byte message = Convert.ToByte(hexMessage, 16);

            int severity = message & 0b00000011;
            int device = (message >> 2) & 0b00000111;
            int failureType = (message >> 5) & 0b00000111;

            if (device < 1 || device > 5 || failureType < 1 || failureType > 6)
            {
                Console.WriteLine("invalid message: values out of range");
                return;
            }

            string[] severityLevels = { "no failure", "suspect", "critical", "severe" };
            string[] devices = { "", "power block", "transmitter", "receiver", "camera", "trust engine" };
            string[] failureTypes = {
                "", "overheating", "device not responding", "breaks in communication",
                "using too much power", "unknown failure", "circuits failure"
            };

            Console.WriteLine($"severity: {severityLevels[severity]}");
            Console.WriteLine($"device: {devices[device]}");
            Console.WriteLine($"failure type: {failureTypes[failureType]}");
        }
        catch
        {
            Console.WriteLine("Invalid message: unable to parse.");
        }
    }

    public static void Main()
    {
        Console.Write("enter HEX message: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input))
        {
            DecodeHexMessage(input);
        }
        else
        {
            Console.WriteLine("no input provided");
        }
    }
}