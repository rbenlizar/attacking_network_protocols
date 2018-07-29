// DnsServer.csx - Simple DNS Server
// Expose console methods like WriteLine at global level.
using static System.Console;

// Create the DNs server template
var template = new DnsServerTemplate();

// Setup the response addresses
template.ResponseAddress = "<IPV4 address of proxy to actually send to>";
template.ResponseAddress6 = "<IPv6 address of proxy to actually send to>";
template.ReverseDns = "<domain name expected to route to the proxy addresses>";

// Create DNS server instance and start
var service = template.Create();
service.Start();
WriteLine("Created {0}", service);
WriteLine("Press Enter to exit...");
ReadLine();
service.Stop();
