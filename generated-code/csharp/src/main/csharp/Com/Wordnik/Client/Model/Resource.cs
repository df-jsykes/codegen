using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Resource {
    /* Name of the resource. */
    public string name { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Resource {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
