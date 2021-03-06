using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class UserRequest {
    /* Identifier of this user. */
    public integer id { get; set; }

    /* The email address required for this user. */
    public string email { get; set; }

    /* The set-able, but never readable, password. */
    public string password { get; set; }

    /* The first name for this user. */
    public string first_name { get; set; }

    /* The last name for this user. */
    public string last_name { get; set; }

    /* Displayable name of this user. */
    public string display_name { get; set; }

    /* Phone number for this user. */
    public string phone { get; set; }

    /* True if this user is active for use. */
    public bool is_active { get; set; }

    /* True if this user is a system admin. */
    public bool is_sys_admin { get; set; }

    /* The default launched app for this user. */
    public string default_app_id { get; set; }

    /* The role to which this user is assigned. */
    public string role_id { get; set; }

    /* Related app by default_app_id. */
    public App default_app { get; set; }

    /* Related role by role_id. */
    public Role role { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRequest {\n");
      sb.Append("  id: ").Append(id).Append("\n");
      sb.Append("  email: ").Append(email).Append("\n");
      sb.Append("  password: ").Append(password).Append("\n");
      sb.Append("  first_name: ").Append(first_name).Append("\n");
      sb.Append("  last_name: ").Append(last_name).Append("\n");
      sb.Append("  display_name: ").Append(display_name).Append("\n");
      sb.Append("  phone: ").Append(phone).Append("\n");
      sb.Append("  is_active: ").Append(is_active).Append("\n");
      sb.Append("  is_sys_admin: ").Append(is_sys_admin).Append("\n");
      sb.Append("  default_app_id: ").Append(default_app_id).Append("\n");
      sb.Append("  role_id: ").Append(role_id).Append("\n");
      sb.Append("  default_app: ").Append(default_app).Append("\n");
      sb.Append("  role: ").Append(role).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
