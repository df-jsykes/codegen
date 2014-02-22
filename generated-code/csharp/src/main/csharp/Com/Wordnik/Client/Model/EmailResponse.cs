using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class EmailResponse {
    /* Number of emails successfully sent. */
    public integer count { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailResponse {\n");
      sb.Append("  count: ").Append(count).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
