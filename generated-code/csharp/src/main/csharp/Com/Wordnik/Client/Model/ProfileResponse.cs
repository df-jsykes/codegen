using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class ProfileResponse {
    /* Email address of the current user. */
    public string email { get; set; }

    /* First name of the current user. */
    public string first_name { get; set; }

    /* Last name of the current user. */
    public string last_name { get; set; }

    /* Full display name of the current user. */
    public string display_name { get; set; }

    /* Phone number. */
    public string phone { get; set; }

    /* Question to be answered to initiate password reset. */
    public string security_question { get; set; }

    /* Id of the application to be launched at login. */
    public integer default_app_id { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProfileResponse {\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  first_name: ").Append(first_name).Append("\n");
      sb.Append("  last_name: ").Append(last_name).Append("\n");
      sb.Append("  display_name: ").Append(display_name).Append("\n");
      sb.Append("  phone: ").Append(phone).Append("\n");
      sb.Append("  security_question: ").Append(security_question).Append("\n");
      sb.Append("  default_app_id: ").Append(default_app_id).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
