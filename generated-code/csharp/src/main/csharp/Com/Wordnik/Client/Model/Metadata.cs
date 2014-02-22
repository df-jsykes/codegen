using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Metadata {
    /* Array of table schema. */
    public List<string> schema { get; set; }

    /* Record count returned for GET requests. */
    public integer count { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Metadata {\n");
      sb.Append("  schema: ").Append(schema).Append("\n");
      sb.Append("  count: ").Append(count).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
