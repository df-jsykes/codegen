using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class ContainersResponse {
    /* An array of containers. */
    public List<Container> container { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ContainersResponse {\n");
      sb.Append("  container: ").Append(container).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
