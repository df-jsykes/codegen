using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Resources {
    /* Array of resources available by this service. */
    public List<Resource> resource { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Resources {\n");
      sb.Append("  resource: ").Append(resource).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
