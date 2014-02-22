using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class FolderResponse {
    /* Identifier/Name for the folder, localized to requested resource. */
    public string name { get; set; }

    /* Full path of the folder, from the service including container. */
    public string path { get; set; }

    /* Storage type specific properties. */
    public string _property_ { get; set; }

    /* An array of name-value pairs. */
    public List<string> metadata { get; set; }

    /* A GMT date timestamp of when the file was last modified. */
    public string last_modified { get; set; }

    /* An array of contained sub-folders. */
    public List<FolderResponse> folder { get; set; }

    /* An array of contained files. */
    public List<FileResponse> file { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FolderResponse {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  path: ").Append(path).Append("\n");
      sb.Append("  _property_: ").Append(_property_).Append("\n");
      sb.Append("  metadata: ").Append(metadata).Append("\n");
      sb.Append("  last_modified: ").Append(last_modified).Append("\n");
      sb.Append("  folder: ").Append(folder).Append("\n");
      sb.Append("  file: ").Append(file).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
