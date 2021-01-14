# SpacecraftSimulation
A C# demo app for simulating distributed spacecraft communication via WCF.

# Description
The project has three project folders running the self-hosting WCF services:
The bin/DuplexClient.exe in the Folder DuplexClient run for DSN.exe;
The bin/host.exe in the Folder ReportService run for LaunchVehicle.exe;
The bin/host.exe in the Folder PayloadService run for Payload.exe;

This software simulates the communications between the components of Deep Space Network.

# Steps

To run the software, follow the steps:

1. This software utilizes the port 8090-8094 and 9000-9004, you are required to open the port first.
For example if I want to open port 9000, then open cmd.exe as Administrator and enter:
netsh http add urlacl url=http://+:9000/ user=\Everyone

2. In LaunchVehicleConfig.json file, update the "PayloadConfig" with the correct PayloadConfig.json path.
3. Open DSN.exe (if port 8090-8094 and 9000-9004 haven't been opened, run as Administrator). 
4. The rest operations are self-explained. 
