using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class PasswordRequest {
    /* Old password to validate change during a session. */
    public string old_password { get; set; }

    /* New password to be set. */
    public string new_password { get; set; }

    /* User's email to be used with code to validate email confirmation. */
    public string email { get; set; }

    /* Code required with new_password when using email confirmation. */
    public string code { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordRequest {\n");
      sb.Append("  old_password: ").Append(old_password).Append("\n");
      sb.Append("  new_password: ").Append(new_password).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  code: ").Append(code).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
