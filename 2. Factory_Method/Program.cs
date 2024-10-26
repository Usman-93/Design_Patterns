

using _2._Factory_Method.Logger;
using _2._Factory_Method.LoggerFactory;


ILoggerFactory debugLoggerFactory = new DebugLoggerFactory();
ILogger debugLogger = debugLoggerFactory.createLogger();

ILoggerFactory infoLoggerFactory = new InfoLoggerFactory();
ILogger infoLogger = infoLoggerFactory.createLogger();

debugLogger.Log("Log1");
infoLogger.Log("Log2");



