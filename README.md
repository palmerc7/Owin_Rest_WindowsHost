# Owin_Rest_WindowsHost
A proof-of-concept solution that self-hosts REST-based services within the Owin 3.x Framework.  Within the solution is an optional Windows Service host and installer components for Windows Server installation.

The motivation for this project is to host REST services with Microsoft's Open Web Interface for .Net (Owin) with very little dependencies and resources.  REST services are utilizing Web API 2.2 core libraries with attribute routing to control friendly api urls with versioning technique (i.e http://hostname:port/api/v1/product/validate).
