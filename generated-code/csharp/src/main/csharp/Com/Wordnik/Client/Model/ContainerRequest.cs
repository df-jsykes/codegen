using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class ContainerRequest {
    /* Identifier/Name for the container. */
    public string name { get; set; }

    /* Same as name for the container, for consistency. */
    public string path { get; set; }

    /* Storage type specific properties. */
    public string _property_ { get; set; }

    /* An array of name-value pairs. */
    public List<string> metadata { get; set; }

    /* An array of folders to create. */
    public List<FolderRequest> folder { get; set; }

    /* An array of files to create. */
    public List<FileRequest> file { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContainerRequest {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  path: ").Append(path).Append("\n");
      sb.Append("  _property_: ").Append(_property_).Append("\n");
      sb.Append("  metadata: ").Append(metadata).Append("\n");
      sb.Append("  folder: ").Append(folder).Append("\n");
      sb.Append("  file: ").Append(file).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
