using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Success {
    /* True when API call was successful, false or error otherwise. */
    public bool success { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Success {\n");
      sb.Append("  success: ").Append(success).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
