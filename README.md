# chatTcpConnect
Short but meaningful project with deep roots in network programming, internet sockets and tcp connections.

It all started with a simple program with one question in mind: How does data actually move across the internet?
To find out more about the matter, this project started out with the absolute fundamentals of network programming, which is studying the core differences between UDP (User Datagram Protocol) and TCP (Transmission Control Protocol) sockets, understanding handshakes, and learning how data packets are streamlined.
After discussions and theory, the first milestone was building a simple, one-way, single-message TCP connection. It worked, but only under certain, almost perfect conditions. As soon as we pushed the boundaries, reality hit. The application began failing to uphold continuous connections, and unpredictably crashing.
That frustration was the motiviation in this project. Troubleshooting those early errors revealed the critical missing piece: asynchrony.
Synchronous connections easily freeze and crash under real-world network conditions. This realization led directly to this exact project, where we replaced the old synchronous connections, with async ones :)
