using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class FolderRequest {
    /* Identifier/Name for the folder, localized to requested resource. */
    public string name { get; set; }

    /* Full path of the folder, from the service including container. */
    public string path { get; set; }

    /* Storage type specific properties. */
    public string _property_ { get; set; }

    /* An array of name-value pairs. */
    public List<string> metadata { get; set; }

    /* An array of sub-folders to create. */
    public List<FolderRequest> folder { get; set; }

    /* An array of files to create. */
    public List<FileRequest> file { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FolderRequest {\n");
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
