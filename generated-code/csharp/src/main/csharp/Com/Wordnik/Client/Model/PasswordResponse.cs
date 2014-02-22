using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class PasswordResponse {
    /* User's security question, returned on reset request when no email confirmation required. */
    public string security_question { get; set; }

    /* True if password updated or reset request granted via email confirmation. */
    public bool success { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordResponse {\n");
      sb.Append("  security_question: ").Append(security_question).Append("\n");
      sb.Append("  success: ").Append(success).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
