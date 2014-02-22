using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Wordnik.Client.Model {
  public class ConfigRequest {
    /* Default Role Id assigned to newly registered users, set to null to turn off open registration. */
    public integer open_reg_role_id { get; set; }

    /* Set to an email-type service id to require email confirmation of newly registered users. */
    public integer open_reg_email_service_id { get; set; }

    /* Default email template used for open registration email confirmations. */
    public integer open_reg_email_template_id { get; set; }

    /* Set to an email-type service id to allow user invites and invite confirmations via email service. */
    public integer invite_email_service_id { get; set; }

    /* Default email template used for user invitations and confirmations via email service. */
    public integer invite_email_template_id { get; set; }

    /* Set to an email-type service id to require email confirmation to reset passwords, otherwise defaults to security question and answer. */
    public integer password_email_service_id { get; set; }

    /* Default email template used for password reset email confirmations. */
    public integer password_email_template_id { get; set; }

    /* Role Id assigned for all guest sessions, set to null to require authenticated sessions. */
    public integer guest_role_id { get; set; }

    /* Comma-delimited list of fields the user is allowed to edit. */
    public string editable_profile_fields { get; set; }

    /* CORS whitelist of allowed remote hosts. */
    public List<HostInfo> allowed_hosts { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigRequest {\n");
      sb.Append("  open_reg_role_id: ").Append(open_reg_role_id).Append("\n");
      sb.Append("  open_reg_email_service_id: ").Append(open_reg_email_service_id).Append("\n");
      sb.Append("  open_reg_email_template_id: ").Append(open_reg_email_template_id).Append("\n");
      sb.Append("  invite_email_service_id: ").Append(invite_email_service_id).Append("\n");
      sb.Append("  invite_email_template_id: ").Append(invite_email_template_id).Append("\n");
      sb.Append("  password_email_service_id: ").Append(password_email_service_id).Append("\n");
      sb.Append("  password_email_template_id: ").Append(password_email_template_id).Append("\n");
      sb.Append("  guest_role_id: ").Append(guest_role_id).Append("\n");
      sb.Append("  editable_profile_fields: ").Append(editable_profile_fields).Append("\n");
      sb.Append("  allowed_hosts: ").Append(allowed_hosts).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
