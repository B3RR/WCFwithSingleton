# WCFwithSingleton
WCF with Singleton and without
.NET framework 4.5.2
### Install
1) Compile
2) Open "Developer Command Promt for VS"
3) cd WCFwithSingleton\WCFwithSingleton.Service\bin\Debug\
4) installutil WCFwithSingleton.Service.exe
5) NET START WCFwithSingletonService
### Get wsdl
1) Open browser
2) Go to url - http://localhost/WCFwithSingletonWS
3) Select single or particial wsdl
### Stop
1) Open "Developer Command Promt for VS"
2) NET STOP WCFwithSingletonService
### Delete Windows Service
1) WIN+R
2) CMD
3) SC STOP WCFwithSingletonService
4) SC DELETE WCFwithSingletonService
