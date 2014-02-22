using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class File {
    /* Identifier/Name for the file, localized to requested resource. */
    public string name { get; set; }

    /* Full path of the file, from the service including container. */
    public string path { get; set; }

    /* The media type of the content of the file. */
    public string content_type { get; set; }

    /* Storage type specific properties. */
    public string _property_ { get; set; }

    /* An array of name-value pairs. */
    public List<string> metadata { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class File {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  path: ").Append(path).Append("\n");
      sb.Append("  content_type: ").Append(content_type).Append("\n");
      sb.Append("  _property_: ").Append(_property_).Append("\n");
      sb.Append("  metadata: ").Append(metadata).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
