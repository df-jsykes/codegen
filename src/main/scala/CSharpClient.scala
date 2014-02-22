import com.wordnik.swagger.codegen._

import com.wordnik.swagger.model._

object CSharpClient extends CSharpClient {
  def main(args: Array[String]) = generateClient(args)
}

class CSharpClient extends BasicCSharpGenerator {
  val outputDir = "generated-code/csharp"

  // where to write generated code
  override def destinationDir = outputDir + "/src/main/csharp"

  // package for models
  override def modelPackage = Some("com.dreamfactory.model")

  // package for api classes
  override def apiPackage = Some("com.dreamfactory.api")

  additionalParams ++= Map(
    "artifactId" -> "android-client", 
    "artifactVersion" -> "1.0.0",
    "groupId" -> "com.dreamfactory")

  // supporting classes
  override def supportingFiles =
    List(
      ("apiInvoker.mustache", destinationDir + java.io.File.separator + invokerPackage.get.replace(".", java.io.File.separator) + java.io.File.separator, "ApiInvoker.java"),
      ("apiException.mustache", destinationDir + java.io.File.separator + invokerPackage.get.replace(".", java.io.File.separator) + java.io.File.separator, "ApiException.java"),
      ("Newtonsoft.Json.dll", "generated-code/csharp/bin", "Newtonsoft.Json.dll"),
      ("compile.mustache", "generated-code/csharp", "compile.bat"))
}