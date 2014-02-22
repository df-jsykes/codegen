using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class ContainersRequest {
    /* An array of containers to modify. */
    public List<Container> container { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContainersRequest {\n");
      sb.Append("  container: ").Append(container).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
