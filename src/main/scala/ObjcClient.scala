import com.wordnik.swagger.codegen.BasicObjcGenerator

object ObjcClient extends BasicObjcGenerator {
  def main(args: Array[String]) = generateClient(args)

  // where to write generated code
  override def destinationDir = "generated-code/objc"

  // to avoid recompiling ...
  override def templateDir = "src/main/resources/objc"

  // supporting classes
  override def supportingFiles =
    List(
      ("NIKSwaggerObject.h", destinationDir, "NIKSwaggerObject.h"),
      ("NIKSwaggerObject.m", destinationDir, "NIKSwaggerObject.m"),
      ("NIKApiInvoker.h", destinationDir, "NIKApiInvoker.h"),
      ("NIKApiInvoker.m", destinationDir, "NIKApiInvoker.m"),
      ("NIKFile.h", destinationDir, "NIKFile.h"),
      ("NIKFile.m", destinationDir, "NIKFile.m"),
      ("NIKDate.h", destinationDir, "NIKDate.h"),
      ("NIKDate.m", destinationDir, "NIKDate.m"))
}
