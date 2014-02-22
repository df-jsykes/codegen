using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class Records {
    /* Array of records of the given resource. */
    public List<Record> record { get; set; }

    /* Available metadata for the response. */
    public Metadata meta { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Records {\n");
      sb.Append("  record: ").Append(record).Append("\n");
      sb.Append("  meta: ").Append(meta).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
