using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Tables {
    /* Array of tables and their properties. */
    public List<Table> table { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Tables {\n");
      sb.Append("  table: ").Append(table).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
