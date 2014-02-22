SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
%CSCPATH%\csc /reference:bin/Newtonsoft.Json.dll /target:library /out:bin/com.wordnik.client.common.dll /recurse:src\*.cs /doc:bin/com.wordnik.client.common.xml
