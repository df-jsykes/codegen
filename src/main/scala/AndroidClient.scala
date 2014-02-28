import com.wordnik.swagger.codegen._

import com.wordnik.swagger.model._

object AndroidClient extends AndroidClient {
  def main(args: Array[String]) = generateClient(args)
}

class AndroidClient extends BasicJavaGenerator {
  val outputDir = "generated-code/android-java"
  // where to write generated code
  override def destinationDir = outputDir + "/src/main/java"

  // templates
  override def templateDir = "src/main/resources/android-java"

  // package for api invoker, error files
  override def invokerPackage = Some("com.dreamfactory.client")

  // package for models
  override def modelPackage = Some("com.dreamfactory.model")

  // package for api classes
  override def apiPackage = Some("com.dreamfactory.api")

  // use our manually created file, defined in the supportingFiles
  override def importMapping = Map(
    "Records" -> "com.dreamfactory.Records")

  // don't make a new records model
  override def defaultIncludes = super.defaultIncludes ++ Set("Records")

  additionalParams ++= Map(
    "artifactId" -> "android-client", 
    "artifactVersion" -> "1.0.0",
    "groupId" -> "com.dreamfactory")

  // supporting classes
  override def supportingFiles = List(
    // manually-created Records.java file
    ("records.java", destinationDir + java.io.File.separator + "com.dreamfactory".replace(".", java.io.File.separator) + java.io.File.separator, "Records.java"),
    ("httpPatch.mustache", destinationDir + java.io.File.separator + invokerPackage.get.replace(".", java.io.File.separator) + java.io.File.separator, "HttpPatch.java"),
    ("apiInvoker.mustache", destinationDir + java.io.File.separator + invokerPackage.get.replace(".", java.io.File.separator) + java.io.File.separator, "ApiInvoker.java"),
    ("jsonUtil.mustache", destinationDir + java.io.File.separator + invokerPackage.get.replace(".", java.io.File.separator) + java.io.File.separator, "JsonUtil.java"),
    ("apiException.mustache", destinationDir + java.io.File.separator + invokerPackage.get.replace(".", java.io.File.separator) + java.io.File.separator, "ApiException.java"),
    ("pom.mustache", outputDir, "pom.xml")
  )
}
