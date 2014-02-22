using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class HostInfo {
    /* URL, server name, or * to define the CORS host. */
    public string host { get; set; }

    /* Allow this host's configuration to be used by CORS. */
    public bool is_enabled { get; set; }

    /* Allowed HTTP verbs for this host. */
    public List<string> verbs { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HostInfo {\n");
      sb.Append("  host: ").Append(host).Append("\n");
      sb.Append("  is_enabled: ").Append(is_enabled).Append("\n");
      sb.Append("  verbs: ").Append(verbs).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
