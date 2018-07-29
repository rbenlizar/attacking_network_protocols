// PortFormatProxy.csx - Simple TCP port-forwarding proxy
// Expose methods like WriteLine and WritePackets
using static System.Console;
using static CANAPE.Cli.ConsoleUtils;

// Create proxy template
var template = new FixedProxyTemplate();
template.LocalPort = <place listening port here>;
template.Host = "<place targeted host name or IP here>";
template.Port = <place targeted port here>;

// Create proxy instance and start
var service = template.Create();
service.Start();

WriteLine("Created {0}", service);
WriteLine("Press Enter to exit...");
ReadLine();
service.Stop();

// Dump packets
var packets = service.Packets;
WriteLine("Capture {0} packets:",
	packets.Count);
WritePackets(packets);
