using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class EmailAddress {
    /* Optional name displayed along with the email address. */
    public string name { get; set; }

    /* Required email address. */
    public string email { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailAddress {\n");
      sb.Append("  name: ").Append(name).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
